<?php

$text = $_GET['text'];
$hashValue = $_GET['hashValue'];
$fontSize = $_GET['fontSize'];
$style = $_GET['fontStyle'];
if($style == "bold"){
    $style = ';font-weight:bold';
} else {
    $style = ';font-style:'.$style;
}
echo '<p style="font-size:'.$fontSize.$style.';">'.hasher($text, $hashValue).'</p>';

function hasher($text, $hashValue) {
    $hashedStr = "";

    for ($i = 0; $i < strlen($text); $i++) {
        $hashedChar = hashChar($hashValue, $text[$i], $i);
        $hashedStr = $hashedStr . $hashedChar;
    }

    return $hashedStr;
}

function hashChar ($hashvalue, $stringChar, $incrementer) {
    $intChar = ord($stringChar);

    if ($incrementer % 2 == 1) {
        $intChar -= $hashvalue;
    } else {
        $intChar += $hashvalue;
    }

    return chr($intChar);
}

?>