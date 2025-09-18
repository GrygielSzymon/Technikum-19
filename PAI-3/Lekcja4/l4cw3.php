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
        $szerokosc = 63;

        $obwod = ($dlugosc * 2) + ($szerokosc * 2);
        $pole = ($dlugosc * $szerokosc);

        echo "Obwód: ", $obwod, "<br>";
        echo "Pole: ", $pole;
    ?>
</body>
</html>
