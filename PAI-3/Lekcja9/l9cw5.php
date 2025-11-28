<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        h2, form{
            line-height: 200%;
        }
    </style>
</head>
<body>
    <h2>Piramida znaków</h2>
    <form method = "POST">
        <label>
            <strong>Wybierz znak</strong>
            <select name="sign">
                <option value="*">*</option>
                <option value="$">$</option>
                <option value="@">@</option>
                <option value="^">^</option>
                <option value="%">%</option>
            </select>
        </label>
        <br>
        <label>
            <strong>Wpisz ilość poziomów piramidy </strong>
            <input type="number" name="height">
        </label>
        <br>
        <button type="submit">Utwórz</button>
    </form>
    <?php
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            if (isset($_POST["height"]) && isset($_POST["sign"])) {
                $height = $_POST["height"];
                $sign = $_POST["sign"];


                if ($height < 0) {
                    echo "<p><strong>Nie da się utworzyć piramidy!!!</strong></p>";
                }
                else {
                    for ($i=1; $i <= $height; $i++) { 
                        for ($j=1; $j <= $i; $j++) { 
                            echo $sign;
                        }
                        echo "<br>";
                    }
                }
            }
        }
    ?>
</body>
</html>