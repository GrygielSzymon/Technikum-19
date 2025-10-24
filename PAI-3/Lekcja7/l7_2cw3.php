<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $zakupy = ["chleb", "masło", "mleko", "ser", "jabłka"];

        // a) Wyświetlenie tablicy trzema funkcjami
        echo "<h3>a) Wyświetlenie tablicy:</h3>";
        print_r($zakupy);
        echo "<br>";
        var_dump($zakupy);
        echo "<br>";
        echo "<pre>";
        print_r($zakupy);
        echo "</pre>";

        // b) Sortowanie rosnąco
        sort($zakupy);
        echo "<h3>b) Tablica po sortowaniu rosnącym:</h3>";
        print_r($zakupy);

        // c) Dodanie produktu na początku
        array_unshift($zakupy, "kawa");
        echo "<h3>c) Po dodaniu produktu na początku:</h3>";
        echo "Liczba elementów: " . count($zakupy) . "<br>";
        print_r($zakupy);

        // d) Usunięcie ostatniego i sortowanie malejące
        array_pop($zakupy);
        rsort($zakupy);

        // e) Wyświetlenie listy
        echo "<h3>e) Lista zakupów:</h3>";
        echo "<ol>";
        foreach ($zakupy as $produkt) {
            echo "<li>$produkt</li>";
        }
        echo "</ol>";
    ?>

</body>
</html>