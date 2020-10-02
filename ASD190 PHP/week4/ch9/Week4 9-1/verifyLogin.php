<?php
session_start();
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>

<body>
    <h1>College Internship</h1>
    <h2>Verify Intern Login</h2>
    <?php
    $errors = 0;
    $DBConnect = @mysqli_connect("localhost", "root", "");
    if ($DBConnect === FALSE) {
        echo "<p>Unable to connect to the database server. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
        ++$errors;
    } else {
        $DBName = "internships";
        $result = @mysqli_select_db($DBConnect, $DBName);
        if ($result === FALSE) {
            echo "<p>Unable to select the database. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
            ++$errors;
        }
    }

    if (!isset($_POST['email']) || !isset($_POST['password'])) {
        echo "<p>You have not logged in or registered. Please return to the <a href='InternLogin.php'>Registration / Log In page</a>.</p>";
        ++$errors;
    } else {
        $TableName = "interns";
        if ($errors == 0) {
            $SQLstring = "SELECT internID, first, last FROM $TableName WHERE email='" . stripslashes($_POST['email']) . "' and password_md5='" . md5(stripslashes($_POST['password'])) . "'";
            $QueryResult = @mysqli_query($DBConnect, $SQLstring);
            if (mysqli_num_rows($QueryResult) == 0) {
                echo "<p>The e-mail address/password " . " combination entered is not valid.</p>\n";
                ++$errors;
            } else {
                $Row = mysqli_fetch_assoc($QueryResult);
                $InternID = $Row['internID'];
                $_SESSION['internID'] = $InternID;
                $InternName = $Row['first'] . " " . $Row['last'];
                echo "<p>Welcome back, $InternName!</p>\n";
            }
        }
        if ($errors > 0)
            echo "<p>Please use your browser's BACK button to return to the form and fix the errors indicated.</p>\n";

        if ($errors == 0) {
            echo "<form method='post' action='AvailableOpportunities.php?" . SID . "'>\n";
            echo "<input type='hidden' name='internID' value='$InternID'>\n";
            echo "<input type='submit' name='submit' value='View Available Opportunities'>\n";
            echo "</form>\n";
        }
    }


    ?>
</body>

</html>