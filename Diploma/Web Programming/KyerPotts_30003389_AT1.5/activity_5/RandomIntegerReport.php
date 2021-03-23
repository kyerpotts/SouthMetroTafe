<?php
	/*
		ID: 30003389
		Name: Kyer Potts
		Date: 06-08-2019
		Task: Activity Five
	*/
	
	// Code snippets were taken from https://phpro.org/examples/Generate-Bar-Graph-with-PHP-and-GD.html and edited for the purpose of this assignment
	
	// Create array to hold random number values
	$gen_nums = array();
	
	// Loop to create 100 random number values and push values into $gen_nums array
	for($i = 0; $i < 100; $i++){
		$randNum = rand(1, 10);
		array_push($gen_nums, $randNum);
	}
	// Count the iterations of each individial numerical value (1-10)
	$counted_values = array_count_values($gen_nums);
	// Create max_values array to store the largest number of iterations per value to be used later to create the graph height
	$max_values = array();
	// Loop through each item within $counted_values to determine the height of each column
	foreach ($counted_values as $key => $gen_num){
		array_push($max_values, $gen_num);
	}
	
	// Determine the number of columns in the graph
	$columns = 10;
	
	// Assign values to generate the size of the graph
	$width = 300;
	$height = 200;
	$padding = 5;
	
	// Determine the width of each individual column
	$column_width = $width / $columns;
	
	
	// Create the image that the graph is printed on 
	$im        = imagecreate($width, $height); 
	$gray      = imagecolorallocate ($im, 0xcc, 0xcc, 0xcc); 
	$gray_lite = imagecolorallocate ($im, 0xee, 0xee, 0xee); 
	$gray_dark = imagecolorallocate ($im, 0x7f, 0x7f, 0x7f); 
	$white     = imagecolorallocate ($im, 0xff, 0xff, 0xff);
	
	// Create the background that the image is layered on
	imagefilledrectangle($im, 0, 0, $width, $height, $white);
	
	// Find the highest value of all of the key numbers to determine the maximum column height
	$max_value = max($max_values);
	
	// Loop to create the individual graph bars based upon the $max_values array
	for($i = 0; $i < $columns; $i++)
	{
		// Assigns the data to variables that determine the size of each bar
		$column_height = ($height / 100) * (( $max_values[$i] / $max_value) *100);
		$x1 = $i * $column_width;
		$y1 = $height - $column_height;
		$x2 = (($i + 1) * $column_width) - $padding;
		$y2 = $height;
		
		// prints the data to $im
		imagefilledrectangle($im, $x1, $y1, $x2, $y2, $gray);
		
		imageline($im, $x1, $y1, $x1, $y2, $gray_lite);
		imageline($im, $x1, $y2, $x2, $y2, $gray_lite);
		imageline($im, $x2, $y1, $x2, $y2, $gray_dark);
	}
	// Set the header
	header ("Content-type: image/png");
	
	// Display the image on browser
	imagepng($im);
?>