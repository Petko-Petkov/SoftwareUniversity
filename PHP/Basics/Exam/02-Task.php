    <?php

    
    $input = $_GET['html'];


    $text = preg_split("/\n/", $input);
    $matches = [];
    $pattern = "/<\!--\s*(.+)\s*-->/";
    $result = preg_match_all($pattern, $input, $matches);
    $validTags = [];

    for ($i = 0; $i < count($matches[1]); $i++) {
        if (chkValidTags(trim($matches[1][$i]))){
            array_push($validTags, trim($matches[1][$i]));
        }
    }

    $patternDeleteDiv = "/div\s*/";
    $patternReplaceID = "/\s*id\s*=\s*\".+?\"\s*/";
    $patternReplaceClass = "/\s*class\s*=\s*\".+?\"\s*/";

    for ($i = 0; $i < count($text); $i++) {
        $currRow = $text[$i];

        if (strpos($currRow,"<div") !== false) {
            replaceDivTag($currRow);
            if (strpos($currRow, "id") !==false){
                $currRow = replaceID($currRow, $patternReplaceID);
            } elseif (strpos($currRow, "class") !==false ){
                $currRow = replaceID($currRow, $patternReplaceClass);
            }
        } else if (strpos($currRow,"</div") !== false){
            $currRow = replaceClosingDivs($currRow, $pattern);
        }


        echo validateOutput($currRow);
    }

    function validateOutput($row){
        $result = explode(" ", trim($row));

        for ($i = 0; $i < count($result)-1; $i++) {
            $temp = $result[$i];
        }

        if ($result[$i+1]!= ">"){
            return $row;
        } else {
            return implode("", $result)."\r\n";
        }
    }

    function chkValidTags ($match){
        switch($match){
            case "main": return true;
            case "header" : return true;
            case "nav": return true;
            case "article" : return true;
            case "section": return true;
            case "aside" : return true;
            case "footer" : return true;
            default : return false;
        }
    }

    function replaceID($row, $replacer){

            $row = preg_replace($replacer, " ", $row);

        return $row;
    }

    function replaceDivTag (&$rowText) {
        $matchesTags = [];
        $currPatternID = "/\s+id\s*=\s*\"(.+?)\"\s*/";
        $currPatternClass = "/\s+class\s*=\s*\"(.+?)\"\s*/";
        if (strpos($rowText,"class") !== false) {
            preg_match($currPatternClass, $rowText, $matchesTags);
            $rowText = str_replace("div", trim($matchesTags[1]), $rowText);
            return $rowText;
        } else {
            preg_match($currPatternID, $rowText, $matchesTags);
            $rowText = str_replace("div", trim($matchesTags[1]), $rowText);
            return $rowText;
        }


    }

    function replaceClosingDivs (&$rowTextOne, $currPattern) {
        $matchesTags = [];
        preg_match($currPattern, $rowTextOne, $matchesTags);

        $rowTextOne = str_replace("div", trim($matchesTags[1]), $rowTextOne);
        $index = strpos($rowTextOne, ">");
        return substr($rowTextOne, 0, $index+1)."\r\n";
    }

    ?>