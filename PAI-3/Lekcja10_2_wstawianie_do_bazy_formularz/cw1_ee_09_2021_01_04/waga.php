<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styl4.css">
    <title>Twój wskaźnik BMI</title>
</head>

<body>
    <?php
        $mysqli = mysqli_connect("localhost", "root", "", "egzamin");
    ?>
    <header>
        <section class="baner">
            <h2>Oblicz wskaźnik BMI</h2>
        </section>

        <section class="banerLogo">
            <img src="wzor.png" alt="liczymy BMI">
        </section>
    </header>

    <article class="leftRight">
        <section class="left">
            <img src="rys1.png" alt="zrzuć kalorie!">
        </section>

        <section class="right">
            <h1>Podaj dane</h1>
            <form method="post">
                <label>
                    Waga: <input type="number" name="waga">
                </label>
                <br>
                <label>
                    Wzrost[cm]: <input type="number" name="wzrost">
                </label>
                <br>
                <button type="submit">Licz BMI i zapisz wynik</button>
            </form>
            <?php
                if (!empty($_POST["waga"]) && !empty($_POST["wzrost"])) {
                    $waga = $_POST["waga"];
                    $wzrost = $_POST["wzrost"];
                    $bmi = $waga / ($wzrost * $wzrost) * 10000;
                    if($bmi > 0 && $bmi < 19) $przedzial = 1;
                    if($bmi > 19 && $bmi < 26) $przedzial = 2;
                    if($bmi > 26 && $bmi < 31) $przedzial = 3;
                    if($bmi > 31 && $bmi < 100) $przedzial = 4;
                    echo "Twoja waga: $waga; Twój wzrost: $wzrost<br/>BMI wynosi: $bmi";
                    $data = DATE("Y-m-d");
                    mysqli_query($mysqli, "INSERT INTO wynik VALUES (NULL, $przedzial, '$data', $bmi);");
                }
            ?>
        </section>
    </article>

    <main>
        <table>
            <tr>
                <th>lp.</th>
                <th>Interpretacja</th>
                <th>zaczyna się od...</th>
            </tr>
            <?php
                $result = mysqli_query($mysqli, "SELECT id, informacja, wart_min FROM bmi;");
                while($tab = mysqli_fetch_row($result)) {
				    echo "<tr><td>$tab[0]</td><td>$tab[1]</td><td>$tab[2]</td></tr>";
			    }
            ?>
        </table>
    </main>

    <footer>
        <p>Autor: 000000000</p>
        <a href="kw2.jpg">Wynik działania kwerendy 2</a>
    </footer>
    <?php
        mysqli_close($mysqli);
    ?>
</body>

</html>