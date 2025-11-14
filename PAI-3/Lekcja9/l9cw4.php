<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body{
            line-height: 200%;
        }
        table, th, td{
            border: 1px solid black;
            border-collapse: collapse;
        }
        th, td{
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
    <h2>Tabliczka mnożenia</h2>
    <form method="post">
        <label>
            <strong>Podaj liczbę początkową:</strong>
            <input type="number" name="numA">
        </label>
        <br>
        <label>
            <strong>Podaj liczbę końcową:</strong>
            <input type="number" name="numB">
        </label>
        <br>
        <button type="submit">Utwórz</button>
    </form>

    <?php
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            if (isset($_POST["numA"]) && isset($_POST["numB"])) {
                $a = $_POST["numA"];
                $b = $_POST["numB"];


                if ($a > $b) {
                    echo "<p><strong>Początek nie może być większy od końca!!</strong></p>";
                }
                else {
                    echo "<p>a = $a, b = $b </p>";
                    echo "<table>";
                    echo "<tr><th></th>";
                    for ($width = $a; $width <= $b; $width++) {
                        echo "<th>$width</th>";
                    }
                    echo "</tr>";

                    for ($height = $a; $height <= $b; $height++) {
                        echo "<tr>";
                        echo "<th>$height</th>";

                        for ($width = $a; $width <= $b; $width++) {
                            echo "<td>";
                            echo $width * $height;
                            echo "</td>";
                        }

                        echo "</tr>";
                    }
                    echo "</table>";
                }
            }
        }
    ?>

</body>
</html>