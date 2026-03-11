<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        table,th,tr,td{
            border: 1px,solid,black;
            border-collapse:collapse;
        }
    </style>
</head>
<body>
    <table>
        <tr>
            <th>Nazwisko</th>
            <th>Etat</th>
            <th>Nazwa zespołu</th>
            <th>Adres</th>
        </tr>
        <?php
            $server = "localhost";
            $user = "root";
            $password = "";
            $dbname = "wazniak";
            $mysqli = mysqli_connect($server, $user, $password, $dbname)
                or die ("Brak połączenia z serwerem.");
            echo "Nawiązano połaczenie z bazą.";
            $result = mysqli_query($mysqli, "SELECT pracownicy.NAZWISKO , pracownicy.ETAT , zespoly.NAZWA , zespoly.ADRES 
            FROM pracownicy
            INNER JOIN zespoly on pracownicy.ID_ZESP = zespoly.ID_ZESP
            WHERE zespoly.ADRES LIKE 'piotrowo%';");
            while($row = mysqli_fetch_array($result, MYSQLI_ASSOC)){
                echo "<tr>";
                foreach($row as $key => $value){
                    echo "<td>" . $value . "</td>";
                }
                echo "</tr>";
            }
            mysqli_close($mysqli);
    
        ?>
    </table>
</body>
</html>
