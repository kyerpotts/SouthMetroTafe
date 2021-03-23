<?php
	include "./templates/head.php"; 

	if(!isset($_POST['view']))
	{
	?>
		<h1>Products (by Suppliers)</h1>
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
		
	}
	else
	{
		$suppID = $_POST['select_supplier'];
		if($suppID == 0)
		{
			echo "<p>No Supplier selected, go <a href='SuppliersSupp.php'>back</a> and please try again.</p>";
		}
		else
		{
			require('php/connect.php');
			
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