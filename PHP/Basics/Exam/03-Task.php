<?php

//$inputText = $_GET['text'];
//$inputLength = $_GET['lineLength'];


$inputText = "The Milky way is the galaxy that contains our star system";
$inputLength = 10;
$matrix = [];
$jumper = 0;
for ($i = 0; $i < strlen($inputText)/10; $i++) {
    $matrix[$i] = substr($inputText, $jumper, 10);
    $jumper+=10;
}

$innerMatrix = [];

for ($i = 0; $i < count($matrix); $i++) {
    $innerMatrix[$i] = explode($matrix[$i], "");
    var_dump($innerMatrix);
}