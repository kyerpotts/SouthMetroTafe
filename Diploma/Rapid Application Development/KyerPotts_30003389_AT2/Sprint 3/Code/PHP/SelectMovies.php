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
// this line includes the HTML file header.php
include("../templates/header.php");

// Local Variables
$searched_count_id = 0;

// Get Variables
$title = trim($_POST['title']);
$genre = trim($_POST['genre']);
$rating = trim($_POST['rating']);
$year = trim($_POST['year']);

// check if the variables contain data
//echo "<div class=\"container\">";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
echo "<h1>Searching</h1>";
if(!("" == $title)) {
  echo "<p>Title: $title</p>";
} 

if(!("" == $genre)) {
  echo "<p>Genre: $genre</p>";
}

if(!("" == $rating)) {
  echo "<p>Rating: $rating</p>";
}

if(!("" == $year)) {
  echo "<p>Year: $year</p>";
    $year_data = true;
}

echo "<a class=\"button\" href=\"../\">Back</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";
echo "<br>";

// Connect to Database
try {
    require("connect.php");
} catch(PDOException $e) {
    echo "ERROR: Could not connect. " . $e->getMessage();
}

try {
    if(("" == $title) && ("" == $genre) && ("" == $rating) && ("" == $year)) {
        // if all are blank
        echo "<div class=\"row text-white\"> <!-- Start Row Two -->";
        echo "<div class=\"col-11 col-sm-6\">";
        echo "<p>No data entered, unable to find any records.</p>";
        echo "</div>";
        echo "</div> <!-- End Row Two -->";

        $query = "SELECT * FROM movies_table WHERE id = '-1'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($title == "") && !($genre == "") && !($rating == "") && !($year == "")) {
        // title genre rating year aren't blank
        $query = "SELECT * FROM movies_table WHERE title = '$title' AND genre = '$genre' AND rating = '$rating' AND year = '$year'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($title == "") && !($genre == "") && !($rating == "") && ($year == "")){
        // title genre rating aren't blank
        // year is blank
        $query = "SELECT * FROM movies_table WHERE title = '$title' AND genre = '$genre' AND rating = '$rating'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($title == "") && !($genre == "") && ($rating == "") && !($year == "")){
        // title genre year aren't blank
        // rating is blank
        $query = "SELECT * FROM movies_table WHERE title = '$title' AND genre = '$genre' AND year = '$year'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($title == "") && ($genre == "") && !($rating == "") && !($year == "")){
        // title rating year aren't blank
        // genre is blank
        $query = "SELECT * FROM movies_table WHERE title = '$title' AND rating = '$rating' AND year = '$year'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($title == "") && !($genre == "") && ($rating == "") && ($year == "")){
        // title genre aren't blank
        // rating year are blank
        $query = "SELECT * FROM movies_table WHERE title = '$title' AND genre = '$genre'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($title == "") && ($genre == "") && !($rating == "") && ($year == "")){
        // title rating aren't blank
        // genre year are blank
        $query = "SELECT * FROM movies_table WHERE title = '$title' AND rating = '$rating'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($title == "") && ($genre == "") && ($rating == "") && !($year == "")){
        // title year aren't blank
        // genre rating are blank
        $query = "SELECT * FROM movies_table WHERE title = '$title' AND year = '$year'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($title == "") && ($genre == "") && ($rating == "") && ($year == "")){
        // title isn't blank
        // genre rating year are blank
        $query = "SELECT * FROM movies_table WHERE title = '$title'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(($title == "") && !($genre == "") && !($rating == "") && !($year == "")){
        // genre rating year aren't blank
        // title is blank
        $query = "SELECT * FROM movies_table WHERE genre = '$genre' AND rating = '$rating' AND year = '$year'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(($title == "") && !($genre == "") && ($rating == "") && !($year == "")){
        // genre year aren't blank
        // title rating are blank
        $query = "SELECT * FROM movies_table WHERE genre = '$genre' AND year = '$year'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(($title == "") && !($genre == "") && !($rating == "") && ($year == "")){
        // genre rating aren't blank
        // title year are blank
        $query = "SELECT * FROM movies_table WHERE genre = '$genre' AND rating = '$rating'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(($title == "") && !($genre == "") && ($rating == "") && ($year == "")){
        // genre isn't blank
        // title rating year are blank
        $query = "SELECT * FROM movies_table WHERE genre = '$genre'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(($title == "") && ($genre == "") && !($rating == "") && !($year == "")){
        // rating year aren't blank
        // title genre are blank
        $query = "SELECT * FROM movies_table WHERE rating = '$rating' AND year = '$year'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(($title == "") && ($genre == "") && !($rating == "") && ($year == "")){
        // rating isn't blank
        // title genre year are blank
        $query = "SELECT * FROM movies_table WHERE rating = '$rating'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(($title == "") && ($genre == "") && ($rating == "") && !($year == "")){
        // year isn't blank
        // title genre rating are blank
        $query = "SELECT * FROM movies_table WHERE year = '$year'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    }

    if($stmt->rowCount() > 0) {
    echo "<div class=\"row\"> <!-- Start Row Three -->";
    echo "<div class=\"col-12 col-sm-6\">";
    echo "<table class=\"table text-white\">";
    echo "<thead>";
    echo "<tr>";
    echo "<th scope=\"col\"><strong>ID</strong></th>";
    echo "<th scope=\"col\"><strong>Title</strong></th>";
    echo "<th scope=\"col\"><strong>Studio</strong></th>";
    echo "<th scope=\"col\"><strong>Status</strong></th>";
    echo "<th scope=\"col\"><strong>Sound</strong></th>";
    echo "<th scope=\"col\"><strong>Versions</strong></th>";
    echo "<th scope=\"col\"><strong>RecRetPrice</strong></th>";
    echo "<th scope=\"col\"><strong>Rating</strong></th>";
    echo "<th scope=\"col\"><strong>Year</strong></th>";
    echo "<th scope=\"col\"><strong>Genre</strong></th>";
    echo "<th scope=\"col\"><strong>Aspect</strong></th>";
    echo "</tr>";
    echo "</thead>";

    $row = 0;
            while($row = $stmt->fetchObject()) {
                // Get the id
                $searched_count_id = $row->id;
                
                // Increase the SearchedCount
                $query_two = "UPDATE movies_table SET searchedcount = searchedcount + 1 WHERE id = '$searched_count_id'";
                $stmt_two = $conn->prepare($query_two);
                $stmt_two->execute();
                
                // Add found movie to table
                echo "<tbody>";
                echo "<tr>";
                echo "<th scope=\"row\">{$row->id}</td>";
                echo "<td>{$row->title}</td>";
                echo "<td>{$row->studio}</td>";
                echo "<td>{$row->status}</td>";
                echo "<td>{$row->sound}</td>";
                echo "<td>{$row->versions}</td>";
                echo "<td>{$row->recretprice}</td>";
                echo "<td>{$row->rating}</td>";
                echo "<td>{$row->year}</td>";
                echo "<td>{$row->genre}</td>";
                echo "<td>{$row->aspect}</td>";
                //echo '<td><input type="checkbox" value="$row" '.(0 == 123 ? 'checked="checked"':'').' /></td>';
                echo "</tr>";
        echo "</tbody>";
        $row++;
            }
    echo "</table>";
    echo "</div>";
    echo "</div> <!-- End Row Three -->";
    }
} catch(PDOException $e) {
    echo "ERROR: Could not run query. " . $e->getMessage();
}

// this line includes the HTML file footer.php
include("../templates/footer.php"); 
}
else
{
    echo "Please login!";
    header("refresh:2;url=user_login.php");
}
?>
