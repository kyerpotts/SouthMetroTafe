<?php
/*
	ID: 30003389
	Name: Kyer Potts
	Date: 30-07-2019
	Task: Activity Three
*/

$number = $_REQUEST['number'];
echo "Number: $number<p>";
$number_array = str_split($number);
print($number_array[0]."<br>");
print($number_array[1]."<br>");
print($number_array[2]."<br>");
print($number_array[3]."<br>");
print($number_array[4]."<br>");
$numberSum = ($number_array[0] + $number_array[1] + $number_array[2] + $number_array[3] + $number_array[4]);
print("Sum: " . $numberSum);
?>
