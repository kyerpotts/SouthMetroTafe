<?php
//Checks wether admin account is logged into the database
session_start();
if(isset($_SESSION['admin']) || isset($_SESSION['user']))
{
// this line includes the HTML file header.php
include("../templates/header.php");

// Define variables and initialize with empty values
$email = $_POST['email'];

if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
    $email_err = true;
  } else {
    $email_err = false;
  }

if (!($email_err)) {
    try {
        require("admin_connect.php");
    } catch(PDOException $e) {
        echo "ERROR: Could not connect. " . $e->getMessage();
    }
    try {

        $query = "SELECT * FROM members_table WHERE email = '$email'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
        
        if($stmt->rowCount() > 0) {
            $query_two = "UPDATE members_table SET unsubscribe = 1 WHERE email = '$email'";
            $stmt_two = $conn->prepare($query_two);
            $stmt_two->execute();
            echo "You have been unsubscribed";
        } else {
            echo "That email address does not exists.";
        }

    } catch (PDOException $e) {
        echo "ERROR: Could not run query. " . $e->getMessage();
    }
    
    // close connection
    $conn = null;

} else {
    if ($email_err) {
        print_r("Incorrect Email format.");
    }
}

echo "<p></p>";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
echo "<a class=\"button\" href=\"../\">Back</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";

// this line includes the HTML file footer.php
include("../templates/footer.php"); 
}
else
{
    echo "Please login!";
    header("refresh:2;url=user_login.php");
}
?>