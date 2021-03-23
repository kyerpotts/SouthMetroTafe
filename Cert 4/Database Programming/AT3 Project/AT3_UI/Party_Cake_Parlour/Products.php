<?php
	include "./templates/head.php"; 

	if(!isset($_POST['submit']))
	{
		?>
		<h1>Products</h1>
		<!-- the form action is this page -->
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php
		// get the connection script
		require('connect.php');
		
		$res = mysqli_query($conn, "SELECT * FROM product");
		// make sure that something was returned
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Choose Product: ";
			
			// Display the first option of the select box
			echo "<select name='select_product'>
						<option value = '0'> Please Select...</option>";
						
			// iterate through the result and display the name for each supplier
			while($row=mysqli_fetch_array($res))
			{
				// the ID remains "hidden" but we use this as the identifier 
				// only the name is displayed
				echo "<option value='" . $row['ID'] . "'>" . $row['Description'] . "</option>";
			}
			echo "</select>";
			
			// free the resources
			mysqli_free_result($res);
		}
		else
		{
			// if nothing was returned from the database 
			echo "<p>There are no products to display</p>";
		}
		
		//close the connection
		mysqli_close($conn);
		
		?>
			
			<input type="submit" name="submit" value="Submit">
		</form>
		
		<?php
		echo '<p><a href="ProductsCat.php">Products by Category</a></p>';
		echo '<p><a href="ProductsSupp.php">Products by Supplier</a></p>';
		
	}
	else
	{
		// get the ID of the selected supplier from the submitted form
		$prodID = $_POST['select_product'];
		// if value is zero then nothing was selected
		if($prodID == 0)
		{
			echo "<p>Nothing selected, please go <a href='Products.php'>back</a> and try again.</p>";
		}
		else
		{
			//connect to the database
			require('connect.php');
			
			$result = mysqli_query($conn, "SELECT Description, CategoryID, CostPrice, SuppID FROM product WHERE ID = '$prodID'");
			$prod = mysqli_fetch_row($sql);
			echo "<h2>Products</h2>";
			if(mysqli_num_rows($result) > 0)
			{
				echo "<table class ='centre'>";
				echo "	<tr>
							<th>Description</th>
							<th>Category</th>
							<th>Cost Price</th>
						</tr>";
					
				while ($row = mysqli_fetch_row($result)) 
				{
					$catId = $row[1]; 
					$catRes = mysqli_query($conn,"SELECT Description from category WHERE ID = '$catId'");
					
					$costPrice = $row['2'];
					$markup = $costPrice * 0.5;
					$price = (round(($costPrice + $markup), 2));
					$cat =  mysqli_fetch_row($catRes);
					
					$supID = $row[3];
					$supRes = mysqli_query($conn, "SELECT Name from supplier WHERE ID = '$supID'");
					$suppName = mysqli_fetch_row($supRes);
					
						echo "<tr>
								<td>$row[0]</td>
								<td>$cat[0]</td>
								<td>$$price</td>
							</tr><br>
							<tr>
								<td><b>Supplier:</b></td>
								<td>$suppName[0]</td>
							</tr>
						<br>";
						
				}
				echo "</table>";
				mysqli_free_result($result);
				mysqli_close($conn);
			}
		}
	}
	
	include "./templates/foot.php"; 
?>