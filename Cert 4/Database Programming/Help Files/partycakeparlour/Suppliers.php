<?php
	include "./templates/head.php"; 

	if(!isset($_POST['view']))
	{
	?>
		<h1>Suppliers</h1>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php
		require('php/connect.php');

		$res = mysqli_query($conn, "SELECT * FROM supplier");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Supplier: ";
			
			echo "<select name='select_supplier'>
						<option value = '0'> Choose One...</option>";
						
			while($row=mysqli_fetch_array($res))
			{
				echo "<option value='" . $row['ID'] . "'>" . $row['Name'] . "</option>";
			}
			echo "</select>";
			
			mysqli_free_result($res);
			

		}
		else
		{
			echo "<p>No Suppliers exist and cannot be displayed...</p>";
		}
		
		mysqli_close($conn);
		
		?>
			<input type="submit" name="view" value="View">

		</form>

		<?php
		
		echo '<p><a href="AddSupplier.php">Add New Supplier</a></p>';
	}
	else
	{
		$suppID = $_POST['select_supplier'];
		if($suppID == 0)
		{
			echo "<p>No Supplier selected, go <a href='Suppliers.php'>back</a> and please try again.</p>";
		}
		else
		{
			require('php/connect.php');

			$sql = mysqli_query($conn, "SELECT Name, Phone, Address, Suburb, State, Postcode FROM supplier WHERE ID = '$suppID'");
			$supp = mysqli_fetch_row($sql);
			echo "<h2>$supp[0]</h2>";
			if(mysqli_num_rows($sql) > 0)
			{
				echo "<table class ='centre'>";
				echo "	<tr>
							<th>Address</th>
							<th>Suburb</th>
							<th>State</th>
							<th>Postcode</th>
							<th>Phone</th>
						</tr>";
				echo "<tr>
						<td>$supp[2]</td>
						<td>$supp[3]</td>
						<td>$supp[4]</td>
						<td>$supp[5]</td>
						<td>$supp[1]</td>
					</tr>";
				echo "</table>";
				mysqli_free_result($result);
				mysqli_close($conn);
			}
		}
	}	
	include "templates/foot.php"; 
?>