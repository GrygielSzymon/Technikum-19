<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $x = 1;
        echo $x, "<br>";
        echo --$x, "<br>";
        echo $x, "<br>";
        $y = $x--;
        echo $y, "<br>";
        $y = --$x;
        echo $y, "<br>";
        echo --$y;
    ?>
</body>
</html>