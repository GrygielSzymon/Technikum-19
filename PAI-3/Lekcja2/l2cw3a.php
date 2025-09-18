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
    echo '<table>';
    echo '<tr>';
    echo '<th></th>';
    echo '<th>Kolumna 1</th>';
    echo '<th>Kolumna 2</th>';
    echo '</tr>';
    echo '<tr>';
    echo '<th>Wiersz 1</th>';
    echo '<td>Kom11</td>';
    echo '<td>Kom12</td>';
    echo '</tr>';
    echo '<tr>';
    echo '<th>Wiersz 2</th>';
    echo '<td>Kom21</td>';
    echo '<td>Kom22</td>';
    echo '</tr>';
    echo '</table>';
?>

</body>
</html>
