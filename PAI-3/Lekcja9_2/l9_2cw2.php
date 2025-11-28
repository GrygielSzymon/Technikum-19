<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            line-height: 180%;
        }

        .error {
            color: red;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <?php
        $errBenzyna = $errKm = $errSpalanie = "";
        $benzyna = $km = $spalanie = "";
        $wynik = "";

        if (isset($_POST['send'])) {

            if (empty($_POST["benzyna"])) {
                $errBenzyna = "To pole jest wymagane";
            } else {
                $benzyna = $_POST["benzyna"];
                if (!filter_var($benzyna, FILTER_VALIDATE_FLOAT)) {
                    $errBenzyna = "Podaj liczbę zmiennoprzecinkową";
                }
            }

            if (empty($_POST['km'])) {
                $errKm = "To pole jest wymagane";
            } else {
                $km = $_POST['km'];
            }

            if (empty($_POST['avgBenzyna'])) {
                $errSpalanie = "To pole jest wymagane";
            } else {
                $spalanie = $_POST['avgBenzyna'];
                if (!filter_var($spalanie, FILTER_VALIDATE_FLOAT)) {
                    $errSpalanie = "Podaj liczbę zmiennoprzecinkową";
                }
            }

            if ($errBenzyna == "" && $errKm == "" && $errSpalanie == "") {
                
                $l = ($km / 100) * $spalanie;
                $koszt = $l * $benzyna;

                $wynik = "
                    <h2>Podsumowanie</h2>
                    <p>Koszt benzyny za 1L: $benzyna zł</p>
                    <p>Ilość kilometrów: $km km</p>
                    <p>Średnie spalanie: $spalanie L / 100km</p>
                    <p><b>Koszt przejazdu: ".number_format($koszt, 2)." zł</p>
                ";
            }
        }
?>

    <form method="post">
        <label>
            Koszt benzyny na 1L: <input type="text" name="benzyna">
            <span class="error"><?php echo $errBenzyna;?></span><br>
        </label>
        <label>
            ilość kilometrów: <input type="number" name="km">
            <span class="error"><?php echo $errKm;?></span><br>
        </label>
        <label>
            średnie spalanie: <input type="text" name="avgBenzyna">
            <span class="error"><?php echo $errSpalanie;?></span><br>
        </label>
        <input type="submit" name="send" value="prześlij">
    </form>
    <?php
    if($wynik != ""){
        echo $wynik;
    }
    ?>
</body>
</html>