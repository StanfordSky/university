
CREATE TABLE `server_log` (
    `id` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    `ip` varchar(25),
    `date` timestamp,
    `path` text,
    `method` varchar(10),
    `response_code` int,
    `response_size` int,
    `user_agent` text
);


CREATE TABLE `status` (
    `id` int NOT NULL PRIMARY KEY AUTO_INCREMENT,
    `ip` varchar(25),
    `date` timestamp,
    `path` text,
    `method` varchar(10),
    `response_code` int,
    `response_size` int,
    `user_agent` text
);
