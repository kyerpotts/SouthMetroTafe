<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/
//Checks wether admin account is logged into the database
session_start();
if(isset($_SESSION['admin']))
{
// this line includes the HTML file header.php
include("../templates/header.php");

// Get Variables
$host = 'localhost';

// Connect to Database if login information is correct
if(isset($_SESSION['admin'])){
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
        echo "<p alt=\"Subscriber list updated.\">Subscriber list updated.</p>";
    }else{
        echo "<p alt=\"Subscriber list up to date.\">Subscriber list up to date.</p>";
    }
} catch(PDOException $e) {
    echo "ERROR: Could not run query. " . $e->getMessage();
}

echo "<p></p>";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
echo "<a class=\"button\" href=\"../admin.html\" alt=\"Back\">Back</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";

// this line includes the HTML file footer.php
include("../templates/footer.php"); 
}
else
{
    echo "Please login to an admin account!";
    header("refresh:2;url=admin_login.php");
}
?>
