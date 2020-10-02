<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<title>Show Guest Book</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
</head>

<body>

	<p>
		<?php

			$fileName = "guestbook.txt";

			if (is_readable($fileName)) 
			{
				echo "<pre>";
				readfile($fileName);
				echo "</pre> \n";
			}
			else
			{
				echo "Cannot read from $fileName";
			}

		?>
	</p>

	



</body>





</html>