<?php
	require("connect.php");

	$results=mysql_query("
		SELECT ProductName
		FROM Products
		WHERE CategoryID = '2'
		ORDER BY ProductName
	");
	
	print "<ul>";
	
	while ($row=mysql_fetch_array($results)) {
		print "<li>$row[ProductName]</li>";
	}
		
	print "</ul>";

?>