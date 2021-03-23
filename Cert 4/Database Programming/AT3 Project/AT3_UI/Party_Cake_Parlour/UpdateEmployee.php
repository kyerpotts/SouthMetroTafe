<?php
	// get the head of the html page
	include "templates/head.php"; 
	
	if(!isset($_POST['submit']))
	{
	?>
	<h1>Update Employee Info</h1>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
			
			<label for="empf">First Name</label>	
			<input type="empf" name="empf" id="empf"/>
			<label for="empl">Last Name</label>
			<input type="empl" name="empl" id="empl"/>
			<label for="address">Address</label>				
			<input type="address" name="address" id="address"/>
			<label for="suburb">Suburb</label>
			<input type="suburb" name="suburb" id="suburb"/>
			<label for="startdate">Start Date</label>
			<input type="startdate" name="startdate" id="startdate"/>
			<label for="salary">Salary</label>
			<input type="salary" name="salary" id="salary"/>
			<label for="tfn">TFN</label>				
			<input type="tfn" name="tfn" id="tfn"/>
			<label for="submit">&nbsp;</label>
			<input type="submit" name="submit" value="Submit"/>
		</form>
		
	<?php
	
	
	}
	else
	{
		$empf = addslashes($_POST['empf']);
		$empl = addslashes($_POST['empl']);
		$address = $_POST['address'];
		$suburb = $_POST['suburb'];
		$startdate = $_POST['startdate'];
		$salary = $_POST['salary'];
		$tfn = $_POST['tfn'];
		
		//get connection script
		require("connect.php");
		
		$check = mysqli_query($conn, "SELECT ID FROM employee WHERE FName = '$empf'");
		
		if(mysqli_num_rows($check) > 0)
		{
			$qry = "UPDATE employee 
					SET (FName = '$empf',LName = '$empl',Address = '$address',Suburb = '$suburb',Salary = '$salary',StartDate = '$startdate',TFN = '$tfn')
					WHERE employee ID = '$check'";
			if(mysqli_query($conn, $qry))
			{
				$empf = stripslashes($empf);
				$empl = stripslashes($empl);
				echo "<h2>'$empf' updated successfully!</h2>
					  <p><a href='Employees.php'>Return to Employees.</a></p>";
				
			}
			else
			{
				echo "ERROR: Could not execute $sql. " . mysqli_error($conn);
			}					
				}
		else
		{
			echo "<p>That employee does not exist in the database.</br >
			         Go <a href='UpdateEmployee.php'>back</a> and please try again.</p>";
		}
		mysqli_free_result($check);
		mysqli_close($conn);
	}

	include "./templates/foot.php"; 
?>