<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        .red_label {
            color: red;
        }
    </style>
</head>
<body>
    <?php
    $error_num1 = $error_num2 = $error_operation = $result = "";
    $num1 = $num2 = 0;
    $operation = "";

    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        if (isset($_POST['num1']) && isset($_POST['num2']) && isset($_POST['operation'])) {
            $num1 = $_POST['num1'];
            $num2 = $_POST['num2'];
            $operation = $_POST['operation'];

            if ($num1 == "") {
                $error_num1 = "Pole nie może być puste";
            }

            if ($num2 == "") {
                $error_num2 = "Pole nie może być puste";
            }

            if ($operation == "") {
                $error_operation = "Wybierz działanie";
            }

            if ($error_num1 == "" && $error_num2 == "" && $error_operation == "") {
                switch ($operation) {
                    case "+":
                        $result = $num1 + $num2;
                        break;
                    case "-":
                        $result = $num1 - $num2;
                        break;
                    case "*":
                        $result = $num1 * $num2;
                        break;
                    case "/":
                        if ($num2 == 0) {
                            $result = "Błąd: Dzielenie przez zero";
                        } else {
                            $result = $num1 / $num2;
                        }
                        break;
                    default:
                        $result = "Nieznane działanie";
                }
            }
        }
    }
    ?>
    
    <form method="post">
        <label for="num1">Podaj 1 liczbę:</label><br>
        <input type="number" id="num1" name="num1" value="<?php echo $num1; ?>"><br>
        <?php echo "<span class='red_label'>".$error_num1."</span>";?><br>

        <label for="num2">Podaj 2 liczbę:</label><br>
        <input type="number" id="num2" name="num2" value="<?php echo $num2; ?>"><br>
        <?php echo "<span class='red_label'>".$error_num2."</span>";?><br>

        <label>Wybierz działanie:</label><br>
        <input type="radio" id="plus" name="operation" value="+" <?php if ($operation == "+") echo "checked"; ?>>
        <label for="plus">+</label><br>
        <input type="radio" id="minus" name="operation" value="-" <?php if ($operation == "-") echo "checked"; ?>>
        <label for="minus">-</label><br>
        <input type="radio" id="multiply" name="operation" value="*" <?php if ($operation == "*") echo "checked"; ?>>
        <label for="multiply">*</label><br>
        <input type="radio" id="divide" name="operation" value="/" <?php if ($operation == "/") echo "checked"; ?>>
        <label for="divide">/</label><br>
        <?php echo "<span class='red_label'>".$error_operation."</span>";?><br>

        <button type="submit">Wykonaj</button>
    </form>

    <?php if ($result !== ""): ?>
        <h2>Wynik: <?php echo $result; ?></h2>
    <?php endif; ?>
</body>
</html>
