<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

    <?php
        function comment($ocena = 5) {
            switch ($ocena) {
                case 1:
                case 2:
                    echo "$ocena - Sporo pracy przed Tobą.<br>";
                    break;
                case 3:
                    echo "$ocena - Jeszcze trochę, a będzie ok.<br>";
                    break;
                case 4:
                case 5:
                case 6:
                    echo "$ocena - Okej.<br>";
                    break;
                default:
                    echo "Zła ocena";
                    break;
            }
        }
        comment(1);
        comment(4);
        comment(5);
        comment(3);
        comment(2);
        comment();
    ?>

</body>
</html>