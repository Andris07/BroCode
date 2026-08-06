<?php

// Arithmetic operators
// + - * / ** %

// Increment/decrement operators
// ++, --

// Operator Precedence
// ()
// **
// * / %
// + -

$x = 10;
$y = 2;
$z = null;

// $z = $x + $y;
// $z = $x - $y;
// $z = $x * $y;
// $z = $x / $y;
// $z = $x ** $y;
// $z = $x % $y;
// echo $z;

$counter = 0;

// $counter = $counter + 1;
// $counter++;
// $counter = $counter - 1;
// $counter--;

// $counter+=3;
// $counter-=3;
// echo $counter;

$total = 1 + 2 - 3 * 4 / 5 ** 6;
// $total = 1 + 2 - 3 * 4 / 15625
// $ total = 1 + 2 - 12 / 15625
// $ total = 1 + 2 - 0.000768
// $ total = 3 - 0.000768
// $ total = 2.999232
echo $total;

?>