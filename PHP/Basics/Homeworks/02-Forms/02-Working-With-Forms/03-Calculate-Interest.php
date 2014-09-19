<!DOCTYPE html>
<html>
    <head>
        <title>Calculate interest</title>
        <meta charset="utf-8" />
    </head>

    <body>
        <form method="post">
            <label for="amount">Enter amount</label>
            <input type="text" name="amount" id="amount"/> <br/>
            <input type="radio" name="currency" id="USD" />
            <label for="USD">USD</label>
            <input type="radio" name="currency" id="EUR" />
            <label for="EUR">EUR</label>
            <input type="radio" name="currency" id="BGN"/>
            <label for="BGN">BGN</label> <br/>
            <label for="interestAmount">Compound Interest Amount</label>
            <input type="text" name="interestAmount" id="interestAmount"/> <br/>
            <select name="period" id="period">
                <option value="6">6 months</option>
                <option value="12">12 months</option>
                <option value="24">24 months</option>
                <option value="60">60 months</option>
            </select>
            <input type="submit" value="Calculate" name="submit"/>
        </form>
        <?php

        if($_POST && isset($_POST["submit"])){

            $amount = $_POST["amount"];
            $currency = $_POST["currency"];
            $period = $_POST["period"];
            $interest = $_POST["interestAmount"];

            if(is_numeric($amount) && is_numeric($period) && is_numeric($interest)){
                $years = $period / 12;
                $result = $amount * pow(1 + ($interest / 100) / 12, 12 * $years);

                echo formatCurrency($result, $currency);
            }
        }

        function formatCurrency($amount, $currency){
            $result = round($amount, 2);

            switch ($currency){
                case "USD" :
                    return "$".$result;
                case "EUR" :
                    return "€".$result;
                case "BGN" :
                    return $result . "лв.";
                default:
                    return $result;
            }
        }

        ?>
    </body>

</html>
