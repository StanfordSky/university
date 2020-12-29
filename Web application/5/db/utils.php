<?php 

function insert_batch($batch, $mysqli)
{
    if ($mysqli->query("SELECT stop FROM status WHERE id=1")->fetch_assoc()["stop"]) {
        return;
    }
    $query = Q_INSERT_LOG;
    $query .= implode(", ", $batch);

    $result = $mysqli->query($query);

    if (!$result) {
        die("Insert Error: " . $mysqli->error);
    }
}



