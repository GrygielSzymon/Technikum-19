<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Biblioteka publiczna</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <header>
        <h1>Biblioteka w Książkowicach Wielkich</h1>
    </header>

    <main>
        <section class="left">
            <h3>Polecamy dzieła autorów:</h3>
            <ol>
                <?php
                    $con = mysqli_connect("localhost", "root", "", "biblioteka");
                    $query1 = mysqli_query($con, "SELECT imie, nazwisko
                    FROM autorzy ORDER BY nazwisko ASC;");
                    while ($row = mysqli_fetch_row($query1)) {
                        echo "<li> $row[0] $row[1] </li>";
                    }
                ?>
            </ol>
        </section>

        <section class="center">
            <h3>ul. Czytelnicza 25, Książkowice&nbsp;Wielkie</h3>
            <p><a href="mailto:sekretariat@biblioteka.pl">Napisz  do  nas</a></p>
            <br>
            <img src="biblioteka.png" alt="książki">
        </section>
        <article class="right">
            <section class="rightTop">
            <h3>Dodaj czytelnika</h3>
            <form method="post">
                <label>
                    imię: <input type="text" name="name">
                </label>
                <br>
                <label>
                    nazwisko: <input type="text" name="surname">
                </label>
                <br>
                <label>
                    symbol: <input type="number" name="symbol">
                </label>
                <br>
                <button name="submit">DODAJ</button>
            </form>
        </section>

        <section class="rightBottom">
            <?php
                if (isset($_POST["submit"])) {
                    $imie = $_POST['name'];
                    $nazwisko = $_POST['surname'];
                    $symbol = $_POST['symbol'];
                    $q = "INSERT INTO czytelnicy(imie, nazwisko, kod) VALUES ('$imie',
                    '$nazwisko', '$symbol');";
                    mysqli_query($con, $q);
                    echo "Czytelnik: $imie $nazwisko został(a) dodany do bazy danych";
                }
                mysqli_close($con);
            ?>
        </section>
        </article>
    </main>

    <footer>
        <p>Projekt strony: JA</p>
    </footer>
</body>
</html>