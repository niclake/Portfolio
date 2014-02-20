<html>
<title>Nic Lake</title>
<body>

<?php
extract ($_REQUEST);

	$average=($exam1 + $exam2 + $exam3) / 3;
	$formattedaverage = number_format($average,2);
	
	print "<table border='1'>
		<tr>
			<td>Exam 1:</td>
			<td>$exam1</td>
		</tr>
		
		<tr>
			<td>Exam 2:</td>
			<td>$exam2</td>
		</tr>
		
		<tr>
			<td>Exam 3:</td>
			<td>$exam3</td>
		</tr>
		
		<tr>
			<td>Average:</td>
			<td>".number_format($average,2)."</td>
		</tr>";

?>

</body>
</html>