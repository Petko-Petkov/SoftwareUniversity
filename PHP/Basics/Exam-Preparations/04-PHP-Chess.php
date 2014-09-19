
<?php

$input = $_GET['board'];

$validFigures = array("R"=>0, "H"=>0, "B"=>0, "K"=>0, "P"=>0, "Q"=>0, " "=>0);


if (strlen($input) != 127 ) {
    echo "<h1>Invalid chess board</h1>";
    return;
}

if ($input[15] != "/" ||
    $input[31] != "/" ||
    $input[47] != "/" ||
    $input[63] != "/" ||
    $input[79] != "/" ||
    $input[95] != "/" ||
    $input[111] != "/"){
    echo "<h1>Invalid chess board</h1>";
    return;
}

for ($i = 1; $i < strlen($input) ; $i+=2) {
    if($i == 15 || $i == 31 || $i == 47 || $i == 63 || $i == 79 || $i == 95 || $i == 111 ){
        continue;
    }

    if($input[$i] != "-"){
        echo "<h1>Invalid chess board</h1>";
        return;
    }
}

for ($i = 0; $i < strlen($input) ; $i+=2) {
    if(!array_key_exists($input[$i], $validFigures)){
        echo "<h1>Invalid chess board</h1>";
        return;
    }
}

$input = str_replace("-", "", $input);
$input = str_replace("/", "", $input);

echo "<table>";

for ($i = 0; $i < 64 ; $i+=8) {
    echo "<tr>";
    for ($y = $i; $y < $i+8; $y++) {
        echo "<td>".$input[$y]."</td>";
        $validFigures[$input[$y]]++;
    }

    echo "</tr>";
}

echo "</table>";
$b = $validFigures["B"] == 0 ? "" : "\"Bishop\":$validFigures[B],";
$h = $validFigures["H"]==0?"" : "\"Horseman\":$validFigures[H],";
$k = $validFigures["K"]==0?"":  "\"King\":$validFigures[K],";
$p = $validFigures["P"]==0?"": "\"Pawn\":$validFigures[P],";
$q = $validFigures["Q"]==0?"":  "\"Queen\":$validFigures[Q],";
$r = $validFigures["R"]==0?"": "\"Rook\":$validFigures[R]";

$STR = "{".$b.$h.$k.$p.$q.$r."}";
$STR = str_replace(",}", "}", $STR);
echo $STR;
?>