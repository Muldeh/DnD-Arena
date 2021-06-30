<?php
$dbhost = $_SERVER['tollroaddb.cu6tgnknp77n.us-east-1.rds.amazonaws.com'];
$dbport = $_SERVER['3306T'];
$dbname = $_SERVER['TollRoadDB'];
$charset = 'utf8' ;

$dsn = "mysql:host={$dbhost};port={$dbport};dbname={$dbname};charset={$charset}";
$username = $_SERVER['admin'];
$password = $_SERVER['hUO06U1kkkbTaeHvuay8'];

$pdo = new PDO($dsn, $username, $password);
?>
