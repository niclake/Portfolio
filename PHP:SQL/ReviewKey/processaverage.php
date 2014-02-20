<html>
<title>Untitled Document</title>


<body>

<?php
	extract ($_REQUEST);
	$average = ($exam1 + $exam2 + $exam3) / 3;
	print "<table border='1'>";
	print "<tr><td>Exam 1:</td><td>$exam1</td></tr>";
	print "<tr><td>Exam 2:</td><td>$exam2</td></tr>";
	print "<tr><td>Exam 3:</td><td>$exam3</td></tr>";
	print "<tr><td>Average:</td><td>" . number_format($average,2) . "</td></tr>";
	print "</table>";


//	extract ($_REQUEST);
//	$average = ($exam1 + $exam2 + $exam3) / 3;
//	$formattedaverage=number_format($average,2);
//	print "<table border='1'>";
//	print "<tr><td>Exam 1:</td><td>$exam1</td></tr>";
//	print "<tr><td>Exam 2:</td><td>$exam2</td></tr>";
//	print "<tr><td>Exam 3:</td><td>$exam3</td></tr>";
//	print "<tr><td>Average:</td><td>$formattedaverage</td></tr>";
//	print "</table>";

?>


</body>
</html>
