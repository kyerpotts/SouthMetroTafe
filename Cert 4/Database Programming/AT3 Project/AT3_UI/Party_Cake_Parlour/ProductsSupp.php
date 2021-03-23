<?php
	include "./templates/head.php"; 

	if(!isset($_POST['submit']))
	{
		?>
		<h1>Products by Supplier</h1>
		<!-- the form action is this page -->
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php
		// get the connection script
		require('connect.php');
		
		$res = mysqli_query($conn, "SELECT * FROM supplier");
		// make sure that something was returned
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Choose Supplier: ";
			
			// Display the first option of the select box
			echo "<select name='select_supplier'>
						<option value = '0'> Please Select...</option>";
						
			// iterate through the result and display the name for each supplier
			while($row=mysqli_fetch_array($res))
			{
				// the ID remains "hidden" but we use this as the identifier 
				// only the name is displayed
				echo "<option value='" . $row['ID'] . "'>" . $row['Name'] . "</option>";
			}
			echo "</select>";
			
			// free the resources
			mysqli_free_result($res);
		}
		else
		{
			// if nothing was returned from the database 
			echo "<p>No Suppliers exist</p>";
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
		$suppID = $_POST['select_supplier'];
		// if value is zero then nothing was selected
		if($suppID == 0)
		{
			echo "<p>Nothing selected, please go <a href='ProductsSupp.php'>back</a> and try again.</p>";
		}
		else
		{
			//connect to the database
			require('connect.php');
			
			$supp = mysqli_query($conn, "SELECT Name from supplier WHERE ID = '$suppID'");
			$suppName = mysqli_fetch_row($supp);
			$result = mysqli_query($conn, "SELECT Description, CategoryID, CostPrice FROM product WHERE SuppID = '$suppID'");
			echo "<h2>Products by $suppName[0]</h2>";
			if(mysqli_num_rows($result) > 0)
			{
				
				echo "<table class ='centre'>";
				echo "	<tr>
							<th>Description</th>
							<th>Category</th>
							<th colspan=2>Cost Price</th>
						</tr>";
					
				while ($row = mysqli_fetch_row($result)) 
				{
					$catId = $row[1]; 
					$catRes = mysqli_query($conn,"SELECT Description from category WHERE ID = '$catId'");
					
					$costPrice = $row['2'];
					$markup = $costPrice * 0.5;
					$price = (round(($costPrice + $markup), 2));
					$cat =  mysqli_fetch_row($catRes);
					
						echo "<tr>
								<td>$row[0]</td>
								<td>$cat[0]</td>
								<td>$</td>
								<td class='right'>$price</td>
							</tr>
						<br>";
				}
				echo "</table>";
				mysqli_free_result($result);
				mysqli_close($conn);
			}
			else if(mysqli_num_rows($result) == 0)
			{
				echo "<p>No Products exist for this Supplier...</p>";
			}
		}

	}	
	include "templates/foot.php"; 
?>