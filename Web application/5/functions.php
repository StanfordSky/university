<?php



function set_status($ready, $size, $mysqli) {
    if ($mysqli->query("SELECT stop FROM status WHERE id=1")->fetch_assoc()["stop"]) {
        return;
    }
    $status = 100 * ($ready / $size);
    mysqli_query($mysqli, 'UPDATE status SET status_log = ' . $status . ' WHERE id = 1');
}

