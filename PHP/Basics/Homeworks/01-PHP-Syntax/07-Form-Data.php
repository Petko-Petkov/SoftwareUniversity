<!DOCTYPE html>
<html>
    <head>
        <title>Form Data</title>
        <meta charset="utf-8" />
        <style>
            form{
                display: block;
                width: 150px;
            }
        </style>
    </head>
    <body>

    <form method="post">
        <input type="text" name="Name" placeholder="Name" id="1"/>
        <input type="number" name="Age" placeholder="Age" id="Age"/>
        <label for="male"> <input type="radio" name="sex" value="male" id="male"/>Male</label><br/>
        <label for="female"><input type="radio" name="sex" value="female" id="female"/>Female</label>
        <input type="submit" name="submit" value="Изпращане"/>
    </form>
    <?php

        if(isset($_POST['submit'])){
            $name = $_POST['Name'];
            $age = $_POST['Age'];
            $sex = $_POST['sex'];
            echo "My name is $name. I am $age years old. I am $sex.";
        }


    ?>

    </body>
</html>