<html>
<title>Untitled Document</title>

<body>
<?php
	//Create an Array
	$provinces=array(
	   "Newfoundland",
	   "Prince Edward",
	   "Nova Scotia",
	   "New Brunswick",
	   "Quebec",
	   "Manitoba",
	   "Saskatchewan",
	   "Alberta"
	);
	
	//Display a value of the array
	print "$provinces[1]";
	
	//Display key-value pairs
	print "<br><br>";
	print_r($provinces);
	
	print "<br><br>";
	print "Canada's smallest province is $provinces[1].<br>";
	print "Canada's largest province is $provinces[4].<br>";
	
	//Count values in array
	print "<br>Canada has ".count($provinces)." provinces.";
	
	//Alphabetize the array
	sort($provinces);
	print "<br><br>Alphabetized list:<br>";
	print_r($provinces);
	
	//Sort descending (reverse)
	rsort($provinces);
	print "<br><br>Reverse alphabetized list:<br>";
	print_r($provinces);
	
	print "<br><br>Print in list form:<br>";
	print "<ul>";
	foreach ($provinces as $a_province) {
		print "<li>$a_province</li>";
	}
	print "</ul>";
	
	//Add Values - End array_push()
	$add=array_push($Provinces, "British Columbia");
	print "<br><br>";
	//print "$add was added to provinces.";
	print_r($Provinces);
	
	//Add Values - Beginning array_unshift()
	$addB=array_unshift($Provinces, "Alaska");
	print "<br><br>";
	print_r($Provinces);
	
	//Remove Values - End array_pop()
	//remove Britsh Columbia from end of provinces
	$remove=array_pop($Provinces);
	print "<br><br>";
	print_r($Provinces);
	
	//Remove Values - Beginning array_shift()
	//Remove Alaska from the beginning of provinces
	$removeB=array_shift($Provinces);
	print "<br><br>";
	print_r($Provinces);
	
	//Change Value
	$Provinces[2]="Prince Edward Island";
	print "<br><br>";
	print_r($Provinces);
?>

</body>
</html>






