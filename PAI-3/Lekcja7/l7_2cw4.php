<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $groups = ["zespól1", "zespól2", "zespól3", "zespól4", "zespól5"];
        $songs = ["utwór1", "utwór2", "utwór3", "utwór4", "utwór5"];

        $comb = array_combine($groups, $songs);
        krsort($comb);
        echo "<pre>";
        print_r($comb);
        echo "<pre>";


        $comb["zespół6"] = "utwór6";
        asort($comb);
        foreach($comb as $grop => $song){
            echo $grop . ": " . $song . "<br>";
        }
    ?>
</body>
</html>