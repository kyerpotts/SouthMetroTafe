
<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/
$email=$_POST['email'];//username
$password=$_POST['password'];//password 
session_start();

$con=mysqli_connect("localhost","root","","movies_db");//mysqli("localhost","username of database","password of database","database name")
$result=mysqli_query($con,"SELECT * FROM `admin_table` WHERE `email`='$email' && `password`='$password'");
$count=mysqli_num_rows($result);
if($count==1)
{
    echo "Login successful!";
    $_SESSION['admin']=1;
    header("refresh:2;url=../");

}
else
{
    echo "Incorrect username or password!";
    header("refresh:2;url=admin_login.php");// it takes 2 sec to go index page
}
?>