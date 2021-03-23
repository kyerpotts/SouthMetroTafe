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
 $connect = mysqli_connect("localhost", "root", "", "movies_db");  
 $query = "SELECT SUM(movie_like) as likes, SUM(movie_dislike) as dislikes FROM streaming_table";  
 $result = mysqli_query($connect, $query); 
// //SELECT SUM(movie_like), SUM(movie_dislike) FROM streaming_table 
}
else
{
    echo "Please login!";
    header("refresh:2;url=../user_login.php");
}
 ?>  
 <!DOCTYPE html>  
 <html>  
      <head>  
           <title>Pie Chart For A Tally Of All Liked And Disliked Movies!</title>  
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
                      title: 'Pie Chart For A Tally Of All Liked And Disliked Movies!',  
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