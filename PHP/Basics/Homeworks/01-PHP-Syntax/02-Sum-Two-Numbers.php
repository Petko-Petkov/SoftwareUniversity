<?php

$firstNumber = 2;
$secondNumber = 5;
$result = $firstNumber + $secondNumber;
$result = number_format($result, 2);

?>

<p>$firstNumber + $secondNumber = <?= "$firstNumber + $secondNumber = $result"?></p>

<?php

$firstNumber = 1.567808;
$secondNumber = 0.356;
$result = $firstNumber + $secondNumber;
$result = number_format($result, 2);

?>

<p>$firstNumber + $secondNumber = <?= "$firstNumber + $secondNumber = $result"?></p>

<?php

$firstNumber = 1234.5678;
$secondNumber = 333;
$result = $firstNumber + $secondNumber;
$result = number_format($result, 2);

?>

<p>$firstNumber + $secondNumber = <?= "$firstNumber + $secondNumber = $result"?></p>