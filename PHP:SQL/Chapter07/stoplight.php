<html>
<title>Untitled Document</title>

<body>
<?php
	extract ($_REQUEST);

	$color_low = strtolower($color);
	
	switch ($color_low) {
		case "red":
			print ucfirst($color_low) . " means STOP!";
			break;
			
		case "yellow":
			print ucfirst($color_low) . " means SLOW DOWN!";
			break;
			
		case "green":
			print ucfirst($color_low) . " means GO!";
			break;
			
		default:
			print "Enter a different color.";
			break;
	}
	
?>

</body>
</html>






