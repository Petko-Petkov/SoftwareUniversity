<?php
$firstInput = ['Gosho', '0882-321-423', '24', 'Hadji Dimitar'];
$secondInput = ['Pesho', '0884-888-888', 67, 'Suhata Reka'];
?>

<!DOCTYPE html>
<html>
    <head>
        <title>HTML Table</title>
        <meta charset="utf-8"/>
        <link rel="stylesheet" href="styles/06-styles.css"/>
    </head>
    <body>
        <table>
            <tr>
                <td class="def">Name</td>
                <td><?php echo $firstInput[0]?></td>
            </tr>
            <tr>
                <td class="def">Phone number</td>
                <td><?php echo $firstInput[1]?></td>
            </tr>
            <tr>
                <td class="def">Age</td>
                <td><?php echo $firstInput[2] ?></td>
            </tr>
            <tr>
                <td class="def">Address</td>
                <td><?php echo $firstInput[3] ?></td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="def">Name</td>
                <td><?php echo $secondInput[0]?></td>
            </tr>
            <tr>
                <td class="def">Phone number</td>
                <td><?php echo $secondInput[1]?></td>
            </tr>
            <tr>
                <td class="def">Age</td>
                <td><?php echo $secondInput[2] ?></td>
            </tr>
            <tr>
                <td class="def">Address</td>
                <td><?php echo $secondInput[3] ?></td>
            </tr>
        </table>
    </body>
</html>