<?php
	include "./templates/head.php"; 

	if(!isset($_POST['submit']))
	{
		?>
		<h1>Products by Category</h1>
		<!-- the form action is this page -->
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php
		// get the connection script
		require('connect.php');
		
		$res = mysqli_query($conn, "SELECT * FROM category");
		// make sure that something was returned
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Choose Category: ";
			
			// Display the first option of the select box
			echo "<select name='select_category'>
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
			echo "<p>There are no products in that category to display</p>";
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
		$catID = $_POST['select_category'];
		// if value is zero then nothing was selected
		if($catID == 0)
		{
			echo "<p>Nothing selected, please go <a href='ProductsCat.php'>back</a> and try again.</p>";
		}
		else
		{
			//connect to the database
			require('connect.php');
			
			$cat = mysqli_query($conn, "SELECT Description from category WHERE ID = '$catID'");
			$catName = mysqli_fetch_row($cat);
			$result = mysqli_query($conn, "SELECT Description, CategoryID, CostPrice, SuppID FROM product WHERE CategoryID = '$catID'");
			$prod = mysqli_fetch_row($sql);
			echo "<h2>$catName[0]s</h2>";
			if(mysqli_num_rows($result) > 0)
				{
					
					echo "<table class ='centre'>";
					echo "	<tr>
								<th>Description</th>
								<th>Supplier</th>
								<th colspan=2>Cost Price</th>
							</tr>";
						
					while ($row = mysqli_fetch_row($result)) 
					{
						$cat =  mysqli_fetch_row($catRes);
						
						$costPrice = $row['2'];
						$markup = $costPrice * 0.5;
						$price = (round(($costPrice + $markup), 2));
						$supID = $row[3];
						$supRes = mysqli_query($conn, "SELECT Name from supplier WHERE ID = '$supID'");
						$suppName = mysqli_fetch_row($supRes);
						
							echo "<tr>
									<td>$row[0]</td>
									<td>$suppName[0]</td>
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
					echo "<p>No Products for this Category</p>";
				}
			}
		}
		
		include "./templates/foot.php"; 
	?>