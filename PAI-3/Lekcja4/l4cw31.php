<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $dlugosc = 23;
        $szerokosc = 6.3;

        $obwod = ($dlugosc * 2) + ($szerokosc * 2);
        $pole = ($dlugosc * $szerokosc);

        if ($pole != (int)$pole) {
            $pole_formatted = number_format($pole, 2, ',', ' ');
        } else {
            $pole_formatted = $pole;
        }
        echo "Pole: <strong>" . $pole_formatted . "</strong><br>";

        if ($obwod != (int)$obwod) {
            $obwod_formatted = number_format($obwod, 2, ',', ' ');
        } else {
            $obwod_formatted = $obwod;
        }
        echo "Obwód: <strong>" . $obwod_formatted . "</strong><br>";
    ?>
</body>
</html>