<?php

$counter = 0;
$n = 12;

for ($i = 102; $i <= $n; $i++) {
    $emptyStr = "";

    $first = (int)($i % 10);
    $second = (int)(($i / 10) % 10);
    $third = (int)(($i / 100) % 10);

    if ($first != $second &&
        $first != $third &&
        $second != $third){
        $emptyStr = $third.$second.$first;
        echo($emptyStr . ", ");
        $counter ++;
    }
}

if ($counter == 0){
    echo "No";
}

?>