<!DOCTYPE html>
<html>
    <head>
        <title>Most frequent tag</title>
        <meta charset="utf-8" />
    </head>
    <body>
        <form method="post">
            <input type="text" name="input" id="textField" />
            <input type="submit" name="submit" />
        </form>

        <?php

        if($_POST && isset($_POST['submit'])){
        $tags = explode(', ', $_POST['input']);
        $arr = array_count_values($tags);
        $max = array_search(max($arr), $arr);
        arsort($arr);

        foreach ($arr as $key => $value) {
            echo "$key : $value times" . "<br/>";
        }

        echo "Most frequent word is: $key";
        }

        ?>
    </body>
</html>