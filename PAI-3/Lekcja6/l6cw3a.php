<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Formatowanie tekstu - parametry</title>
</head>
<body>

    <?php
        function textFormat($text, $color, $font, $size) {
            echo "<p style='color: $color; font-family: $font; font-size: $size;'>$text</p>";
        }

        formatujTekst("Ale jak okaże się, że nie działa?", "red", "Times New Roman", "24px");
        formatujTekst("Ależ działa!!!", "green", "Courier New", "18px");
    ?>

</body>
</html>