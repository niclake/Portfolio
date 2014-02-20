<htmL>
<title></title>

<body>
<?php
extract ($_REQUEST);

if ($areacode == "319" OR $areacode == "515" OR $areacode == "712") 
{
$state = "Iowa";
}
elseif ($areacode == "218" OR $areacode == "320" OR $areacode == "920") 
{
$state = "Minnesota";
}
elseif ($areacode == "414" OR $areacode == "608" OR $areacode == "715") 
{
$state = "Wisconsin";
}
elseif ($areacode == "308" OR $areacode == "402") 
{
$state = "Nebraska";
}
elseif ($areacode == "314" OR $areacode == "417" OR $areacode == "636" OR $areacode=="660" OR $areacode == "816") 
{
$state = "Missouri";
}

print "Your area code is $areacode and you live in $state.";


?>
</body>
</htmL>


