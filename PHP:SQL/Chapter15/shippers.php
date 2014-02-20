<?php
	require("connect.php");

	$results=mysql_query("
		SELECT ShipperID, CompanyName, Phone 
		FROM Shippers
	");
	
	//Number of Records in Query
	$num_records=mysql_num_rows($results);
	print "There are $num_records in the Shippers table.<br><br>";
	
	print "<table border='1'>
		<tr>
			<th>Shipper ID</th>
			<th>Company Name</th>
			<th>Phone</th>
		</tr>";
	
	while ($row=mysql_fetch_array($results)) {
		/*print_r($row);
		print "<br><br>";*/
		
		print "<tr>
			<td>$row[ShipperID]</td>
			<td>$row[CompanyName]</td>
			<td>$row[Phone]</td>
		</tr>";
	}
	
	print "</table>";

?>