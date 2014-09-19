<!DOCTYPE html>
<?php

if(isset($_GET['tags'])){
    $tagsStr = explode(', ', $_GET['tags']);
    $result = '<div class="result">';

    for ($i = 0; $i < count($tagsStr); $i++) {
        $result .= "$i: $tagsStr[$i]" . '<br/>';
    }
}

?>
<html>
    <head>
        <title>Print tags</title>
        <meta charset="utf-8" />
    </head>
    <body>
        <form method="get" />
            <input type="text" name="tags"/>
            <input type="submit" name="submit" value="Get Tags"/>
        </form>

        <?php

        if(isset($result)){
            echo($result);
        }

        ?>
    </body>
</html>
<?php



?>