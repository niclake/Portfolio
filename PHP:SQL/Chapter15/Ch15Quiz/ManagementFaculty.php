<title>Nic Lake</title>
<?php
	require ("connect3.php");

	$results=mysql_query("
		SELECT LastName, FirstName, Title, OfficeNumber, OfficePhone
		FROM Faculty
		ORDER BY LastName
	");
	
	print "<center>";
	
	print "Management Department Faculty<br><br>";
	
	print "<table border=1>
		<tr>
			<th>NAME</th>
			<th>TITLE</th>
			<th>OFFICE</th>
			<th>PHONE</th>
		</tr>";
	
	while ($row=mysql_fetch_array($results)) {
		print "<tr>
			<td>$row[LastName], $row[FirstName]</td>
			<td>$row[Title]</td>
			<td>$row[OfficeNumber]&nbsp;</td>
			<td>$row[OfficePhone]&nbsp;</td>
		</tr>";	
	}

	print "</table>";

?>