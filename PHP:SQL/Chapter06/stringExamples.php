<html>

<body>
<?php
//$amount=1234.5678;
//print "The item you selected costs \$" . number_format($amount, 2, '.', ',') . ".";

$amount=1234.5678;
$formattedamount=number_format($amount,2);

print "The item you selected will cost \$$formattedamount.<br /><br />";

$email="NicLake13@Gmail.Com";
$lower_email=strtolower($email);
$upper_email=strtoupper($email);
print "$email<br />";
print "$lower_email<br />";
print "$upper_email<br /><br />";

$state="iowa";
$state_right=ucfirst($state);
print "$state<br />";
print "$state_right<br /><br />";

$otherstate="new york";
$otherstate_right=ucwords($otherstate);
print "$otherstate<br />";
print "$otherstate_right<br /><br />";

$state3="cAlIfOrNiA";
$state3_wrong=ucfirst($state3);
$state3_lower=strtolower($state3);
$state3_right=ucfirst($state3_lower);
//or
$state3_easy=ucfirst(strtolower($state3));
print "$state3<br />";
print "$state3_wrong<br />";
print "$state3_lower<br />";
print "$state3_right<br /> or<br />";
print "$state3_easy<br />";

?>

</body>
</html>
