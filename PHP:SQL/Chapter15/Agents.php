<?php
	require("connect2.php");

	$results=mysql_query("
		SELECT FirstName, MiddleInitial, LastName, AgentID
		FROM Agents
		ORDER BY LastName, FirstName
	");
	
	print "<h2>Agents</h2>";
	
	print "<ul>";
	
	while ($row=mysql_fetch_array($results)) {
		print "<li><a href='byAgent?AgentID=$row[AgentID]'>$row[FirstName] $row[MiddleInitial]. $row[LastName]</a></li>";
	}
	
	print "</ul>";

?>