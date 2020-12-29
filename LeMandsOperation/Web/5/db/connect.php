
<?php 

const Q_INSERT_LOG = "INSERT INTO server_log (ip, date, path, method, response_code, response_size, user_agent) VALUES ";
const CLF_REGEX = '/^(\S+) \S+ \S+ \[([^\]]+)\] "([^"]*)" ([^"]+) ([^"]+) "[^"]*" "([^"]*)"$/m';
const DB_BATCH_SIZE = 4000;

$mysqli = new mysqli('127.0.0.1', 'root', '', 'lab5');


if ($mysqli->connect_errno) {
    echo "Error: Failed to make a MySQL connection, here is why: \n";
    echo "Error: " . $mysqli->connect_errno . "\n";
    echo "Error: " . $mysqli->connect_error . "\n";
    die();
}

