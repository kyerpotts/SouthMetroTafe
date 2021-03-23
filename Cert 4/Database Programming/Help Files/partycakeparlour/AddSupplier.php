<?php
	include "./templates/head.php"; 
	
	if(!isset($_POST['submit']))
	{
	?>
	<h1>Add New Supplier</h1>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
			<label for="supp">Supplier Name</label>	
			<input type="supp" name="supp" id="supp"/>
			<label for="phone">Phone Number</label>
			<input type="phone" name="phone" id="phone"/>
			<label for="address">Address</label>				
			<input type="address" name="address" id="address"/>
			<label for="suburb">Suburb</label>
			<input type="suburb" name="suburb"id="suburb"/>
			<label for="state">State</label>	
			<input type="state" name="state" id="state"/>
			<label for="postCode">Postcode</label>				
			<input type="postCode" name="postCode" id="postCode"/>
			<label for="submit">&nbsp;</label>
			<input type="submit" name="submit" value="Submit"/>
		</form>
		
	<?php
	
	}
	else
	{
		$supp = addslashes($_POST['supp']);
		$address = $_POST['address'];
		$suburb = $_POST['suburb'];
		$state = $_POST['state'];
		$postCode = $_POST['postCode'];
		$phone = $_POST['phone'];
		
		require("php/connect.php");
		$check = mysqli_query($conn, "SELECT ID FROM supplier WHERE Name = '$supp'");
		if(mysqli_num_rows($check) > 0)
		{
			echo "<p>$supp already exists in the database.</br >
			         Go <a href='AddSupplier.php'>back</a> and please try again.</p>";
		}
		else
		{
			$qry = "INSERT INTO supplier 
					(Name, Phone, Address, Suburb, State, PostCode)
					VALUES
					('$supp','$phone','$address','$suburb','$state','$postCode')"; 
			
			if(mysqli_query($conn, $qry))
			{
				$supp = stripslashes($supp);
				echo "<h2>'$supp' inserted successfully into Database!</h2>
					  <p><a href='Suppliers.php'>Return to Suppliers.</a></p>";
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