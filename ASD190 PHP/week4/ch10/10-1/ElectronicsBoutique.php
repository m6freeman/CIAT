<?php
session_start();
require_once("class_OnlineStore.php");
$storeID = "ELECBOUT";
$storeInfo = array();
if (class_exists("OnlineStore")) 
{
    if (isset($_SESSION['currentStore'])) $Store = unserialize($_SESSION['currentStore']);
    else $Store = new OnlineStore();
    $Store->setStoreID($storeID);
    $storeInfo = $Store->getStoreInformation();
    $Store->processUserInput();
}
else
{
    $ErrorMsgs[] = "The OnlineStore class is not available!";
    $Store = null;
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title><?php echo $storeInfo['name']; ?></title>
    <link rel="stylesheet" type="text/css" href="<?php echo $storeInfo['css_file'] ?>">
</head>

<body>
    <h1><?php echo htmlentities($storeInfo['name']); ?></h1>
    <h2><?php echo htmlentities($storeInfo['description']); ?></h2>
    <p><?php echo htmlentities($storeInfo['welcome']); ?></p>



    <?php

    $Store->getProductList();
    $_SESSION['currentStore'] = serialize($Store);

    // if ($Store != null) echo "<p>Successfully instantiated an object of the OnlineStore class.</p>\n";

    // if (count($ErrorMsgs) == 0) {
    //     $SQLstring = "SELECT * FROM inventory WHERE storeID='COFFEE'";
    //     $QueryResult = $DBConnect->query($SQLstring);
    //     if ($QueryResult == false) $ErrorMsgs[] = "<p>Unable to perform the query. <p> Error code " . $DBConnect->errno . " : " . $DBConnect->connect_error . "</p>\n";
    //     else {
    //         echo "<table width='100%'>\n";
    //         echo "<tr><th>Product</th><th>Description</th>";
    //         echo "<th>Price Each</th></tr>\n";
    //         while (($Row = $QueryResult->fetch_assoc()) != NULL) {
    //             echo "<tr><td>" . htmlentities($Row["name"]) . "</td>\n";
    //             echo "<td>" . htmlentities($Row["description"]) . "</td>\n";
    //             printf("<td>$%.2f</td></tr>\n", $Row["price"]);
    //         }
    //         echo "</table>";
    //         $_SESSION["currentStore"] = serialize($Store);
    //     }
    // }

    // if (count($ErrorMsgs)) foreach ($ErrorMsgs as $Msg) echo "<p>" . $Msg . "</p>\n";
    ?>
</body>



</html>