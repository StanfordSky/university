<?php 

function insert_batch($batch, $mysqli)
{
    $query = Q_INSERT_LOG;
    $query .= implode(", ", $batch);

    $result = $mysqli->query($query);

    if (!$result) {
        die("Insert Error: " . $mysqli->error);
    }
}



