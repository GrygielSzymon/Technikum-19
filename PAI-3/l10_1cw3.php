<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        li{
            line-height: 180%;
        }
    </style>
</head>
<body>
    <?php
    $dbserver = "localhost";
    $user = "root";
    $password = "";
    $dbName = "wazniak";
    $mysqli = mysqli_connect($dbserver,$user,$password,$dbName);
    $result = mysqli_query($mysqli, "SELECT p.ID_PRAC AS ID_PRACOWNIKA, p.NAZWISKO AS NAZWISKO_PRACOWNIKA, s.ID_PRAC AS ID_SZEFA, s.NAZWISKO AS NAZWISKO_SZEFA
        FROM pracownicy p
        INNER JOIN pracownicy s ON p.ID_SZEFA = s.ID_PRAC;");  
    echo "<ol>";
    while($row = mysqli_fetch_array($result, MYSQLI_ASSOC)){
        $id_prac = $row['ID_PRACOWNIKA'];
        $nazwisko = $row['NAZWISKO_PRACOWNIKA'];
        $id_szefa = $row['ID_SZEFA'];
        $nazwisko_szefa = $row['NAZWISKO_SZEFA'];
        echo "<li>";
        echo "<strong>ID Pracownika:</strong> $id_prac, <strong>Nazwisko pracownika:</strong> $nazwisko, <strong>ID Szefa:</strong> $id_szefa, <strong>Nazwisko szefa:</strong> $nazwisko_szefa<br>";
        echo "</li>";
    }
    echo "</ol>"; 
    mysqli_close($mysqli);
    ?>
</body>
</html>
