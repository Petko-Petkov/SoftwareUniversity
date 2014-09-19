<?php
session_start();

?>

<!DOCTYPE html>
<html>
    <head>
        <title>HTML Tags counter</title>
        <meta charset="utf-8"/>
    </head>

    <body>
        <form method="post">
            <label for="input">Enter HTML tags:</label><br/>
            <input type="text" name="input" id="input" />
            <input type="submit" name="submit" />
        </form>

    <?php

    $tags = array("a", "abbr", "address", "area", "article", "aside", "audio", "b", "base", "bdi", "bdo", "blockquote", "body", "br", "button", "canvas", "caption",
        "cite", "code", "col", "colgroup", "command", "datalist", "dd", "del", "details", "dfn", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption", "figure",
        "footer", "form", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header", "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label",
        "legend", "li", "link", "map", "mark", "menu", "meta", "meter", "nav", "noscript", "object", "ol", "optgroup", "option", "output", "p", "param", "pre", "progress",
        "q", "rp", "rt", "ruby", "s", "samp", "script", "section", "select", "small", "source", "span", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td",
        "textarea", "tfoot", "th", "thead", "time", "title", "tr", "track", "u", "ul", "var", "video", "wbr");

    if(!isset($_SESSION["score"]) || !isset($_SESSION["tagsScore"])){
        $_SESSION["score"] = 0;
        $_SESSION["tagsScore"] = $tags;
    }

    if ($_POST && isset($_POST["submit"])){
        $tag = mb_strtolower(trim($_POST["input"]));

        if (array_search($tag, $tags) === false) {
            echo "<div>Invalid HTML tag!</div>";
        } else {
            echo "<div>Valid HTML tag!</div>";

            if (array_search($tag, $_SESSION["tagsScore"])!== false){
                $_SESSION["score"]++;
                $key = array_search($tag, $tags);
                unset($_SESSION["tagsScore"][$key]);
            }
        }
    }

    echo "<div>Score:". $_SESSION["score"]."</div>";
    ?>
    </body>
</html>

<?php
/**
 * Created by PhpStorm.
 * User: Pecata
 * Date: 14-8-18
 * Time: 22:51
 */ 