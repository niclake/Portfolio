<html>
<title>Nic Lake</title>

<body>
<?php
	extract ($_REQUEST);
	if ($size == "small") {
	   if ($color == "purple") {
	      print "We're sorry, but we don't have any $size-sized $color shirts available.";
	   }
	   else {
	      print "Your order for a $size-sized $color shirt has been processed.";
	   }
	}
	elseif ($size == "medium") {
	   if ($color == "black") {
	      print "We're sorry, but we don't have any $size-sized $color shirts available.";
	   }
	   else {
	      print "Your order for a $size-sized $color shirt has been processed.";
	   }
	}
	elseif ($size == "large"){
	   if ($color == "white") {
	      print "We're sorry, but we don't have any $size-sized $color shirts available.";
	   }
	   else {
	      print "Your order for a $size-sized $color shirt has been processed.";
	   }
	}
	
//Available: Small - W & B.  Medium - P & W.  Large - B & P	

?>

</body>
</html>