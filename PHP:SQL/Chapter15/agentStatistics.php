<?php
	require("connect2.php");
	
	$results=mysql_query("
		SELECT *
		FROM Agents
		ORDER BY LastName
	");
	
	while ($row=mysql_fetch_array($results)) {
		print "<center><h2>Price Statistics for $row[FirstName] $row[MiddleInitial] $row[LastName]</h2>";
		
		$results2=mysql_query("
			SELECT COUNT(PropertyID) AS NumProperties, Sum(Price) AS TotalPrice, Avg(Price) AS AvgPrice, Max(Price) AS MaxPrice, Min(Price) AS MinPrice
			FROM Properties
			WHERE AgentID = '$row[AgentID]'
		");
		
		while ($row2=mysql_fetch_array($results2)) {
			print "<table border='1'>
				<tr>
					<td>Number of Properties</td>
					<td>$row2[NumProperties]</td>
				</tr>
				<tr>
					<td>Total Price</td>
					<td>$". number_format($row2[TotalPrice],2) ."</td>
				</tr>
				<tr>
					<td>Average Price</td>
					<td>$". number_format($row2[AvgPrice],2) ."</td>
				</tr>
				<tr>
					<td>Maximum Price</td>
					<td>$". number_format($row2[MaxPrice],2) ."</td>
				</tr>
				<tr>
					<td>Minimum Price</td>
					<td>$". number_format($row2[MinPrice],2) ."</td>
				</tr>
			</table>";
		}
		
		print "</center>
		<hr width=500>";
	}

?>