<html xmlns="http://www.w3.org/1999/xhtml">
    <head><title>Sign Guest Book</title>
	<style type="text/css">
        .error {
            text-align: center;
            color: red;
            -webkit-animation: fadein 2s; /* Safari, Chrome and Opera > 12.1 */
            -moz-animation: fadein 2s; /* Firefox < 16 */
            -ms-animation: fadein 2s; /* Internet Explorer */
            -o-animation: fadein 2s; /* Opera < 12.1 */
            animation: fadein 2s;

        }

        @keyframes fadein {
            from {
                opacity: 0;
            }

            to {
                opacity: 1;
            }
        }

        /* Firefox < 16 */
        @-moz-keyframes fadein {
            from {
                opacity: 0;
            }

            to {
                opacity: 1;
            }
        }

        /* Safari, Chrome and Opera > 12.1 */
        @-webkit-keyframes fadein {
            from {
                opacity: 0;
            }

            to {
                opacity: 1;
            }
        }

        /* Internet Explorer */
        @-ms-keyframes fadein {
            from {
                opacity: 0;
            }

            to {
                opacity: 1;
            }
        }

        /* Opera < 12.1 */
        @-o-keyframes fadein {
            from {
                opacity: 0;
            }

            to {
                opacity: 1;
            }
        }

        .loginContainer {
            animation: shake 0.82s cubic-bezier(.36,.07,.19,.97) both;
            transform: translate3d(0, 0, 0);
            backface-visibility: hidden;
            perspective: 1000px;
        }

        @keyframes shake {
            10%, 90% {
                transform: translate3d(-1px, 0, 0);
            }

            20%, 80% {
                transform: translate3d(2px, 0, 0);
            }

            30%, 50%, 70% {
                transform: translate3d(-4px, 0, 0);
            }

            40%, 60% {
                transform: translate3d(4px, 0, 0);
            }
        }

        
	</style>
	</head>
    <body>
		<div class="container">
			<?php

			if (empty($_POST['first_name']) || empty($_POST['last_name']))
			{
				include('guestbook.html');
				echo "<p class=\"error\"> <i>You must enter your first and last name! Please try again.</i></p>";
			}
			else
			{
				$DBConnect = @mysqli_connect("localhost", "root", "");
				if ($DBConnect === FALSE)
					echo "<p>Unable to connect to the database server.</p>"	. "<p>Error code " . mysqli_errno() . ": " . mysqli_error() . "</p>";
				else
				{
					$DBName = "guestbook";
					if (!@mysqli_select_db($DBConnect, $DBName))
					{
						$SQLstring = "CREATE DATABASE $DBName";
						$QueryResult = @mysqli_query($DBConnect, $SQLstring);
						if ($QueryResult === FALSE)
							echo "<p>Unable to execute the query.</p>" . "<p>Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>";
						else
							echo "<p>You are the first visitor!</p>";
					}
					mysqli_select_db($DBConnect, $DBName);
					$TableName = "visitors";
					$SQLstring = "SHOW TABLES LIKE '$TableName'";
					$QueryResult = @mysqli_query($DBConnect, $SQLstring);
					if (@mysqli_num_rows($QueryResult) == 0)
					{
						$SQLstring = "CREATE TABLE $TableName (countID SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY, last_name VARCHAR(40), first_name VARCHAR(40))";
						$QueryResult = @mysqli_query($DBConnect, $SQLstring);
						if ($QueryResult === FALSE)
							echo "<p>Unable to create the table.</p>" . "<p>Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>";
					}
					$LastName = stripslashes($_POST['last_name']);
					$FirstName = stripslashes($_POST['first_name']);
					$SQLstring = "INSERT INTO $TableName VALUES(NULL, '$LastName', '$FirstName')";
					$QueryResult = @mysqli_query($DBConnect, $SQLstring);
					if ($QueryResult === FALSE)
						echo "<p>Unable to execute the query.</p>" . "<p>Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>";
					else
						echo "<h1>Thank you for signing our guest book, $FirstName!</h1>";

					mysqli_close($DBConnect);
				}

			}
			?>
		</div>
	</body>
</html>