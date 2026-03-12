<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Prognoza pogody Wrocław</title>
    <link rel="stylesheet" href="styl2.css">
</head>
<body>
    <?php
        $mysql = mysqli_connect("localhost", "root", "", "prognoza");
    ?>
    <header>
        <section class="banerLewy">
            <img src="logo.png" alt="meteo">
        </section>

        <section class="banerCenter">
            <h1>Prognoza dla Wrocławia</h1>
        </section>

        <section class="banerPrawy">
            <p>maj, 2019 r.</p>
        </section>
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

    <section id="lewy">
		<img src="obraz.jpg" alt="Polska, Wrocław" />
    </section>
	<section id="prawy">
		<a href="kwerendy.txt">Pobierz kwerendy</a>
    </section>

    <footer>
        <p>Stronę wykonał: 000000000</p>
    </footer>
    
    <?php
        mysqli_close($mysqli)
    ?>
</body>
</html>