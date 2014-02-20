<?php
	require("connect.php");

	$url=$_GET[CategoryID];

	$results=mysql_query("
		SELECT ProductName, ProductID
		FROM Products
		WHERE CategoryID = '$url'
		ORDER BY ProductName
	");
	
	$results2=mysql_query("
		SELECT CategoryName
		FROM Categories
		WHERE CategoryID=$url
	");
	
	while ($row=mysql_fetch_array($results2)) {
		print "<h2>$row[CategoryName]</h2>";
	}
	
	print "<ul>";
	
	while ($row=mysql_fetch_array($results)) {
		print "<li><a href='byProduct.php?ProductID=$row[ProductID]'>$row[ProductName]</a></li>";
	}
		
	print "</ul>";

?>