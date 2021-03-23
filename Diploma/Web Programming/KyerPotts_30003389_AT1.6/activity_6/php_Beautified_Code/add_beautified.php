
<style>
<?php include 'style.css'; ?>
</style>
<?php
// Connection info
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "names_emails";

// Form info

$firstnameErr = $surnameErr = $emailErr = "";
$firstname = $surname = $email = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (empty($_POST["firstname"])) {
        $firstnameErr = "First name is required";
    } else {
        $firstname = $_POST["firstname"];
        if (!preg_match("/^[a-zA-Z]*$/", $firstname)) {
            $firstnameErr = "Only letters and white space allowed";
        }
    }
    
    if (empty($_POST["surname"])) {
        $surnameErr = "Surname is required";
    } else{ 
        $surname = $_POST["surname"];
        if (!preg_match("/^[a-zA-Z]*$/", $surname)) {
            $surnameErr = "Only letters and white space allowed";
        }
    }
    
    if (empty ($_POST["email"])) {
        $emailErr = "Email is required";
    } else {
        $email = $_POST["email"];
        if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
            $emailErr = "Invalid email format";
        }
    }
}

if ($firstnameErr == "" && $surnameErr == "" && $emailErr == ""){
try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO:: ERRMODE_EXCEPTION);
    $sql = "INSERT INTO data (firstname, surname, email) VALUES ('$firstname', '$surname', '$email')";
    $conn->exec($sql);
    echo "New user added successfully";
    }
catch(PDOException $e)
    {
    echo $sql . ">br>" . $e->getMessage();
    }
    
$conn = null;
} else {
    if ($firstnameErr != ""){
    echo "$firstnameErr </br>";
    }
    
    if ($surnameErr != ""){
    echo "$surnameErr </br>";
    }
    
    if ($emailErr != ""){
    echo "$emailErr";
    }
}
?>
