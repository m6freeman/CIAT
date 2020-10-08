$a = 3
Write-Host "$a " `t -NoNewline
$a.GetType() | Select-Object -ExpandProperty Name

$b = 3.3
Write-Host "$b " `t -NoNewline
$b.GetType() | Select-Object -ExpandProperty Name

$c = "3.3"
Write-Host "$c " `t -NoNewline
$c.GetType() | Select-Object -ExpandProperty Name

$d = $a + $b
Write-Host "$d " `t -NoNewline
$d.GetType() | Select-Object -ExpandProperty Name
