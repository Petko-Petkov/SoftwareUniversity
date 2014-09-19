<?php

//$input =     "Java is an object-oriented programming language.
//PHP is a server-side scripting language.&#32;&#32;
//    HTML is the standard markup language used to create web pages.
//
//To define a table in HTML use &lt;table&gt;, &lt;td&gt; and &lt;tr&gt; tags.";
//$length = 50;

$input = $_GET['list'];
$length = $_GET['maxSize'];

$text = preg_split("/\n/", $input);

echo "<ul>";

for ($i = 0; $i < count($text); $i++) {
    $currRow = trim($text[$i]);
    if (strlen($currRow)>0) {
        echo "<li>".abbrText($currRow, $length)."</li>";

    } else {
        continue;
    }
}

echo "</ul>";

function abbrText($text, $length){
    $result = "";
    if (strlen($text) > $length){
        $result = htmlspecialchars(substr($text, 0, $length)."...");
        return $result;
    } else {
        return htmlspecialchars($text);
    }
}

?>