<?php
	include "./templates/head.php"; 

	
	// Check if the submit button has been clicked, if not then display the form
	// with the combo box (select box)
	// the name of the button must match (i.e. submit)
	if(!isset($_POST['submit']))
	{
		?>
		<h1>Invoices</h1>
		<!-- the form action is this page -->
		<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post" class='centre'>
		<?php
		// get the connection script
		require('connect.php');
		
		$res = mysqli_query($conn, "SELECT * FROM invoice");
		// make sure that something was returned
		if(mysqli_num_rows($res) > 0 )
		{
			echo "Choose Invoice: ";
			
			// Display the first option of the select box
			echo "<select name='select_invoice'>
						<option value = '0'> Please Select...</option>";
						
			while($row=mysqli_fetch_array($res))
			{
				// the ID remains "hidden" but we use this as the identifier 
				// only the name is displayed
				echo "<option value='" . $row['InvoiceNo'] . "'>" . $row['InvoiceDate'] . "</option>";
			}
			echo "</select>";
			
			// free the resources
			mysqli_free_result($res);
		}
		else
		{
			// if nothing was returned from the database 
			echo "<p>There are no invoices to display</p>";
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
		// get the ID of the selected invoice from the submitted form
		$invID = $_POST['select_invoice'];
		// if value is zero then nothing was selected
		if($invID == 0)
		{
			echo "<p>Nothing selected, please go <a href='Invoices.php'>back</a> and try again.</p>";
		}
		else
		{
			//connect to the database
			require('connect.php');
			
			$result = mysqli_query($conn, "SELECT InvoiceNo, InvoiceDate, CustID, EmpID FROM invoice WHERE InvoiceNo = '$invID'");
			$inv = mysqli_fetch_row($sql);
			echo "<h2>View Invoice</h2>";
			if(mysqli_num_rows($result) > 0)
			{
				echo "<table>";

				
				while ($row = mysqli_fetch_row($result))
				{
					$invoiceID = $row[0];
					$cusId = $row[2];
					$cusRes = mysqli_query($conn,"SELECT FName, LName, Address, Suburb, State, Phone FROM customer WHERE ID = '$cusId'");
					$cus = mysqli_fetch_row($cusRes);
					
					echo "	<tr>
							<th>Customer</th>
							<th align='right'>Invoice Number</th>
						</tr>";
					echo "<tr>
							<td class='right'>$cus[0] $cus[1]</td>
							<td class='right'>$invID</td>
						</tr>";
					echo "<tr>
							<td></td>
							<td></td>
						</tr>";
						
					$invoiceID = $row[0];
					$empId = $row[3];
					$empRes = mysqli_query($conn,"SELECT ID, FName, LName FROM employee WHERE ID = '$empId'");
					$emp = mysqli_fetch_row($empRes);
					
					echo "	<tr>
							<th>Employee</th>
							<th align='right'>Employee ID</th>
						</tr>";
					echo "<tr>
							<td class='right'>$emp[1] $emp[2]</td>
							<td class='right'>$emp[0]</td>
						</tr>";
					echo "<tr>
							<td></td>
							<td></td>
						</tr>";
					
					$orderRes = mysqli_query($conn,"SELECT InvoiceNo, ProdID, Qty FROM invoice_line WHERE InvoiceNo = '$invoiceID'");
					$order = mysqli_fetch_row($orderRes);
					$itemRes = mysqli_query($conn,"SELECT Description, CostPrice FROM product WHERE ID = '$order[1]'");
					$itemName = mysqli_fetch_row($itemRes);
					
					echo "	<tr>
							<th>Item</th>
							<th align='right'>Quantity</th>
						</tr>";
					echo "<tr>
							<td class='right'>$itemName[0]</td>
							<td class='right'>$order[2]</td>
						</tr><br>";
					echo "<tr>
							<td></td>
							<td></td>
						</tr>";
					
					$costPrice = $itemName['1'];
					$markup = $costPrice * 0.5;
					$price = (round(($costPrice + $markup), 2));
					$unitcost = $itemName['1'] * $order[2];
					$total = $price * $order[2];
					$gst = $total - $unitcost;
					
					echo "<tr>
							<td class='right'><b>Cost</b></td>
							<td class='right'>$$unitcost</td>
						</tr><br>";
					echo "<tr>
							<td class='right'><b>GST</b></td>
							<td class='right'>$$gst</td>
						</tr><br>";
					echo "<tr>
							<td></td>
							<td></td>
						</tr>";
					echo "<tr>
							<td class='right'><b>Total</b></td>
							<td class='right'><b>$$total</b></td>
						</tr><br>";
				}
					echo "</table>";
				mysqli_free_result($result);
				mysqli_close($conn);
			}
		}
	}
	
	include "./templates/foot.php"; 
?>