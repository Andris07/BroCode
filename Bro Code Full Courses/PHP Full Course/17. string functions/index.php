<?php

$username = "Bro Code";
$username_01 = "Bro The Code";
$phone = "123-456-7890";

// $username = strtolower($username);
// $username = strtoupper($username);
// $username = trim($username);
// $username = str_pad($username, 20, "0");
// $phone = str_replace("-", "", $phone);
// $username = strrev($username);
// $username = str_shuffle($username);
$equals = strcmp($username, "Bro Code");
$count = strlen($phone);
$index = strpos($phone, "-");
$firstname = substr($username, 0, 3);
$lastname = substr($username, 4);
$fullname = explode(" ", $username_01);
$username_01_dashed = implode("-", $fullname);

echo $username . "<br>";
echo $equals . "<br>";
echo $firstname . "<br>";
echo $lastname . "<br>";

foreach ($fullname as $name)
{
    echo $name . "<br>";
}
echo $username_01_dashed . "<br>";

echo "<br>";

echo $phone . "<br>";
echo $count . "<br>";
echo $index . "<br>";

?>