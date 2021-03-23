<?php
	include "./templates/head.php";
	
	if(!isset($_POST['submit']))
	{
	?>
		<h1>Customers</h1>
		<!-- the form action is this page -->
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
	<?php	
	// get the connection script
		require('connect.php');

		$res = mysqli_query($conn, "SELECT * FROM customer");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Choose Customer: ";
			// Display the first option of the select box
			echo "<select name='select_customer'>
						<option value = '0'> Please Select...</option>";
			
			// iterate through the result and display the name for each customer
			while($row=mysqli_fetch_array($res))
			{
				// the ID remains "hidden" but we use this as the identifier 
				// only the name is displayed
				echo "<option value='" . $row['ID'] . "'>" . $row['FName'] . ' ' . $row['LName'] . "</option>";
			}
			echo "</select>";
			// free the resources
			mysqli_free_result($res);
		}
		else
		{
			// if nothing was returned from the database 
			echo "<p>There are no customers to display</p>";
		}
		
		mysqli_close($conn);
		?>
			<input type="submit" name="submit" value="Submit">
		</form>
		
		<?php
		
	}
	else
	{
		require('connect.php');
		//get the customer details
		$custID = $_POST['select_customer'];
		if($custID == 0)
		{
			echo "<p>No Customer selected, go <a href='Customers.php'>back</a> and please try again.</p>";
		}
		else
		{
			require('connect.php');
		
			$sql = mysqli_query($conn, "SELECT FName, LName, Address, Suburb, State, Phone FROM customer WHERE ID = '$custID'");
			$cust = mysqli_fetch_row($sql);
			echo "<h2>$cust[0] $cust[1]</h2>";
			if(mysqli_num_rows($sql) > 0)
			{
				echo "<table class ='centre'>";
				echo "	<tr>
							<th>Address</th>
							<th>Suburb</th>
							<th>State</th>
							<th>Phone</th>
						</tr>";
				echo "<tr>
						<td>$cust[2]</td>
						<td>$cust[3]</td>
						<td>$cust[4]</td>
						<td>$cust[5]</td>
					</tr>";
				echo "</table>";
				mysqli_free_result($result);
				mysqli_close($conn);
			}
		}
		if(!isset($_POST['view2']))
		{
		?>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php	
		require('connect.php');
		
		$res = mysqli_query($conn, "SELECT * FROM invoice WHERE CustID = '$custID'");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Invoices: ";
			
			echo "<select name='select_invoice'>
						<option value = '0'> ...</option>";
			
			while($row=mysqli_fetch_array($res))
			{
				echo "<option value='" . $row['InvoiceNo'] . "'>" . $row['InvoiceDate'] . "</option>";
			}
			echo "</select>";
			
			mysqli_free_result($res);
		}
		else
		{
			echo "<p>No Invoices Available</p>";
		}
		mysqli_close($conn);
		
		?>
		</form>
		<?php
		}
	}

	echo '<p><a href="AddCustomer.php">Add New Customer</a></p>';
	include "./templates/foot.php"; 
?>
