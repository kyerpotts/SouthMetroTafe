<?php
//Checks wether admin account is logged into the database
session_start();
if(isset($_SESSION['admin'])|| isset($_SESSION['user']))
{
// this line includes the HTML file header.php
include("../templates/header.php");

// Define variables and initialize with empty values
$monthly_newsletter = '0';
$breaking_newsflash = '0';
$fullname = $_POST['fullname'];
$email = $_POST['email'];

if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
  $email_err = true;
} else {
    $email_err = false;
}

if ($_POST['monthly_newsletter'] == '1') {
    $monthly_newsletter = '1';
}

if ($_POST['breaking_newsflash'] == '1') {
    $breaking_newsflash = '1';
}

if (!($email_err)) {
    try {
        require("connect.php");
    } catch(PDOException $e) {
        echo "ERROR: Could not connect. " . $e->getMessage();
    }

    try {
        // query to check if email address already exists
        $query = "SELECT id FROM members_table WHERE email = '$email'";
        
        // attempt to run query
        $stmt = $conn->prepare($query);
        $stmt->execute();
        
        if($stmt->rowCount() > 0){
            echo "That email is already in use.";
        } else {
            // Add member to database
            $query_two = "INSERT INTO members_table (email, fullname, monthly_newsletter, breaking_newsflash) VALUES ('$email', '$fullname', '$monthly_newsletter', '$breaking_newsflash')";
            //$conn->exec($query);
            $stmt_two = $conn->prepare($query_two);
            $stmt_two->execute();
            echo "Email has been subscribed.";
        }
    } catch (PDOException $e) {
        echo "ERROR: Could not run query. " . $e->getMessage();
    }
    
    // close connection
    $conn = null;
    
} else {
    if ($email_err) {
        print_r("Incorrect Email format.");
    } elseif ($firstname_err) {
        print_r("Incorrect Firstname format.");
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
