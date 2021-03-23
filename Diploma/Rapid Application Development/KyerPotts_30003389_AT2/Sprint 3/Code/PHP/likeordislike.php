
<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/

//Checks wether admin account is logged into the database
session_start();
if(isset($_SESSION['admin']) || isset($_SESSION['user']))
{
include("../templates/header.php");

 $movietitle= "";
 if(isset($_POST['movietitle']))
 {
    $movietitle = trim($_POST['movietitle']);
 }
if(isset($_POST['likeordislike'])){
    $movieid = $_POST["movietitle"];
    $likeordislike = $_POST["likeordislike"];
    // Connect to Database
try {
    require("connect.php");
} catch(PDOException $e) {
    echo "ERROR: Could not connect. " . $e->getMessage();
}
if($likeordislike == 0)// like
{
    //SELECT movie_id from streaming_table
    $query1 = "SELECT movie_like FROM `streaming_table` WHERE movie_title = '$movieid'";
    $stmt = $conn->prepare($query1);
    $stmt->execute();
    
    //if record exists
    if($stmt->rowCount() > 0) {
        $row = $stmt->fetchObject();
        
        $movie_like_count = $row->movie_like;
        
        //UPDATE movie_like 
        $query2 = "UPDATE streaming_table SET movie_like = '$movie_like_count' + 1 WHERE movie_title = '$movieid'";
        $stmt = $conn->prepare($query2);
        $stmt->execute();
        echo "Successfully liked '$movietitle' movie!";
    }
    
    //else create new record
    else
    {
        //INSERT new stream_table record
        $query2 = "INSERT INTO `streaming_table` (`movie_title`, `movie_like`) VALUES ('$movieid', 1)";
        $stmt = $conn->prepare($query2);
        $stmt->execute();
        echo "Successfully liked '$movietitle' movie!";
    }
}
else if($likeordislike == 1)//dislike
{
    //SELECT movie_id from streaming_table
    $query1 = "SELECT movie_dislike FROM `streaming_table` WHERE movie_title = '$movieid'";
    $stmt = $conn->prepare($query1);
    $stmt->execute();
    
    //if record exists
    if($stmt->rowCount() > 0) {
        $row = $stmt->fetchObject();
        
        $movie_dislike_count = $row->movie_dislike;
        
        //UPDATE movie_like 
        $query2 = "UPDATE streaming_table SET movie_dislike = $movie_dislike_count + 1 WHERE movie_title = '$movieid'";
        $stmt = $conn->prepare($query2);
        $stmt->execute();
        echo "Successfully disliked '$movietitle' movie!";
    }
    
    //else create new record
    else
    {
        //INSERT new stream_table record
        $query2 = "INSERT INTO `streaming_table` (`movie_title`, `movie_dislike`) VALUES ('$movieid', 1)";
        $stmt = $conn->prepare($query2);
        $stmt->execute();
        echo "Successfully disliked '$movietitle' movie!";
    }
}

}
else
{
    echo 'Please select like or dislike!';
}

 $connect = mysqli_connect("localhost", "root", "", "movies_db");  
 //$query = "SELECT SUM(movie_like) as likes, SUM(movie_dislike) as dislikes FROM streaming_table"; 
 $query = "SELECT `movie_like` as likes ,`movie_dislike`as dislikes FROM streaming_table WHERE `movie_title` = '$movietitle'"; 
 $result = mysqli_query($connect, $query); 
echo "<p></p>";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
//echo "<a class=\"button\" href=\"piechart.php/\">Pie Chart</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";
echo "<p></p>";
echo "<a class=\"button\" href=\"../\">Back</a>";
include("../templates/footer.php"); 
}
else
{
    echo "Please login!";
    header("refresh:2;url=user_login.php");
}

?>
<!DOCTYPE html>  
 <html>  
      <head>  
           <title><?php echo $url; ?></title>  
           <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>  
           <script type="text/javascript">  
           google.charts.load('current', {'packages':['corechart']});  
           google.charts.setOnLoadCallback(drawChart);  
           function drawChart()  
           {  
                var data = google.visualization.arrayToDataTable([  
                          ['Gender', 'Number'],  
                          
                          <?php  
                          $row = mysqli_fetch_array($result) ;
                           
                          echo "['Likes', ".$row["likes"]."],";  
                          echo "['Dislikes', ".$row["dislikes"]."],";                            
                          
                                                            
                          ?>  
                          
                     ]);  
                var options = {  
                      title: "Pie Chart of the movie you have like/disliked!",  
                      //is3D:true,  
                      pieHole: 0.4  
                     };  
                var chart = new google.visualization.PieChart(document.getElementById('piechart'));  
                chart.draw(data, options);  
           }  
           </script>  
      </head>  
      <body>  
           <br /><br />  
           <div style="width:900px;">  
                <br />  
                <div id="piechart" style="width: 900px; height: 500px;"></div>  
           </div>  
      </body>  
 </html> 