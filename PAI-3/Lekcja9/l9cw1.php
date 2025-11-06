<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1><strong>Wybór koloru strony</strong></h1>
    <form method="post">
        <select name="color">
            <option value="white">Biały</option>
            <option value="red">Czerwony</option>
            <option value="blue">Niebieski</option>
            <option value="green">Zielony</option>
            <option value="pink">Różowy</option>
            <option value="orange">Pomarańczowy</option>
        </select>
        <button type="submit" name="send">Zmień kolor strony</button>
    </form>
    <?php
        if (isset($_POST['send'])) {
            if(isset($_POST['color']) && $_POST['color'] == 'white') 
            {    
                echo 'white';
            }
            if(isset($_POST['color']) && $_POST['color'] == 'red') 
            {    
                echo 'selredected';
            }
            if(isset($_POST['color']) && $_POST['color'] == 'blue') 
            {    
                echo 'blue';
            }
        }
    ?>
</body>
</html>