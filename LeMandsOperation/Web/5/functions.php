<?php

function set_status($ready, $size, $mysqli) {
    $status = 1000 * ($ready / $size);
    mysqli_query($mysqli, 'UPDATE status SET status_log = ' . $status . ' WHERE id = 1');
}