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
// Refreshes graph every 5 seconds
$url1=$_SERVER['REQUEST_URI'];
header("Refresh: 5; URL=$url1");
$url1=$_SERVER['REQUEST_URI'];
header("Refresh: 5; URL=$url1");
    
$data = array();

    // Connect to Database
    try {
        require("connect.php");
    } catch(PDOException $e) {
        echo "ERROR: Could not connect. " . $e->getMessage();
    }

    // Query to get the top ten searched
    try {
        $query = "SELECT * FROM movies_table ORDER BY searchedcount DESC LIMIT 10";
        $stmt = $conn->prepare($query);
        $stmt->execute();
        
        if($stmt->rowCount() > 0) {
            while($row = $stmt->fetchObject()) {
                $searched_count_id = $row->id;
                $searched_count_title = $row->title;
                $searched_count_searchedcount = $row->searchedcount;
                
                //echo "Title: " . $searched_count_title . " | ";
                //echo "SearchCount: " . $searched_count_searchedcount . "<br>";
                
                $data[$searched_count_id] = array($searched_count_searchedcount);
                //array_push($values, $searched_count_searchedcount);
            }
        }
    } catch(PDOException $e) {
        //echo "ERROR: Could not run query. " . $e->getMessage();
    }

    // GP Graph
    // code was taken and changed fromhttps://www.codingsavvy.com/2015/05/create-simple-bar-chart-using-php-gd.html

    // Define the Width and Height
    define('WIDTH', 400);
    define('HEIGHT', 250);

    // Create the image
    $img = imagecreatetruecolor(WIDTH, HEIGHT);

    // Set a white background with black text and gray graphics
    $bg_color = imagecolorallocate($img, 255, 255, 255);
    $text_color = imagecolorallocate($img, 0, 0, 0);

    imagefilledrectangle($img, 0, 0, WIDTH, HEIGHT, $bg_color);  
    
    imageline($img, (count($data)*50), HEIGHT - 28, 30, HEIGHT - 28, $text_color); // X
    imageline($img, 30, 18, 30, HEIGHT-30, $text_color); // Y
    
    // Draw a bar
    $r = 1;
    foreach ($data as $movie => $searched):
        $rectx1 = 35 * $r;
        $form = 1;
        $start = 0;
        $stop = 0;
        foreach ($searched as $search => $count):
            $exam_color = imagecolorallocate($img, 50, 91, 109);
            $strx = 36 * $r;
            $strpt = 0.9;
            $start = ($start==0)? HEIGHT - 30:$stop;
            $stop = ($stop==0)? HEIGHT - 30 -(($count)*2): $start-($count*2);
            imagefilledrectangle($img, $rectx1, $stop, $rectx1+20, $start, $exam_color);
            
            $start++;
        endforeach;
        imagestring($img, 0.4, 36 * $r, HEIGHT-25, $movie, $text_color);
        $r++;
    endforeach;

    // X and Y Labels
    imagestringup($img, 10, 3, 150, "Searches", $text_color);
    imagestring($img, 10, WIDTH/2 - 30, HEIGHT-15, "Moive ID", $text_color);

    for ($i = 0; $i < 11; $i++){
        imagestringup($img, 0.2, 20, 230 - ($i*20), $i * 10, $text_color);
    }

    header("Content-type: image/png");
    imagepng($img);
    imagedestroy($img);
}
else
{
    echo "Please login!";
    header("refresh:2;url=user_login.php");
}
?>