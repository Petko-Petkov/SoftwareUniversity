<?php
$year = date("Y");
$month = date("F");
$totalDays = date("d");

for ($i = 1; $i < $totalDays; $i++) {
    $date = strtotime("$i $month $year");
    if(date("l", $date)== "Sunday"){
        echo date("jS F, Y", $date) . "\n";
    }
}
?>