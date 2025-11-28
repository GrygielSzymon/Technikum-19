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
    </style>
</head>
<body>
    <?php 
        if (isset($_POST('send'))) {
            $surname   = $_POST['surname'];
            $firstname = $_POST['firstname'];
            $email     = $_POST['email'];
            
}

?>
    ?>
    <form method="post">
        <label>
            Nazwisko: <input type="text" name="surName">
        </label>
        <br>
        <label>
            Imię: <input type="text" name="firstName">
        </label>
        <br>
        <label>
            e-mail: <input type="text" name="email">
        </label>
        <br>
        <label>Oblicz 5*2</label>
        <select>
            <option disabled selected>Wybierz</option>
            <option>25</option>
            <option>153</option>
            <option>10</option>
        </select>
        <br>
        <label>Oblicz 5 * 4 * 1</label><br>
        <input type="radio" value="30" id="radio1" name="questionRadio"><label for="radio1">30</label><br>
        <input type="radio" value="20" id="radio2" name="questionRadio"><label for="radio2">20</label><br>
        <input type="radio" value="100" id="radio3" name="questionRadio"><label for="radio3">100</label>
        <br>
        <label>Oblicz 16/32</label><br>
        <label>
            <input type="checkbox" name="questioncheckbox[]" value="1/2">1/2
        </label>
        <br>
        <label>
            <input type="checkbox" name="questioncheckbox[]" value="2/4">2/4
        </label>
        <br>
        <label>
            <input type="checkbox" name="questioncheckbox[]" value="0.5">0,5
        </label>

        <button type="submit" name="send>Ok!</button>
    </form>
</body>
</html>