<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>


    <?php
        function textFormatting($text, $color = 'blue', $font = 'Arial', $size = '24px') {
            echo "<span style=\"color: $color; font-family: $font; font-size: $size;\">$text</span><br>";
        }

        textFormatting('Tekst');
        textFormatting('A jak okaże się, że nie działa?', 'green', 'Verdana', '10px');
        textFormatting('Ależ działa!!!', 'red', 'Scali', '20px');
    ?>

</body>
</html>