<?php
/*
    23/09/2019
    Kyer Potts
    30003389
*/




$data = array();

try {
    require("connect.php");
} catch(PDOException $e) {
    echo "ERROR: Could not connect. " . $e->getMessage();
}

//top 10 searched query
try {
    $query = "SELECT * FROM movies_table ORDER BY searchedcount DESC LIMIT 10";
    $stmt = $conn->prepare($query);
    $stmt->execute();
    
    if($stmt->rowCount() > 0) {
        while($row = $stmt->fetchObject()) {
            $searchedcountid = $row->id;
            $searchedcountsearchcount = $row->searchedcount;
            //TODO may need to change to ID if data values do not work
            $data[$searchedcountid] = array($searchedcountsearchcount);
        }        
    }
} catch(PDOException $e) {
    echo "ERROR: Could not run query. " . $e->getMessage();
}

//Graph using PHP GD library
//Original code accessed and modified from https://www.codingsavvy.com/2015/05/create-simple-bar-chart-using-php-gd.html

define('WIDTH', 400);
define('HEIGHT', 250);

$img = imagecreatetruecolor(WIDTH, HEIGHT);

//Set background colour with dark blue background, white text and light blue graphics
$bg_color = imagecolorallocate($img, 14, 76, 87); //dark blue
$text_color = imagecolorallocate($img, 255, 255, 255); //white
$graphic_color = imagecolorallocate($img, 134, 206, 240); //light blue

//Fill a rectangle with the background color
imagefilledrectangle($img, 0, 0, WIDTH, HEIGHT, $bg_color);

//Calculate X and Y axis
imageline($img, (count($data)*50), HEIGHT-30, 30, HEIGHT-30, $text_color); //x axis
imageline($img, 30, 18, 30, HEIGHT-30, $text_color); //y axis

//Draw Bars
$r = 1;
foreach ($data as $movie => $searched):
    $rectx1 = 35 * $r;
    $form = 1;
    $start = 0;
    $stop = 0;
    foreach($searched as $search => $count):
        $strx = 36 * $r;
        $strpt = 0.9;
        $start = ($start==0)?HEIGHT-32:$stop;
        $stop = ($stop==0)?HEIGHT-32-(($count)*2): $start-($count*2);
        imagefilledrectangle($img, $rectx1, $stop, $rectx1+20, $start, $graphic_color);
        $start++;
    endforeach;
    imagestring($img, 0.4, 36 * $r, HEIGHT-25, $movie, $text_color);
    $r++;
endforeach;

imagestringup($img, 10, 3, 180, "# of Searches", $text_color);
imagestring($img, 10, WIDTH/2 - 25, HEIGHT-15, "Movie ID", $text_color);

for($i = 0; $i < 11; $i++) {
    imagestringup($img, 0.2, 20, 230 - ($i*20), $i*10, $text_color);
}

header("Content-type: image/png");
imagepng($img);
imagedestroy($img);
?>