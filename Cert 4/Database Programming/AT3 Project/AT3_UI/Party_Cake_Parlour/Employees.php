<?php
	include "./templates/head.php"; 

	
	// Check if the submit button has been clicked, if not then display the form
	// with the combo box (select box)
	// the name of the button must match (i.e. submit)
	if(!isset($_POST['submit']))
	{
		?>
		<h1>Employees</h1>
		<!-- the form action is this page -->
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php
		// get the connection script
		require('connect.php');
		
		// get all of the employee info
		$res = mysqli_query($conn, "SELECT * FROM employee");
		// make sure that something was returned
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Choose Employee: ";
			
			// Display the first option of the select box
			echo "<select name='select_employee'>
						<option value = '0'> Please Select...</option>";
						
			// iterate through the result and display the name for each Employee
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
			echo "<p>There are no employees to display</p>";
		}
		
		//close the connection
		mysqli_close($conn);
		
		?>
			
			<input type="submit" name="submit" value="Submit">
		</form>
		
		<?php
		
	}
	else
	{
		// get the ID of the selected supplier from the submitted form
		$empID = $_POST['select_employee'];
		// if value is zero then nothing was selected
		if($empID == 0)
		{
			echo "<p>Nothing selected, please go <a href='Employees.php'>back</a> and try again.</p>";
		}
		else
		{
			//connect to the database
			require('connect.php');
			
			// get the information for the selected supplier
			$emp = mysqli_query($conn, "SELECT FName, LName, Address, Suburb, Phone, Salary, TFN FROM employee WHERE ID = '$empID'");
			$empName = mysqli_fetch_row($emp);
			echo "<h2>$emp[0] $emp[1]</h2>";
			if(mysqli_num_rows($sql) > 0)
			{
				echo "<table class ='centre'>";
				echo "<tr>
						<th>Address</th>
						<th>Suburb</th>
						<th>Phone</th>
						<th>Salary</th>
						<th>TFN</th>
					</tr>";
				echo "<tr>
						<td>$emp[2]</td>
						<td>$emp[3]</td>
						<td>$emp[4]</td>
						<td>$$emp[5]</td>
						<td>$emp[6]</td>
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
		$res = mysqli_query($conn, "SELECT * FROM invoice WHERE EmpID = '$empID'");
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
			echo "<p>No Invoices created by $emp[0]</p>";
		}
		
		mysqli_close($conn);
		
		?>
		</form>
		<?php
		}
		echo '<p><a href="UpdateEmployee.php">Update</a></p>';
	}
	include "./templates/foot.php"; 
?>