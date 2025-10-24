<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
    <?php
        $a = rand(10, 99);
        $b = rand(10, 99);

        $iloraz = $a / $b;
        $podloga = floor($iloraz);
        $sufit = ceil($iloraz);
        $zaokraglenie = round($iloraz, 3);

        echo "Pierwsza liczba: $a<br>";
        echo "Druga liczba: $b<br>";
        echo "Iloraz: $iloraz<br>";
        echo "Liczba całkowita z dołu: $podloga<br>";
        echo "Liczba całkowita z góry: $sufit<br>";
        echo "Iloraz zaokrąglony do trzech miejsc po przecinku: $zaokraglenie<br>";
    ?>


</body>
</html>