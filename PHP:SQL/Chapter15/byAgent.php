<?php
	require("connect2.php");

	$url=$_GET[AgentID];
	
	$results=mysql_query("
		SELECT *
		FROM Agents
		WHERE AgentID = '$url'
	");
	
	print "<hr width=500>
		<h2 align='center'>Agent Detail Listing</h2>
		<hr width=500>";
	
	print "<table border='1' align=center>";
	
	while ($row=mysql_fetch_array($results)) {
		print "<tr>
			<td colspan=2><b>$row[FirstName] $row[LastName]<br>
			$row[Address]<br>
			$row[City], $row[State], $row[ZipCode]<br><br>
			<a href='mailto:$row[EmailAddress]'>$row[EmailAddress]</a><br><br>
			$row[WorkPhone]</b>
			</td>
		</tr>";
	}

?>