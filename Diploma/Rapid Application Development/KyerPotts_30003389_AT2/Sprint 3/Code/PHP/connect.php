
<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/
$host = 'localhost';
$db   = 'movies_db';
$user = 'root';
$pass = '';
$dsn = "mysql:host=$host;dbname=$db";

// connect to db
$conn = new PDO($dsn, $user, $pass);

// set the PDO error mode to exception
$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
?>
