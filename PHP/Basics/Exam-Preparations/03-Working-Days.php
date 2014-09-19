<?php
date_default_timezone_set("Europe/Sofia");



$firstDate = $_GET['dateOne'];
$secondDate = $_GET['dateTwo'];
$valid = false;
function returnDates($fromdate, $todate) {
    $fromdate = DateTime::createFromFormat('d-m-Y', $fromdate);
    $todate = DateTime::createFromFormat('d-m-Y', $todate);
    return new DatePeriod(
        $fromdate,
        new DateInterval('P1D'),
        $todate->modify('+1 day')
    );
}
$datePeriod = returnDates($firstDate, $secondDate);

$input = $_GET['holidays'];
$holidays = explode("\n", $input);

for ($i = 0; $i < count($holidays); $i++) {
    $holidays[$i] = trim($holidays[$i]);
}
$out = "";
$out = $out. "<ol>";
foreach($datePeriod as $date) {
    if(isweekend($date->format('d-m-Y')) || in_array($date->format('d-m-Y'), $holidays)) {
        continue;
    }

    $valid = true;
    $out = $out.  "<li>".$date->format('d-m-Y')."</li>";
}

$out = $out.  "</ol>";

if($valid){
    echo $out;
}else{
    echo "<h2>No workdays</h2>";
}

function isWeekend($date) {
    return (date('N', strtotime($date)) >= 6);
}

?>