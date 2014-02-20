<?php
	require("connect.php");

	$url=$_GET[ProductID];

	$results=mysql_query("
		SELECT ProductID, QuantityPerUnit, FORMAT(UnitPrice, 2) AS UPrice
		FROM Products
		WHERE ProductID = '$url'
	");
	
	$results2=mysql_query("
		SELECT ProductName
		FROM Products
		WHERE ProductID = $url
	");
	
	while ($row=mysql_fetch_array($results2)) {
		print "<h2>$row[ProductName]</h2>";
	}
	
	print "<table border='1'>
		<tr>
			<th>Product ID</th>
			<th>Quantity Per Unit</th>
			<th>Unit Price</th>
		</tr>";
	
	while ($row=mysql_fetch_array($results)) {
		print "<tr>
			<td>$row[ProductID]</td>
			<td>$row[QuantityPerUnit]</td>
			<td>$$row[UPrice]</td>";
	}
		
	print "</table>";

?>