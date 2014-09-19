<?php

$text = $_GET['text'];
$blacklist = $_GET['blacklist'];

$bl = preg_split("/\n/", $blacklist);

$pattern = "/[\w\_\-+]+@[\w\-]+\.[\w\-\.]+/";
preg_match_all($pattern, $text, $matches);


foreach ($matches[0] as $match) {
    $replacement = getReplacement($match, $bl);
}


function getReplacement($match, $bl){
    preg_match("/\..*/", $match, $domain)

    foreach ($bl as $item) {

        if (in_array($match, $bl)) {
            return str_repeat("*", strlen($match));
        } else {
            return "<a href=\"mailto:kinky_technician@yahoo.in\">$match</a>";
        }
    }
}
