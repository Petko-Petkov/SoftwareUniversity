
<?php

$input = $_GET['blacklist'];
$blackList = explode("\n", $input);

for ($i = 0; $i < count($blackList); $i++) {
    $blackList[$i] = trim($blackList[$i]);
}

$text = $_GET['text'];

$textArr = explode(' ', $text);

$blackMails = array();

for ($i = 0; $i < count($textArr); $i++) {
    $temp = mailChecker($textArr[$i]);
    if ($temp[0]) {

        $var = true;
        for ($y = 0; $y < count($blackList); $y++) {

            if ($temp[0] == $blackList[$y] || $temp[1] == $blackList[$y]) {
                array_push($blackMails, $temp[0]);
                $var = false;
            }
        }

        if($var) {
            $text = str_replace($temp[0], "<a href=\"mailto:$temp[0]\">".$temp[0]."</a>", $text);
        }
    }
}

for ($i = 0; $i < count($blackMails); $i++) {
    $text = str_replace($blackMails[$i], str_repeat("*", strlen($blackMails[$i])), $text);
}

function mailChecker($str) {

    $stage = 1;
    $counter = 0;
    $domain = 0;
    $result = array();

    for ($i = 0; $i < strlen($str); $i++) {

        $currChar = $str[$i];

        switch($stage) {
            case 1 :
                if ($currChar == '@'){
                    if ($counter == 0){
                        return $result[0]=false;
                    }
                    $stage ++;
                    $counter = 0;
                } else if (!(ctype_alpha($currChar)
                    || is_numeric($currChar)
                    || $currChar == "+"
                    || $currChar == "-"
                    || $currChar == "_")) {

                    return $result[0] = false;

                };
                break;
            case 2 :
                if ($currChar == '.'){
                    if ($counter == 0){
                        return $result[0]=false;
                    }
                    $stage ++;
                    $counter = 0;
                    $domain = $i;
                } else if (!(ctype_alpha($currChar)
                    || is_numeric($currChar)
                    || $currChar == "–")){

                    return $result[0] = false;
                };
                break;
            case 3 :
                if (!(ctype_alpha($currChar)
                    || is_numeric($currChar)
                    || $currChar == "-"
                    || $currChar == ".")) {

                    return $result[0] = false;

                };
                break;
        }

        $counter++;

    }

    if ($counter == 0 || $stage < 3 ) {
        return $result[0] = false;
    } else {
        $result[0] = $str;
        $result[1] = "*".substr($str, $domain);
        return $result;
    }

}
echo "<p>".$text."</p>";

?>