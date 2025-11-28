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
        .red_label {
            color: red;
        }
    </style>
</head>
<body>
    <?php
        $error_name = $error_operation = $result = "";
        $operation = "";
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            if (isset($_POST['name']) && isset($_POST['operation'])) {
                $name = $_POST['name'];
                $operation = $_POST['operation'];

                if ($name == "") {
                    $error_name = "Imię nie może być puste!";
                }
                if ($operation == "") {
                    $error_operation = "Wybierz marke!";
                }
                if ($error_name == "" && $error_operation == "") {
                    switch ($operation) {
                        case 'Porsche':
                            $result = "<img src='zdjecia\porsche.jpg'>";
                            break;
                        case 'BMW':
                            $result = "<img src='zdjecia\BMW.jpg'>";
                            break;
                        case 'Audi':
                            $result = "<img src='zdjecia\Audi.jpg'>";
                            break;
                        case 'Lamborgini':
                            $result = "<img src='zdjecia\Lamborgini.jpg'>";
                            break;
                        case 'RolceRoyce':
                            $result = "<img src='zdjecia\RolceRoyce.jpg'>";
                            break;
                        case 'Volkswagen':
                            $result = "<img src='zdjecia\Volkswagen.jpg'>";
                            break;
                        
                        default:
                            $result = "Nieznane auto";
                            break;
                    }
                }
            }
        }
    ?>
    <h2>Ulubiony samochód</h2>
    <form method="POST">
        <label>
            Podaj swoje imię:
            <br>
            <input type="text" name="name">
        </label>
        <br>
        <?php echo "<span class='red_label'>".$error_name."</span>"?>
        <br>
        <label>Wybierz ulubiony samochód: </label>
        <br>
        <input type="radio" id="Porsche" name="operation" value="Porsche" <?php if ($operation == "Porsche") echo "checked"; ?>>
        <label for="Porsche">Porsche</label>
        <br>
        <input type="radio" id="BMW" name="operation" value="BMW" <?php if ($operation == "BMW") echo "checked"; ?>>
        <label for="BMW">BMW</label> 
        <br>
        <input type="radio" id="Audi" name="operation" value="Audi" <?php if ($operation == "Audi") echo "checked"; ?>>
        <label for="Audi">Audi</label>
        <br>
        <input type="radio" id="Lamborgini" name="operation" value="Lamborgini" <?php if ($operation == "Lamborgini") echo "checked"; ?>>
        <label for="Lamborgini">Lamborgini</label>
        <br>
        <input type="radio" id="RolceRoyce" name="operation" value="RolceRoyce" <?php if ($operation == "RolceRoyce") echo "checked"; ?>>
        <label for="RolceRoyce">Rolce Royce</label>
        <br>
        <input type="radio" id="Volkswagen" name="operation" value="Volkswagen" <?php if ($operation == "Volkswagen") echo "checked"; ?>>
        <label for="Volkswagen">Volkswagen</label>

        <br>
        <button type="submit">Pokaż</button>
    </form>

    <?php 
        if ($result !== "")
        {
            echo "$name, samochód wybrany przez ciebie może wyglądać tak:<br>";
            echo  $result;
            echo "<br>Jak Ci się podoba?";
        }
    ?>
</body>
</html>