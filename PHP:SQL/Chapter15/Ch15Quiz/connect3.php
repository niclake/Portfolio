<?php
$dbhost='localhost';
$dbuser='laken';
$dbpass='StartMIDI38';
$dbname='cba';

//Connect to database server
$dbs=mysql_connect($dbhost, $dbuser, $dbpass);

//Connect to database
$db=mysql_select_db($dbname);
?>