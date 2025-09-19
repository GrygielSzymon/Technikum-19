<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $x = 2;
        $y = 3;
        $z = 4;
        $x++;
        $y--;
        $z += $y;
        --$z;
        $x *= $z;
        print ($x." ".$y." ".$z); # 15 2 5
    ?>
</body>
</html>