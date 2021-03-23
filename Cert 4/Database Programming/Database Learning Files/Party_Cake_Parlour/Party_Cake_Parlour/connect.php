<?php			
	$user="root";
	$password="usbw";
	$database="party_cake"; /*This DB must exist on the server */
	$host = "localhost";	
	$conn = mysqli_connect($host,$user,$password, $database) or die("Cannot connect");
	
?>