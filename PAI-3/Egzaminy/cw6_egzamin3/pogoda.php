<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Prognoza pogody Warszawy</title>
    <link rel="stylesheet" href="styl2.css">
</head>
<body>
    <?php
        $serwer = "localhost";
        $user = "root";
        $password = "";
        $dbName = "egzamin1";
        $mysql = mysqli_connect($serwer, $user, $password, $dbName);
    ?>
    <header>
        <div class="bannerBlock"><img src="logo.png" alt="meteo"></div>
        <header class="bannerCenter"><h1>Prognoza dla Wrocławia</h1></header>
        <div class="bannerBlock"><p>maj, 2019 r.</p></div>
    </header>
    
    <main>
        <table>
            <tr>
                <th>DATA</th>
                <th>TEMPERATURA W NOCY</th>
                <th>TEMPERATURA W DZIEŃ</th>
                <th>OPADY [mm/h]</th>
                <th>CIŚNIENIE [hPa]</th>
            </tr>
            <?php
                $qr = "SELECT *
                        FROM pogoda
                        WHERE pogoda.miasta_id = 1
                        ORDER BY pogoda.data_prognozy ASC";
                $result = mysqli_query($mysql, $qr);
                while($row = mysqli_fetch_row($result)){
                    echo "<tr>
                            <td>$row[2]</td>    
                            <td>$row[3]</td>  
                            <td>$row[4]</td>  
                            <td>$row[5]</td>  
                            <td>$row[6]</td>
                          </tr>";

                }
            ?>
        </table>
    </main>

    <div class="blockMain">
        <div class="blockUnderMain"><img src="obraz.jpg" alt="Polska, Wrocław"></div>
        <div class="blockUnderMain"><a href="kwerendy.txt">Pobierz kwerendy</a></div>
    </div>

    <footer><p>Stronę wykonał: 111222333</p></footer>
</body>
</html>