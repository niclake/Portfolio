<?php
	require("connect.php");

	$results=mysql_query("
		SELECT CategoryName, Description, CategoryID
		FROM Categories
	");
	
	print "<table border='1'>
		<tr>
			<th>Category Name</th>
			<th>Description</th>
		</tr>";
	
	while ($row=mysql_fetch_array($results)) {
		print "<tr>
			<td><a href='byCategory.php?CategoryID=$row[CategoryID]'>$row[CategoryName]</a></td>
			<td>".strtolower($row[Description])."</td>
		</tr>";
	}
	
	print "</table>";

?>