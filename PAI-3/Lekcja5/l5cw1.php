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
        $b = 10;

        if ($a > $b) {
            echo "Liczba $a jest większa od $b";
        }
        elseif ($b > $a) {
            echo "Liczba $b jest większa od $a";
        }
        elseif ($a == $b) {
            echo "Liczby $a i $b są równe";
        }
        else {
            echo "Złe liczby.";
        }
    ?>
</body>
</html>