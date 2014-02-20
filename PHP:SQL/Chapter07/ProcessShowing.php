<html>
<title>Nic Lake</title>

<body>
<?php
	extract ($_REQUEST);
	count($criteria);

	print "<h2>Please verify the information you entered:</h2>";
	print "<hr>";
	
	print "<table width='100%'>";
		print "<tr>
			<td width='15%'>Property ID: </td>
			<td>$property</td>
		</tr>";
		print "<tr>
			<td>Date: </td>
			<td>$date</td>
		</tr>";
		print "<tr>
			<td>Time: </td>
			<td>$time</td>
		</tr>";
		print "<tr>
			<td>Name: </td>
			<td>$name</td>
		</tr>";
		print "<tr>
			<td>E-mail address: </td>
			<td>$email</td>
		</tr>";
		print "<tr>
			<td>Current Residence: </td>
			<td>$residence</td>
		</tr>";
		print "<tr>
			<td>Important Criteria: </td>
			<td>
				<ul>";
					//for ($criteria_selected=0; $criteria_selected < count($criteria); $criteria_selected++) {
						//print "<li>$criteria[$criteria_selected]</li>";
					//}
					foreach ($criteria AS $a_criteria) {
						print "<li>$a_criteria</li>";
					}
				print "</ul>
			</td>
		</tr>";
		print "<tr>
			<td>Comments: </td>
			<td>$comments</td>
		</tr>";
	print "</table>";
	print "<hr>";
?>
</body>
</html>
