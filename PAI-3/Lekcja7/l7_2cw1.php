<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
    <?php

        echo "<h3>Dzisiejsza data:</h3>";
        echo date("Y-m-d") . "<br>";

        $dni = ["niedziela", "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota"];
        $miesiace = [
            1 => "stycznia", 2 => "lutego", 3 => "marca", 4 => "kwietnia", 5 => "maja", 6 => "czerwca",
            7 => "lipca", 8 => "sierpnia", 9 => "września", 10 => "października", 11 => "listopada", 12 => "grudnia"
        ];

        $dzienTygodnia = $dni[date("w")];
        $dzien = date("j");
        $miesiac = $miesiace[date("n")];
        $rok = date("Y");

        echo "Dzisiaj jest $dzienTygodnia, $dzien $miesiac $rok r.";
    ?>


</body>
</html>