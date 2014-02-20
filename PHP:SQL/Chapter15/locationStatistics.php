<?php
   require("connect2.php");
   
   $results=mysql_query("
      SELECT Location, COUNT(Location) AS NumProp, Sum(Price) AS TotalPrice,
         Avg(Price) AS AvgPrice, Max(Price) AS MaxPrice, Min(Price) AS MinPrice
      FROM Properties
      GROUP BY Location
      ORDER BY Location
   ");
   
   print "<center>";
   
   while ($row=mysql_fetch_array($results)) {
      print "<h3>Price Statistics for Location - $row[Location]</h2><br><br>";
      
      print "<table border=1>
         <tr>
            <td>Number of Properties</td>
            <td>$row[NumProp]</td>
         </tr>
         <tr>
            <td>Total Price</td>
            <td>$".number_format($row[TotalPrice], 2)."</td>
         </tr>
         <tr>
            <td>Average Price</td>
            <td>$".number_format($row[AvgPrice], 2)."</td>
         </tr>
         <tr>
            <td>Maximum Price</td>
            <td>$".number_format($row[MaxPrice], 2)."</td>
         </tr>
         <tr>
            <td>Minimum Price</td>
            <td>$".number_format($row[MinPrice], 2)."</td>
         </tr>
      </table>";
      
      print "<hr width=500>";
   }

?>