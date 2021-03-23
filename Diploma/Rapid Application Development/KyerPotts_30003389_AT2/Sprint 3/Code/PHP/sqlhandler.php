<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/

session_start();
if(isset($_SESSION['admin']))
{
include("../templates/header.php");
include("../templates/footer.php"); 
//database
$dbadd = "";
$dbremove = "";

//table
$dbname1 = "";
$dbname2 = "";
$tableadd = "";
$tableremove = "";                
$dbname3 = "";
$tablename = "";
$columnname = "";
$rating = "";
//$columnsadd = "";

//insert records
$dbname4 = "";
$tablename2 = "";
$records1 = "";
$records2 = "";

//$dbname5 = "";
//$tablename3 = "";
//$records3 = "";
//$records4 = "";


if(isset($_POST['dbadd']))
{
    $dbadd = trim($_POST['dbadd']);
}

if(isset($_POST['dbremove']))
{
    $dbremove = trim($_POST['dbremove']);
}

if(isset($_POST['dbname1']) && isset($_POST['tableadd']))
{
    $dbname1 = trim($_POST['dbname1']);
    $tableadd = trim($_POST['tableadd']);
}
else if(isset($_POST['dbname2']) && isset($_POST['tableremove']))
{
    $dbname2 = trim($_POST['dbname2']);
    $tableremove = trim($_POST['tableremove']);
}
else if(isset($_POST['dbname3']) && isset($_POST['tablename']) && isset($_POST['columnname']) && isset($_POST['rating']))
{
    $dbname3 = trim($_POST['dbname3']);
    $tablename = trim($_POST['tablename']);
    $columnname = trim($_POST['columnname']);
    $rating = trim($_POST['rating']);
}
else if(isset($_POST['dbname4']) && isset($_POST['tablename2']))
{
    if(isset($_POST['records1']) && isset($_POST['records2']))
    {
    $dbname4 = trim($_POST['dbname4']);
    $tablename2 = trim($_POST['tablename2']);
    $records1 = trim($_POST['records1']);
    $records2 = trim($_POST['records2']);
    }
}


// Connect to Database
try {
    require("admin_connect.php");
} catch(PDOException $e) {
    echo "ERROR: Could not connect. " . $e->getMessage();
}

if(!("" == $dbadd)) {
  $query = "CREATE DATABASE $dbadd";
  $stmt = $conn->prepare($query);
  $stmt->execute();
  echo "Database has been created!";
}
else if(!("" == $dbremove))
{
  $query = "DROP DATABASE $dbremove";
  $stmt = $conn->prepare($query);
  $stmt->execute();
  echo "Database has been removed!";
}
else if(!(("" == $tableadd) && ("" == $dbname1)))
{
  $query = "USE $dbname1;
  CREATE TABLE $tableadd (
  id int auto_increment,
  primary key(id)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;";
  $stmt = $conn->prepare($query);
  $stmt->execute();
  echo "Table has been created!";
}
else if(!(("" == $tableremove) && ("" == $dbname2)))
{
  $query = "USE $dbname2;
  DROP TABLE $tableremove;";
  $stmt = $conn->prepare($query);
  $stmt->execute();
  echo "Table has been removed!";
}
else if (!(("" == $dbname3) && ("" == $tablename) && ("" == $columnname) && ("" == $rating)))
{
    $query = "USE $dbname3;
    ALTER TABLE $tablename
    ADD COLUMN $columnname $rating;";
    $stmt = $conn->prepare($query);
    $stmt->execute();
    echo "Column has been created!";
}
else if(!(("" == $dbname4) && ("" == $tablename2) && ("" == $records1) && ("" == $records2)))
{
    $query = "USE $dbname4;
    INSERT INTO $tablename2 $records1 
    VALUES $records2";
    echo "$query";
    $stmt = $conn->prepare($query);
    $stmt->execute();
    echo "Record has been created!";
}
} 
else
{
    echo "Please login!";
    header("refresh:2;url=user_login.php");
}



?>