<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="index.php" method="post">
        <input type="checkbox" name="pizza" value="Pizza">
        <label>Pizza</label><br>
        <input type="checkbox" name="hamburger" value="Hamburger">
        <label>Hamburger</label><br>
        <input type="checkbox" name="hotdog" value="Hotdog">
        <label>Hotdog</label><br>
        <input type="checkbox" name="taco" value="Taco">
        <label>Taco</label><br>
        <input type="submit" name="submit" value="submit">
    </form>
</body>
</html>

<?php

if (isset($_POST["submit"]))
{
    if (isset($_POST["pizza"]))
    {
        echo "You like pizza!<br>";
    }
    if (isset($_POST["hamburger"]))
    {
        echo "You like hamburgers!<br>";
    }
    if (isset($_POST["hotdog"]))
    {
        echo "You like hotdogs!<br>";
    }
    if (isset($_POST["taco"]))
    {
        echo "You like tacos!<br>";
    }
    echo "<br>";

    if (empty($_POST["pizza"]))
    {
        echo "You DON'T like pizza!<br>";
    }
    if (empty($_POST["hamburger"]))
    {
        echo "You DON'T like hamburgers!<br>";
    }
    if (empty($_POST["hotdog"]))
    {
        echo "You DON'T like hotdogs!<br>";
    }
    if (empty($_POST["taco"]))
    {
        echo "You DON'T like tacos!<br>";
    }
    echo "<br>";

    /*
    $foods = $_POST["foods[]"];

    foreach ($foods as $food)
    {
        echo "{$food}<br>";
    }
    // replace name="pizza", name="hamburger" etc. with name="foods[]" if you want to group them
    */
}

?>