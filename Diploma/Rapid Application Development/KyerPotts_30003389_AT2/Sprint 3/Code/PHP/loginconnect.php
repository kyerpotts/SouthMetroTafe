
<?php
$email=$_POST['email'];//username
$password=$_POST['password'];//password 
session_start();

$con=mysqli_connect("localhost","root","","movies_db");//mysqli("localhost","username of database","password of database","database name")
$result=mysqli_query($con,"SELECT * FROM `admin_table` WHERE `email`='$email' && `password`='$password'");
$count=mysqli_num_rows($result);
if($count==1)
{
    echo "Login successful!";
    $_SESSION['log']=1;
    header("refresh:2;url=../");

}
else
{
    echo "Incorrect username or password!";
    header("refresh:2;url=login.php");// it takes 2 sec to go index page
}


?>