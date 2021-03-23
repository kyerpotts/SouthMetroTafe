<?php
	include "./templates/head.php"; 
	
	if(!isset($_POST['view']))
	{
	?>
		<h1>Products</h1>
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php	
		require('php/connect.php');

		$res = mysqli_query($conn, "SELECT * FROM product");
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Product: ";
			
			echo "<select name='select_product'>
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
			echo "<p>No Products exist and cannot be displayed...</p>";
		}
		
		mysqli_close($conn);
		
		?>
			<input type="submit" name="view" value="View">
		</form>
		
		<?php
		echo '<p><a href="ProductsCat.php">Products by Category</a></p>';
		echo '<p><a href="ProductsSupp.php">Products by Supplier</a></p>';
		
	}
	else
	{
		$prodID = $_POST['select_product'];
		if($prodID == 0)
		{
			echo "<p>No Product selected, go <a href='Products.php'>back</a> and please try again.</p>";
		}
		else
		{
			require('php/connect.php');
			
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