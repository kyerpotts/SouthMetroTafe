<?php
/*
	23/09/2019
	Kyer Potts
	30003389
*/

$host = "localhost";
$dbname = "movies_db";
$username = "root";
$password = "";

//Connect to database
$conn = new PDO("mysql:host=$host;dbname=$dbname", $username, $password);
//Set the PDO error mode to exception
	$conn->setAttribute(PDO::ATTR_ERRMODE, PDO:: ERRMODE_EXCEPTION);
?>