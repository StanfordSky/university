<?php

function upload_file_handler($mysqli) {
    set_time_limit(60*60);

    mb_internal_encoding("UTF-8");

    $fname = $_POST['path'];
    if (!file_exists($fname)) {
        return 'Файла не существует.';
    }
    $handler = fopen($fname, "r");
    if (!$handler) {
        return 'Не удалось открыть файл.';
    }

    $filesize = filesize($fname);
    $processed = 0;
    set_status($processed, $filesize, $mysqli);
    $batch = [];

    while (!feof($handler)) {

        try {
            if ($mysqli->query("SELECT stop FROM status WHERE id=1")->fetch_assoc()["stop"]) {
                echo 'Загрузка прекращена';
                break;
            }

            $line = fgets($handler, 4096);
            $matches = [];
            $c = preg_match_all(CLF_REGEX, $line, $matches);

            if ($c && count($matches) >= 7) {
                $ip      = substr($matches[1][0], 0, 24);
                $time    = strtotime($matches[2][0]);
                $request = explode(" ", $matches[3][0]);
                $code    = intval($matches[4][0]);
                $size    = intval($matches[5][0]);
                $uagent  = $mysqli->escape_string($matches[6][0]);

                $method = substr($mysqli->escape_string($request[0]), 0, 9);
                $path   = $mysqli->escape_string($request[1]);

                $batch[] = "('$ip', FROM_UNIXTIME('$time'), '$path', '$method', '$code', '$size', '$uagent')";
            }

            $processed += strlen($line);
            set_status($processed, $filesize, $mysqli);
            if (count($batch) > DB_BATCH_SIZE) {
                insert_batch($batch, $mysqli);
                $batch = [];
            }

        } catch (Exception $e) {
            break;
        }
    }
    fclose($handler);
    set_time_limit(60);
    exit;
}

function report_handler($mysqli) {
    if(isset($_GET['groupby'])){
        $sql = "SELECT COUNT(server_log.id) as count, DAY(server_log.date) as DMON, WEEK(server_log.date) as WYEAR, MONTH(server_log.date) as MYEAR 
        FROM server_log
        WHERE server_log.id IN 
        (
            SELECT MAX(server_log.id) FROM server_log 
            GROUP BY server_log.ip, UNIX_TIMESTAMP(server_log.date) DIV 1200 
        )
        GROUP BY DMON, WYEAR, MYEAR 
        ORDER BY " . $_GET['sort'] . " " . $_GET['raiting']. " LIMIT 0, 500";

    }else{
        $sql = "SELECT * FROM `server_log` 
        WHERE server_log.id IN 
        (
            SELECT MAX(server_log.id) FROM server_log 
            GROUP BY server_log.ip, UNIX_TIMESTAMP(server_log.date) DIV 1200 
        )
        ORDER BY " . $_GET['sort'] . " " . $_GET['raiting'] . " LIMIT 0, 500";

    }

    foreach ($mysqli->query($sql) as $key => $row){
        $array[$key] = $row;
    }
    echo json_encode($array);
}

function status_handler($mysqli) {
    return print_r($mysqli->query("SELECT status_log FROM status WHERE id=1")->fetch_assoc()["status_log"]);
}

function cancel_hadler($mysqli) {
    $mysqli->query("UPDATE status SET stop = 1, status_log = 0 WHERE id = 1");
}

function update_data_update($mysqli)
{
    $mysqli->query("UPDATE status SET stop = 0, status_log = 0 WHERE id = 1");
}