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

echo "<p></p>";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
echo "<a class=\"button\" href=\"../\">Back</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";
echo "<p></p>";

// Connect to Database if login information is correct
if($username == "admin" && $password == "admin"){
    try {
        require("admin_connect.php");
    } catch(PDOException $e) {
        echo "ERROR: Could not connect. " . $e->getMessage();
    }
}

try {
    $query = "SELECT * FROM members_table";
    $stmt = $conn->prepare($query);
    $stmt->execute();
    
    if($stmt->rowCount() > 0) {
    echo "<div class=\"row\"> <!-- Start Row Three -->";
    echo "<div class=\"col-12 col-sm-6\">";
    echo "<table class=\"table text-white\">";
    echo "<thead>";
    echo "<tr>";
    echo "<th scope=\"col\"><strong>ID</strong></th>";
    echo "<th scope=\"col\"><strong>Full Name</strong></th>";
    echo "<th scope=\"col\"><strong>Email</strong></th>";
    echo "<th scope=\"col\"><strong>Monthly Newsletter</strong></th>";
    echo "<th scope=\"col\"><strong>Breaking Newsflash</strong></th>";
    echo "<th scope=\"col\"><strong>Unsubscribe</strong></th>";
    echo "</tr>";
    echo "</thead>";

    while($row = $stmt->fetchObject()) {
        // Add found movie to table
        echo "<tbody>";
        echo "<tr>";
        echo "<th scope=\"row\">{$row->id}</td>";
        echo "<td>{$row->fullname}</td>";
        echo "<td>{$row->email}</td>";
        echo "<td>{$row->monthly_newsletter}</td>";
        echo "<td>{$row->breaking_newsflash}</td>";
        echo "<td>{$row->unsubscribe}</td>";
        echo "</tr>";
        echo "</tbody>";
    }
    echo "</table>";
    echo "</div>";
    echo "</div> <!-- End Row Three -->";
	}
} catch(PDOException $e) {
	echo "ERROR: Could not run query. " . $e->getMessage();
}



// this line includes the HTML file footer.php
include("../templates/footer.php"); 
?>