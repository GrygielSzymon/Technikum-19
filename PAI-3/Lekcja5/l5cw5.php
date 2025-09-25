<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        table, th, td{
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</head>
<body>

    <?php

    $nazwa1 = "placek po węgiersku";
    $liczba1 = 2;
    $cena1a = 15.90;
    
    $nazwa2 = "pierogi zbójnickie";
    $liczba2 = 1;
    $cena2a = 12.90;
    $koszta = ($liczba1 * $cena1a) + ($liczba2 * $cena2a);

    $dystans = 10;
    $cenazakm = 2.24;
    $dostawaa = $dystans * $cenazakm;

    $nazwa1a = "pierogi zbójnickie";
    $nazwa2a = "pierogi zbójnickie";
    
    if ($nazwa1 == $nazwa1a || $nazwa2 == $nazwa2a) {
        $dostawaa = 0;
    }
    $dostawa1 = number_format($dostawaa, 2, ',', ' ');
    if ($dostawaa == 0) {
        $prom = "Skorzystałeś z promocji <strong>dostawa gratis!</strong>";
    } else {
        $prom = "Niestety nie skorzystałeś z naszej promocji :(";
    }

    $ilosc = $liczba1 + $liczba2;

    $rabata = 0;
    switch ($ilosc) {
        case 3:
            $rabata = 0.10 * $koszta;
            $koszta -= $rabata;
            break;
        case $ilosc > 3:
            $rabata = 0.20 * $koszta;
            $koszta -= $rabata;
            break;
        default:
            
            break;
    }
    

    $cena1 = number_format($cena1a, 2, ',', ' ');
    $cena2 = number_format($cena2a, 2, ',', ' ');
    $koszt = number_format($koszta, 2, ',', ' ');
    $rabat = number_format($rabata, 2, ',', ' ');

    echo<<<KONIEC
    <h1>Twoje zamówienie</h1>
    <table>
        <tr>
            <th>Nazwa</th>
            <th>Liczba</th>
            <th>cena</th>
        </tr>
        <tr>
            <td>$nazwa1</td>
            <td>$liczba1</td>
            <td>$cena1</td>
        </tr>
        <tr>
            <td>$nazwa2</td>
            <td>$liczba2</td>
            <td>$cena2</td>
        </tr>
        <tr>
            <td>dostawa</td>
            <td>-</td>
            <td>$dostawa1</td>
        </tr>
        <tr>
            <td>rabat</td>
            <td>-</td>
            <td>$rabat</td>
        </tr>
        <tr>
            <td>Do zaplaty</td>
            <td>-</td>
            <td>$koszt</td>
        </tr>
    </table>
    <h1>Dziękujemy!</h1>
    <p>$prom</p>
    KONIEC;



    ?>
</body>
</html>