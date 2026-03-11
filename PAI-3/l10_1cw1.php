<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $dbserver = "localhost";
    $user = "root";
    $password = "";
    $dbName = "wazniak";
    $mysqli = mysqli_connect($dbserver,$user,$password,$dbName);
    $result = mysqli_query($mysqli, "SELECT NAZWISKO, ID_ZESP FROM `pracownicy` WHERE ID_ZESP = 20 and (NAZWISKO LIKE 'M%' or NAZWISKO LIKE '%SKI')");  
    echo "<pre>";
    while($row = mysqli_fetch_array($result, MYSQLI_ASSOC)){
        foreach($row as $key=>$value) {
            echo $key.": ".$value." ";
        }
        echo "<br>";
    }
    
    echo "</pre>"; 
    mysqli_close($mysqli);
    ?>
</body>
</html>
