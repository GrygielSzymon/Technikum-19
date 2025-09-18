<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        img{
            height: 300px;
        }
    </style>
</head>
<body>

    <?php
    echo<<<KONIEC
    <ol>
        <li><img src = 'grafika/obraz1.jpg'></li>
        <li><img src = 'grafika/obraz2.jpg'></li>
        <li><img src = 'grafika/obraz3.jpg'></li>
    </ol>
    KONIEC;
    ?>

</body>
</html>