<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<title>PHP Code Blocks 2-2</title>
<meta http-equiv="content-type"     
content="text/html; charset=iso-8859-1" />
</head>

<body>

	<p>
		<?php

			echo "The odd numbers between 1 and 100 are ";
			$x = 0;
			while ($x <= 100)
			{
				if ($x % 2 != 0) echo "$x ";
				$x++;
			}
			
		?>
	</p>

	



</body>





</html>