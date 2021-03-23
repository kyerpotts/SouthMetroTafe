
<?php
// this line includes the HTML file header.php
include("../templates/header.php");

 
// Define variables and initialize with empty values
//$username = $password = $confirm_password = $firstname = $surname = "";
//$username_err = $password_err = $confirm_password_err = "";
$firstname = $_POST['firstname'];
$email = $_POST['email'];

// ref https://www.w3schools.com/php/php_form_url_email.asp
if (!preg_match("/[a-zA-Z]+$/",$firstname)) {
  $firstname_err = true;
} else {
    $firstname_err = false;
}

if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
  $email_err = true;
} else {
    $email_err = false;
}

if (!($firstname_err) && !($email_err)) {
    try {
        require("connect.php");
    } catch(PDOException $e) {
        echo "ERROR: Could not connect. " . $e->getMessage();
    }

    try {
        
        // query to check if email address already exists
        $query = "SELECT id FROM users WHERE email = '$email'";
        
        // attempt to run query
        $stmt = $conn->prepare($query);
        $stmt->execute();
        
        if($stmt->rowCount() > 0){
            echo "This username is already taken.";
        } else {
            // Add member to database
            $query_two = "INSERT INTO members_table (email, firstname) VALUES ('$email', '$firstname')";
            //$conn->exec($query);
            $stmt_two = $conn->prepare($query_two);
            $stmt_two->execute();
            echo "Member has been added successfully.";
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
?>