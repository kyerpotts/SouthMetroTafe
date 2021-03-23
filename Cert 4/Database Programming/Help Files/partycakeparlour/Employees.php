<?php
	include "./templates/head.php"; 
	
	if(!isset($_POST['view']))
	{
	?>
		<h1>Employees</h1>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php	
		require('php/connect.php');

		$res = mysqli_query($conn, "SELECT * FROM employee");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Employee: ";
			
			echo "<select name='select_employee'>
						<option value = '0'> Choose One...</option>";
			
			while($row=mysqli_fetch_array($res))
			{
				echo "<option value='" . $row['ID'] . "'>" . $row['FName'] . ' ' . $row['LName'] . "</option>";
			}
			echo "</select>";
			
			mysqli_free_result($res);
		}
		else
		{
			echo "<p>No Employees exist and cannot be displayed...</p>";
		}
		
		mysqli_close($conn);
		
		?>
			<input type="submit" name="view" value="View">
		</form>
		
		<?php
		
	}
	else
	{
		$empID = $_POST['select_employee'];
		if($empID == 0)
		{
			echo "<p>No Employee was selected.</p>";
		}
		else
		{
			require('php/connect.php');
		
			$sql = mysqli_query($conn, "SELECT FName, LName, Address, Suburb, Phone, Salary, TFN FROM employee WHERE ID = '$empID'");
			$emp = mysqli_fetch_row($sql);
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
		require('php/connect.php');

		$res = mysqli_query($conn, "SELECT * FROM invoice WHERE EmpID = '$empID'");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Invoices created by $emp[0]: ";
			
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
			echo "<p>No Invoices from $emp[0]...</p>";
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