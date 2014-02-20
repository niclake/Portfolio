<html>
<title>Untitled Document</title>

<body>

<?php
	extract ($_REQUEST);
	print "<table border='1'>";
	print "<tr><th>Toppings</th></tr>";
	for ($i=0;  $i <count($toppings); $i++)
		{
		print "<tr><td>". strtoupper($toppings[$i]) . "</td></tr>";
		}
	print "</table>";
?>
</body>
</html>
