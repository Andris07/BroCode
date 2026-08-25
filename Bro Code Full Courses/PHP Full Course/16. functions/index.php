<?php

// function = write some code once, reuse when you need it
//            type () after function name to invoke
//            ex. add() subtract() multiply() divide()

function happy_birthday(string $first_name, int $age)
{
    echo "Happy Birthday dear {$first_name}!<br>";
    echo "Happy Birthday to you!<br>";
    echo "Happy Birthday dear {$first_name}!<br>";
    echo "You are {$age} years old!<br><br>";
}

function is_even(int $number)
{
    return $number % 2;
}

function hypotenuse(float $a, float $b)
{
    $c = sqrt($a ** 2 + $b ** 2);
    return $c;
}

happy_birthday("Spongebob", 30);
happy_birthday("Patrick", 35);
happy_birthday("Squidward", 45);

echo is_even(10) . "<br>";
echo is_even(11) . "<br>";
echo "<br>";

echo hypotenuse(3, 4) . "<br>";
echo hypotenuse(4, 5) . "<br>";
echo "<br>";

?>