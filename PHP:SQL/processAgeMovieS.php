<html>
<title>Untitled Document</title>

<body>
<?php
	extract ($_REQUEST);

	switch ($age) {
		case ($age >= 55 OR $age <= 12):
			$price=6.5;
			break;
		
		default:
			$price=9;
			break;
	}

	print "$name, it will cost you \$" . number_format($price,2) . " to attend a movie.";	
	
?>

</body>
</html>






