<?php
	include "./templates/head.php"; 

	if(!isset($_POST['view']))
	{
	?>
		<h1>Products (by Category)</h1>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php	
		require('php/connect.php');

		$res = mysqli_query($conn, "SELECT * FROM category");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Categories: ";
			
			echo "<select name='select_category'>
						<option value = '0'> Choose One...</option>";
			
			while($row=mysqli_fetch_array($res))
			{
				echo "<option value='" . $row['ID'] . "'>" . $row['Description'] . "</option>";
			}
			echo "</select>";
			
			mysqli_free_result($res);
		}
		else
		{
			echo "<p>No Products exist in that Category...</p>";
		}
		
		mysqli_close($conn);
		
		?>
			<input type="submit" name="view" value="View">
		</form>
		
		<?php
		
	}
		else
		{
			$catID = $_POST['select_category'];
			if($catID == 0)
			{
				echo "<p>No Category selected, go <a href='ProductsCat.php'>back</a> and please try again.</p>";
			}
			else
			{
				require('php/connect.php');
				
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
					echo "<p>No Products exist in this Category...</p>";
				}
			}
		}
		
		include "./templates/foot.php"; 
	?>