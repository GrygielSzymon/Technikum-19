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
    <?php

        echo<<<KONIEC

        <table>
            <tr>
                <th></th>
                <th>Kolumna 1</th>
                <th>Kolumna 2</th>
            </tr>
            <tr>
                <th>Wiersz 1</th>
                <td>Kom11</td>
                <td>Kom12</td>
            </tr>
            <tr>
                <th>Wiersz 2</th>
                <td>Kom21</td>
                <td>Kom22</td>
            </tr>
        </table>
        
        KONIEC;

    ?>
</body>
</html>