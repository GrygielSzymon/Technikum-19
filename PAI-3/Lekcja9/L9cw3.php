<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body{
            line-height: 200%;
        }
    </style>
</head>
<body>
    <h2>Równanie kwadratowe</h2>
    <p><strong>ax<sup>2</sup> + bx + c = 0</strong></p>

    <form method="post">
        <label>
            Podaj liczbę a:
            <input type="text" name="a" required>
        </label>
        <br>
        <label>
            Podaj liczbę b:
            <input type="text" name="b" required>
        </label>
        <br>
        <label>
            Podaj liczbę c:
            <input type="text" name="c" required>
        </label>
        <br><br>
        <button type="submit">Rozwiąż równanie</button>
    </form>

    <?php
        if (isset($_POST["a"]) && isset($_POST["b"]) && isset($_POST["c"])) {

            $a = $_POST["a"];
            $b = $_POST["b"];
            $c = $_POST["c"];

            echo "<p>a = $a, b = $b, c = $c</p>";

            if (!(is_numeric($a) && is_numeric($b) && is_numeric($c))) {
                echo "<p><strong>Kazda zmienna musi byc liczba</strong></p>";
                return;
            }

            $a = intval($a);
            $b = intval($b);
            $c = intval($c);

            if ($a == 0) {
                echo "<p>To nie jest równanie kwadratowe (a = 0).</p>";
                return;
            } 
            
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
    ?>
</body>
</html>
