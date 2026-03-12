<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styl3.css">
    <title>Opinie klientów</title>
</head>
<body>
    <?php
        $mysql = mysqli_connect("localhost", "root", "", "hurtownia");
    ?>
    <header>
        <h1>Hurtownia spożywcza</h1>
    </header>
    <main>
        <h2>Opinie naszych klientów</h2>
        <?php
        $query2 = mysqli_query($mysql, "SELECT klienci.zdjecie, klienci.imie, opinie.opinia
        FROM klienci
        INNER JOIN opinie on klienci.id = opinie.Klienci_id
        INNER JOIN typy on klienci.Typy_id = typy.id
        WHERE klienci.Typy_id = 2 OR klienci.Typy_id = 3");
        while($row = mysqli_fetch_array($query2)) {
			echo "<div class='opinia'>
					<img src='$row[0]' alt='klient' />
					<blockquote>$row[2]</blockquote>
					<h4>$row[1]</h4>
				</div>";
		}

        ?>
    </main>
    
    <footer>
        <section>
            <h3>Współpracują z nam</h3>
            <a href="http://sklep.pl/">Sklep 1</a>
        </section>
        <section>
            <h3>Nasi top klienci</h3>
            <?php 
                $query1 = mysqli_query($mysql, "SELECT klienci.imie, klienci.nazwisko, klienci.punkty
                FROM klienci
                ORDER BY klienci.punkty DESC
                LIMIT 3");
                echo "<ol>";
                while($row2 = mysqli_fetch_array($query1)){
                echo "<li>$row2[0] $row2[1], $row2[2]pkt.</li>";
                }
                echo "</ol>";
            ?>
        </section>
        <section>
            <h3>Skontaktuj się</h3>
            <p>telefon: 111222333</p>
        </section>
        <section>
            <h3>Autor: 00000000</h3>
        </section>
    </footer>

    <?php
        mysqli_close($mysqli)
    ?>
</body>
</html>