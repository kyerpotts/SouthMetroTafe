<?php
/*
	23/09/2019
	Kyer Potts
	30003389
*/

//includes header file
include "../templates/header.php";
//Counter variable for most searched functionality
$searchcountid = 0;

//Retrieve and store $_Post Data
$title = trim($_POST['title']);
$genre = trim($_POST['genre']);
$rating = trim($_POST['rating']);
$year = trim($_POST['year']);

//Determine if values are empty, echo end user search parameters
echo "<h1>Searching For</h1>";

if (!($title == "")){
	echo "<p>$title</p>";
	$title_data = true;
} else{
	$title_data = false;
}

if (!($genre == "")){
	echo "<p>$genre</p>";
	$genre_data = true;
} else{
	$genre_data = false;
}

if (!($rating == "")){
	echo "<p>$rating</p>";
	$rating_data = true;	
}else{
	$rating_data = false;
}

if (!($year == "")){
	echo "<p>$year</p>";
	$year_data = true;
} else{
	$year_data = false;
}

//Connect to database
try {
	require("connect.php");
} catch(PDOException $e) {
	echo "ERROR: Could not connect. " . $e->getMessage();
}

try {
	//echo friendly error message if all fields are left blank
	if(!($title_data) && !($genre_data) && !($rating_data) && !($year_data)){
		echo "<p>Unable to display records, please change or refine your search</p>";
		$query = "SELECT * FROM movies_table WHERE id = '-1'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif($title_data && $genre_data && $rating_data && $year_data){
		//run query with all search parameters filled
		$query = "SELECT * FROM movies_table WHERE title LIKE '%$title%' AND genre LIKE '%$genre%' AND rating = '$rating' AND year = '$year'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif($title_data && !($genre_data) && !($rating_data) && !($year_data)){
		//run query with only title data filled
		$query = "SELECT * FROM movies_table WHERE title LIKE '%$title%'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif($title_data && $genre_data && !($rating_data) && !($year_data)){
		//run query with only title and genre data filled
		$query = "SELECT * FROM movies_table WHERE title LIKE '%$title%' AND genre LIKE '%$genre%'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif($title_data && !($genre_data) && $rating_data && !($year_data)){
		//run query with only title and rating data filled
		$query = "SELECT * FROM movies_table WHERE title LIKE '%$title%' AND rating = '$rating'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif($title_data && !($genre_data) && !($rating_data) && $year_data){
		//run query with only title and year data filled
		$query = "SELECT * FROM movies_table WHERE title LIKE '%$title%' AND year = '$year'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif(!($title_data) && $genre_data && !($rating_data) && !($year_data)){
		//run query with only genre data filled
		$query = "SELECT * FROM movies_table WHERE genre LIKE '%$genre%'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif(!($title_data) && $genre_data && $rating_data && !($year_data)){
		//run query with only genre and rating data filled
		$query = "SELECT * FROM movies_table WHERE genre LIKE '%$genre%' AND rating = '$rating'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif(!($title_data) && $genre_data && !($rating_data) && $year_data){
		//run query with only genre and year data filled
		$query = "SELECT * FROM movies_table WHERE genre LIKE '%$genre%' AND year = '$year'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif(!($title_data) && !($genre_data) && $rating_data && !($year_data)){
		//run query with only rating data filled
		$query = "SELECT * FROM movies_table WHERE rating = '$rating'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif(!($title_data) && !($genre_data) && $rating_data && $year_data){
		//run query with only rating and year data filled
		$query = "SELECT * FROM movies_table WHERE rating = '$rating' AND year = '$year'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif(!($title_data) && !($genre_data) && !($rating_data) && $year_data){
		//run query with only year data filled
		$query = "SELECT * FROM movies_table WHERE year = '$year'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif ($title_data && $genre_data && $rating_data && !($year_data)){
		//run query with only title, genre and rating data filled
		$query = "SELECT * FROM movies_table WHERE title LIKE '%$title%' AND genre LIKE '%$genre%' AND rating = '$rating'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif ($title_data && $genre_data && !($rating_data) && $year_data){
		//run query with only title, genre and year data filled
		$query = "SELECT * FROM movies_table WHERE title LIKE '%$title%' AND genre LIKE '%$genre%' AND year = '$year'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif ($title_data && !($genre_data) && $rating_data && $year_data){
		//run query with only title, rating and year data filled
		$query = "SELECT * FROM movies_table WHERE title LIKE '%$title%' AND rating = '$rating' AND year = '$year'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	} elseif (!($title_data) && $genre_data && $rating_data && $year_data){
		//run query with only genre, rating and year data filled
		$query = "SELECT * FROM movies_table WHERE genre LIKE '%$genre%' AND rating = '$rating' AND year = '$year'";
		$stmt = $conn->prepare($query);
		$stmt->execute();
	}
	
	if($stmt->rowCount() > 0) {
			echo "<table>";
				echo "<tr>";
					echo "<th><strong>ID</strong></th>";
					echo "<th><strong>Title</strong></th>";
					echo "<th><strong>Studio</strong></th>";
					echo "<th><strong>Status</strong></th>";
					echo "<th><strong>Sound</strong></th>";
					echo "<th><strong>Versions</strong></th>";
					echo "<th><strong>RecRetPrice</strong></th>";
					echo "<th><strong>Rating</strong></th>";
					echo "<th><strong>Year</strong></th>";
					echo "<th><strong>Genre</strong></th>";
					echo "<th><strong>Aspect</strong></th>";
				echo "</tr>";
			while($row = $stmt->fetchObject()) {
				//Retrieve the movie ID for searchcount function
				$searchcountid = $row->id;
				
				//Increase the searchcount
				$query_two = "UPDATE movies_table SET searchedcount = searchedcount + 1 WHERE id = '$searchcountid'";
				$stmt_two = $conn->prepare($query_two);
				$stmt_two->execute();
				
				// Add found movie to table
				echo "<tr>";
					echo "<td>{$row->id}</td>";
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
				echo "</tr>";
			}
			echo "</table>";
	} elseif($stmt->rowCount() < 1 && ($title_data || $genre_data || $rating_data || $year_data)){
		echo "<p>No results found for search parameters, please try again</p>";
	}
	

} catch(PDOException $e) {
	echo "ERROR: Could not run query. " . $e->getMessage();
}
?>
	<a class="button" href="../">Back</a>
<?php
//Includes footer
include "../templates/footer.php";
?>