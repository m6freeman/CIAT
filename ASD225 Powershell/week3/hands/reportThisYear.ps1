$year = Get-Date | Select-Object -ExpandProperty Year
$name = Read-Host -Prompt "Enter your name"
Write-Host "Your name is $name and it is the year $year"