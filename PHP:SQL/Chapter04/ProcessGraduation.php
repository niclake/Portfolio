<html>
<title>Nic Lake</title>

<body>
<?php
	extract ($_REQUEST);
	if ($class == "freshman") {
		$gradyear=2013;
	}
	elseif ($class == "sophomore") {
		$gradyear=2012;
	}
	elseif ($class == "junior") {
		$gradyear=2011;
	}
	elseif ($class == "senior") {
		$gradyear=2010;
	}

	print "<table border='1'>
		<tr>
			<td>Class:</td>
			<td>$class</td>
		</tr>
		<tr>
			<td>Graduation Year:</td>
			<td>$gradyear</td>
		</tr>";

?>

</body>
</html>