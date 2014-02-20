<html>
<title>Nic Lake</title>
<body>

<?php
	extract ($_REQUEST);
	count($major);
	print "Major(s) selected: <br>";
	print "<ul>";
		for ($major_selected=0; $major_selected < count($major); $major_selected++) {
			print "<li>$major[$major_selected]</li>";
		}
	print "</ul>";
?>

</body>
</html>
