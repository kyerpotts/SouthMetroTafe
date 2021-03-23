<?php
	include "./templates/head.php"; 
	
	if(!isset($_POST['view']))
	{
	?>
		<h1>Customers</h1>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php	
		require('php/connect.php');

		$res = mysqli_query($conn, "SELECT * FROM customer");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Customer: ";
			
			echo "<select name='select_customer'>
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
			echo "<p>No Customers exist and cannot be displayed...</p>";
		}
		
		mysqli_close($conn);
		
		?>
			<input type="submit" name="view" value="View">
		</form>
		
		<?php
		
	}
	else
	{
		$custID = $_POST['select_customer'];
		if($custID == 0)
		{
			echo "<p>No Customer selected, go <a href='Customers.php'>back</a> and please try again.</p>";
		}
		else
		{
			require('php/connect.php');
		
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
		require('php/connect.php');

		$res = mysqli_query($conn, "SELECT * FROM invoice WHERE CustID = '$custID'");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Invoices on record: ";
			
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
			echo "<p>No Invoices exist for this Customer...</p>";
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