<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<title>Box Array</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
</head>

<body>

	<p>
		<?php

            $boxSizes = array
            (
                                "small" => array("length" => 12, "width" => 10, "depth" => 2.5),
                                "medium" => array("length" => 30, "width" => 20, "depth" => 4),
                                "large" => array("length" => 60, "width" => 40, "depth" => 11.5)
            );

            $volume = 1;

            foreach ($boxSizes as $key => $value) 
            {
                foreach ($value as $prop) $volume *= $prop;
                echo "The area of the " . $key . " box is: " . $volume . "<br />";
                $volume = 1;
            }
            

		?>
	</p>

	



</body>





</html>