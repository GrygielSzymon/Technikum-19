<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        table, th, td{
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    <table>
        <?php
        for ($height = 1; $height <= 10; $height++) {
        echo "<tr>\n";

        for ($width = 1; $width <= 10; $width++) {
        echo "<td>";
        echo $width * $height;
        echo "</td>\n";
        }

        echo "</tr>\n";
        }
        ?>
</table>
</body>
</html>