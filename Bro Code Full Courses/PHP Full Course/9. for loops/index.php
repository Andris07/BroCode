<?php

// for loop = repeat some code a certain # of times

for ($i = 1; $i <= 10; $i+=2)
{
    echo "{$i}<br>";
}
echo "<br>";

for ($i = 10; $i > 0; $i-=2)
{
    echo "{$i}<br>";
}
echo "<br>";

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="index.php" method="post">
        <label>Enter a number to count to: </label>
        <input type="number" name="counter">
        <input type="submit" value="start">
    </form>

    <?php

    $counter = $_POST["counter"];

    for ($i = 1; $i <= $counter; $i++)
    {
        echo "{$i}<br>";
    }
    echo "<br>";

    ?>

    <!--
    <form action="index.php" method="post">
        <label>Enter a number to count down from: </label>
        <input type="number" name="counter">
        <input type="submit" value="start">
    </form>

    <?php

    $counter = $_POST["counter"];

    for ($i = $counter; $i > 0; $i--)
    {
        echo "{$i}<br>";
    }
    echo "<br>";

    ?>
    -->
</body>
</html>