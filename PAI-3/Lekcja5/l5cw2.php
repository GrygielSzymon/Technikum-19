<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $a = 5;
        $b = 32;
        $c = 23;

        $delta = pow($b, 2) - 4*$a*$c;

        echo "a: $a <br>";
        echo "b: $b <br>";
        echo "c: $c <br>";
        echo "delta: $delta<br>";

        if ($delta < 0) {
            echo "Brak pierwiastków";
        } elseif ($delta == 0) {
            $x = -$b / (2 * $a);
            echo "Jeden pierwiastek";
        } else {
            $pDelta = sqrt($delta);
            $x1 = (-$b - $pDelta) / (2 * $a);
            $x2 = (-$b + $pDelta) / (2 * $a);
            echo "Dwa pierwiastki<br>";
            echo "x1 = $x1<br>";
            echo "x2 = $x2";
        }


    ?>
</body>
</html>