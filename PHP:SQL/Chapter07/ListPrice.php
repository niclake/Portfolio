<html>
<title>List Price - Sarah Schuldt</title>
<body>

<?php	
	$listprice=200000;
	$expectedprice=175000;
	$reduction=0.03;
	$month=1;
	
	print "<table border = '1'>
		<tr>
			<th>Month</th>
			<th>Price</th>
		</tr>";
	
	while ($listprice > $expectedprice) {
		print "<tr>
			<td>$month</td>
			<td>\$" . number_format($listprice, 2) ."</td>
		</tr>";
		
		$month = $month + 1;
		$listprice = $listprice * (1 - $reduction);
	}
	
	print "<tr>
		<td>$month - SOLD</td>
		<td>\$" . number_format($listprice, 2) . "</td>
	</tr>";
	
	print "</table>";

?>
</body>
</html>
