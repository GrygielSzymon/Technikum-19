<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <title>Formularz komentarza</title>
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
        $errP = $errComm = "";
        $pseudonim = $komentarz = "";

        if (isset($_POST['send'])) {

            if (empty($_POST["pseudonim"])) {
                $errP = "Uzupełnij pole";
            } else {
                $pseudonim = $_POST["pseudonim"];
            }

            if (empty($_POST["comm"])) {
                $errComm = "Uzupełnij pole";
            } else {
                $komentarz = $_POST["comm"];
            }
        }
?>

    <h2>Dodaj komentarz</h2>

    <form method="post">
        <label>Pseudonim:</label><br>
        <input type="text" name="pseudonim">
        <span class="error">
            <?php echo $errP; ?>
        </span>
        <br><br>

        <label>Komentarz:</label><br>
        <textarea cols="40" rows="5" name="comm"></textarea>
        <span class="error"><?php echo $errComm; ?></span>
        <br>

        <input type="submit" name="send" value="Wyślij">
    </form>
        <?php
        if (isset($_POST['send'])){
            if($errComm == "" && $errP == ""){
                echo "Pseudonim: $pseudonim<br>";
                echo "Komentarz: <strong>$komentarz</strong><br>";
                echo "Komentarz: " . htmlspecialchars($komentarz);
            }
        }
        ?>
</body>

</html>