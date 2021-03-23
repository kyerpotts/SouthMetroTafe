<?php
	include "./templates/head.php"; 
	
	if(!isset($_POST['submit']))
	{
	?>
	<h1>Add New Customer</h1>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
			<label for="custf">First Name</label>	
			<input type="custf" name="custf" id="custf"/>
			<label for="custl">Last Name</label>
			<input type="custl" name="custl" id="custl"/>
			<label for="address">Address</label>				
			<input type="address" name="address" id="address"/>
			<label for="suburb">Suburb</label>
			<input type="suburb" name="suburb"id="suburb"/>
			<label for="state">State</label>	
			<input type="state" name="state" id="state"/>
			<label for="phone">Phone No.</label>				
			<input type="phone" name="phone" id="phone"/>
			<label for="desc">Description</label>				
			<input type="desc" name="desc" id="desc"/>
			<label for="submit">&nbsp;</label>
			<input type="submit" name="submit" value="Submit"/>
		</form>
		
	<?php
	
	}
	else
	{
		$custf = addslashes($_POST['custf']);
		$custl = addslashes($_POST['custl']);
		$address = $_POST['address'];
		$suburb = $_POST['suburb'];
		$state = $_POST['state'];
		$phone = $_POST['phone'];
		$desc = $_POST['desc'];
		
		require("php/connect.php");
		$check = mysqli_query($conn, "SELECT ID FROM customer WHERE Name = '$custf'");
		if(mysqli_num_rows($check) > 0)
		{
			echo "<p>$custf already exists in the database.</br >
			         Go <a href='AddCustomer.php'>back</a> and please try again.</p>";
		}
		else
		{
			$qry = "INSERT INTO customer 
					(FName, LName, Address, Suburb, State, Phone, Descr)
					VALUES
					('$custf','$custl', '$address', '$suburb', '$state', '$phone', '$desc' )"; 
			
			if(mysqli_query($conn, $qry))
			{
				$custf = stripslashes($custf);
				$custl = stripslashes($custl);
				echo "<h2>'$custf' inserted successfully into Database!</h2>
					  <p><a href='Customers.php'>Return to Customers.</a></p>";
				
			}
			else
			{
				echo "ERROR: Could not execute $sql. " . mysqli_error($conn);
			}
		}
		mysqli_free_result($check);
		mysqli_close($conn);
			
	}

	include "./templates/foot.php"; 
?>