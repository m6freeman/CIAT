$dteStart = Get-Date
$query = "SELECT * FROM win32_product"
Write-Host "Getting Win32_Product Object, this may take a few moments...`n" -ForegroundColor Green
Get-CimInstance -Query $query
$dteEnd = Get-Date
$dteDiff = New-TimeSpan $dteStart $dteEnd
Write-Host "Completed in $dteDiff seconds"