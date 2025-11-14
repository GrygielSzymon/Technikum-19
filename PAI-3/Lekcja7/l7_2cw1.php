<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        echo "Witamy dnia " . date("d.m.Y") . "<br>"; 

        $dayTab = ["niedziela", "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota"];
        $monthTab = [
            1 => "stycznia", 2 => "lutego", 3 => "marca", 4 => "kwietnia", 5 => "maja", 6 => "czerwca",
            7 => "lipca", 8 => "sierpnia", 9 => "września", 10 => "października", 11 => "listopada", 12 => "grudnia"
        ];

        $dayOfWeek = $dayTab[date("N")];
        $month = $monthTab[date("n")];

        echo "Witamy w " . $dayOfWeek . ", dnia " . date("d") . " " . $month . " " . date("Y") . " roku";
    ?>
</body>
</html>