<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

    <?php
        $text = "
        Ooo, ale jazz!  
        Hardkorowo pada deszcz  
        Tak na maksa wieje też  
        Ja łagodnie uśmiechnięta  
        Błyska gdzieś  
        Na mej dłoni czuję dreszcz  
        Moje oczy błyszczą też  
        Ja łagodnie uśmiechnięta  
        Ooooo, hardkorowo pada deszcz  
        Ja łagodnie uśmiechnięta";
        
        //a
        $textPrint = nl2br($text);
        //b
        $charCount = strlen($text);
        $wordCount = str_word_count($text);
        $charFormatted = number_format($charCount, 2, ',', ' ');
        $wordFormatted = number_format($wordCount, 3, ',', ' ');
        //c
        $pos = strpos($text, "deszcz");
        $textToDeszcz = substr($text, 0, $pos + strlen("deszcz"));
        //d
        $strpos = strpos($text, "ą");
        if ($strpos == TRUE) {
            $message = "Znak 'ą' występuje w tekście.";
        }
        else {
            $message = "Znak 'ą' nie występuje w tekście.";
        }
        //e
        $last24 = substr($text, -24);
        //f
        $lines = explode("\n", $text);
        $lastText = trim(end($lines));
        $JPos = strrpos($text, $lastText);
        $textFromJ = substr($text, $JPos);
        //g
        $replacing = str_replace("łagodnie", "krzywo", $text);
        $replacingPrint = nl2br($replacing);
        //h
        $modifiedText = str_replace("Ooo, ", "", $text);
        //i
        




        echo <<<END
            <h1>Zadania 1.a</h1>
                $textPrint
            <h1>Zadania 1.b</h1>
                Tekst składa się z $charFormatted znaków oraz $wordFormatted słów
            <h1>Zadania 1.c</h1>
                $textToDeszcz
            <h1>Zadania 1.d</h1>
                $message
            <h1>Zadania 1.e</h1>
                $last24
            <h1>Zadania 1.f</h1>
                Ostatnia linijka: $lastText <br>
                Pozycja ostatniej litery "J" to: $JPos
            <h1>Zadania 1.g</h1>
                $replacingPrint
            <h1>Zadania 1.h</h1>
                <pre>$modifiedText</pre>
            <h1>Zadania 1.i</h1>

            <h1>Zadania 1.j</h1>

            <h1>Zadania 1.k</h1>

            <h1>Zadania 1.l</h1>

            <h1>Zadania 1.m</h1>

            <h1>Zadania 1.n</h1>
            END;
    ?>

</body>
</html>