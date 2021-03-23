
<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/
//Checks whether admin account is logged into the database
session_start();
if(isset($_SESSION['admin']))
{
// this line includes the HTML file header.php
include("../templates/header.php");

// Get Variables
$host = 'localhost';
$dbname = "";
$tablename = "";

if(isset($_POST['dbname']) && isset($_POST['tablename']))
{
    $dbname = trim($_POST['dbname']);
    $tablename = trim($_POST['tablename']);
}

echo "<p></p>";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
echo "<a class=\"button\" href=\"../\">Back</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";
echo "<p></p>";

// Connect to Database if login information is correct
if(isset($_SESSION['admin'])){
    try {
        require("admin_connect.php");
    } catch(PDOException $e) {
        echo "ERROR: Could not connect. " . $e->getMessage();
    }
}

try {
    $query = "SELECT * FROM".$tablename;
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
        echo "<td>{$row}</td>";
        echo "<td>{$row}</td>";
        echo "<td>{$row}</td>";
        echo "<td>{$row}</td>";
        echo "<td>{$row}</td>";
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
}
else
{
    echo "Please login to an admin account!";
    header("refresh:2;url=admin_login.php");
}
?>