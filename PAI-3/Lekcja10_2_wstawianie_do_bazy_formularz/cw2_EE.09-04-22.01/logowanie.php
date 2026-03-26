<!DOCTYPE html>
<html lang="PL">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forum o psach</title>
    <link rel="stylesheet" href="styl4.css">
</head>

<body>
    <header>
        <h1>Forum wielbicieli psów</h1>
    </header>
    <main>
        <section class="left">
            <img src="obraz.jpg" alt="foksterier">
        </section>

        <div class="right">
            <section class="rightTop">
                <h2>Zapisz się</h2>
                <form method="post">
                    <label>
                        login: <input type="text" name="login">
                    </label>
                    <br>
                    <label>
                        hasło: <input type="password" name="pass">
                    </label>
                    <br>
                    <label>
                        powtórz hasło: <input type="password" name="passR">
                    </label>
                    <br>
                    <button type="submit">Zapisz</button>
                </form>
                <?php
                    $con = mysqli_connect("localhost", "root", "", "psy");

                    if (isset($_POST['login']) && isset($_POST['pass']) && isset($_POST['passR'])) {
                        $login = $_POST['login'];
                        $pass = $_POST['pass'];
                        $passR = $_POST['passR'];

                        $err = FALSE;

                        if ($login === "" || $pass === "" || $passR === "") {
                            echo "<p>Wypełnij wszystkie pola</p>";
                            $err = true;
                        }

                        elseif ($pass !== $passR) {
                            echo "<p>Hasła nie są takie same, konto nie zostało dodane</p>";
                            $err = true;
                        }

                        else {
                            $res = mysqli_query($con, "SELECT login FROM uzytkownicy;"); 
                            while ($tab = mysqli_fetch_row($res)) { 
                                if ($login == $tab[0]) { 
                                    echo "<p>login występuje w bazie danych, konto nie zostało dodane</p>"; 
                                    $err = TRUE; 
                                    break; 
                                } 
                            }
                        }

                    }
                ?>
            </section>

            <section class="rightBottom">
                <h2>Zapraszamy wszystkich</h2>
                <ol>
                    <li>właścicieli psów</li>
                    <li>weterynarzy</li>
                    <li>tych, co chcą kupić psa</li>
                    <li>tych, co lubią psy</li>
                </ol>
                <a href="regulamin.html">Przeczytaj regulamin forum</a>
            </section>
        </div>
    </main>

    <footer>
        Stronę wykonał: 000000000000
    </footer>

</body>

</html>