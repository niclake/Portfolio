<html>

<body>
<?php
	extract ($_REQUEST);
	$first_u=strtoupper($first);
	$middle_u=strtoupper($middle);
	$last_u=strtoupper($last);
	print "Your initials are: " . $first_u{0} . $middle_u{0} . $last_u{0} . ".";

?>

</body>
</html>
