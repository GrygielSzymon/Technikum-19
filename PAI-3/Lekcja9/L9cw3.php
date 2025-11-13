<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            line-height: 200%;
        }
    </style>
</head>
<body>
    <h1>Równanie kwadratowe</h1>
    
    <form method="POST">
        <label>ax<sup>2</sup> + bx + c = 0</label><br>

        <label>Podaj a:</label>
        <input type="number" id="numA" name="numA" required><br>

        <label>Podaj b:</label>
        <input type="number" id="numB" name="numB" required><br>

        <label>Podaj c:</label>
        <input type="number" id="numC" name="numC" required><br>

        <button type="submit">Rozwiąż równanie</button>
    </form>

    <?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $a = $_POST['numA'];
        $b = $_POST['numB'];
        $c = $_POST['numC'];

        echo "<h2>Dane:</h2>";
        echo "a = $a, b = $b, c = $c<br>";

        if ($a == 0 || $b == 0 || $c == 0) {
            echo "<strong>Każda zmienna musi być liczbą.</strong>";    
        }
        else {
            $delta = $b*$b - 4*$a*$c;
            $deltaN = number_format($delta, 2, ", ", " ");
            echo "delta = $delta<br>";

            if ($delta > 0) {
                $x11 = (-$b - sqrt($delta)) / (2 * $a);
                $x21 = (-$b + sqrt($delta)) / (2 * $a);
                $x1 = number_format($x11, 2 , ",", " ");
                $x2 = number_format($x21, 2 , ",", " ");
                echo "Równanie ma dwa pierwiastki żeczywiste: $x1 i $x2";
            } elseif ($delta == 0) {
                $x01 = -$b / (2 * $a);
                $x0 = number_format($x01, 2 , ",", " ");
                echo "Równanie ma jeden pierwiastek żeczywisty: $x0";
            } else {
                echo "Brak pierwiastków.";
            }
        }
    }
    ?>
</body>
</html>
