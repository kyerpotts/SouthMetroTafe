<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/
// this line includes the HTML file header.php
include("../templates/header.php");

// Get Variables
$username = trim($_POST['username']);
$password = trim($_POST['password']);
$host = 'localhost';

// Connect to Database if login information is correct
if($username == "admin" && $password == "admin"){
    try {
        require("admin_connect.php");
    } catch(PDOException $e) {
        echo "ERROR: Could not connect. " . $e->getMessage();
    }
}

// Connect to Database
try {
	    $query = "SELECT * FROM members_table WHERE unsubscribe = 1";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	if($stmt->rowCount() > 0) {
        $query2 = "DELETE FROM members_table WHERE unsubscribe = 1";
		$stmt2 = $conn->prepare($query2);
        $stmt2->execute();
        echo "Subscriber list updated";
	}else{
        echo "Subscriber list up to date";
    }
} catch(PDOException $e) {
	echo "ERROR: Could not run query. " . $e->getMessage();
}

echo "<p></p>";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
echo "<a class=\"button\" href=\"../\">Back</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";

// this line includes the HTML file footer.php
include("../templates/footer.php"); 
?>