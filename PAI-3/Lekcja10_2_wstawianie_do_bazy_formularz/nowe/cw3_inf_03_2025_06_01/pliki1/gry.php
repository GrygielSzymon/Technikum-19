<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gry komputerowe</title>
    <link rel="stylesheet" href="styl.css"> 
</head>
<body>
    <header>
        <h1>Ranking gier komputerowych</h1>
    </header>

    <main>
        <section class="left">
            <h3>Top 5 gier w tym miesiącu</h3>

            <ul>
                <?php
                    $con = mysqli_connect("localhost", "root", "", "gry");
                    $query = "SELECT nazwa, punkty FROM gry ORDER BY punkty DESC LIMIT 5;";
                    $result = mysqli_query($con, $query);
                    while ($row = mysqli_fetch_array($result)) {
                        echo "<li>{$row['nazwa']}  <span class='points'>{$row['punkty']}</span></li>";
                    }   
                ?>
            </ul>
            
            <h3>Nasz sklep</h3>
            <a href="http://sklep.gry.pl">Tu kupisz gry</a>

            <h3>Stronę wykonał</h3>
            <p>1344123413432</p>
        </section>

        <section class="center">
            <?php
            $query = "SELECT id, nazwa, zdjecie FROM gry;";
            $result = mysqli_query($con, $query);
            while ($row = mysqli_fetch_array($result)) {
                echo "<div class='gra'>
                        <img src='{$row['zdjecie']}' alt='{$row['nazwa']}' title='{$row['id']}'>
                        <p>{$row['nazwa']}</p>
                    </div>";
            }
            ?>
        </section>

        <section class="right">
            <h3>Dodaj nową grę</h3>
            <form action="gry.php"  method="post">
                <label>
                    Nazwa:
                    <br>
                    <input name="name" type="text">
                </label>
                <label>
                    Opis:
                    <br>
                    <input name="disc" type="text">
                </label>
                <label>
                    cena:
                    <br>
                    <input name="price" type="text">
                </label>
                <label>
                    zdjęcie:
                    <br>
                    <input name="photo" type="text">
                </label>
                <button type="submit" name="add">DODAJ</button>
            </form>
            <?php
            if (isset($_POST["dodaj"]) && !empty($_POST["nazwa"])) {
                $nazwa = $_POST["nazwa"];
                $opis = $_POST["opis"];
                $cena = $_POST["cena"];
                $zdjecie = $_POST["zdjecie"];
                $query = "INSERT INTO gry VALUES (NULL, '$nazwa', '$opis', 0, $cena, '$zdjecie');";
                mysqli_query($con, $query);
                header("location: gry.php");
            }
            ?>      
        </section>
    </main>

    <footer>
        <form action="gry.php"  method="post">
            <input type="text"> <button type="submit" name="show">Pokaż opis</button>
        </form>
         <?php
        if (isset($_POST["pokaz"]) && !empty($_POST["id"])) {
            $query = "SELECT nazwa, LEFT(opis, 100) AS opis, punkty, cena FROM gry WHERE id = {$_POST['id']};";
            $result = mysqli_query($con, $query);
            while ($row = mysqli_fetch_array($result)) {
                echo "<h2>{$row['nazwa']}, {$row['punkty']} punktów, {$row['cena']} zł</h2>
                <p>{$row['opis']}</p>";
            }
        }
        mysqli_close($con);
        ?>
    </footer>
</body>
</html>