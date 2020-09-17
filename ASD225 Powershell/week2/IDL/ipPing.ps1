$ipList = "./ipList.txt"

if (!(Test-Path $ipList))
{
    Write-Host "Scanning internal network..."
    nmap -sn 192.168.0.0/24 | grep -o "192.*" > $ipList
    Write-Host "Scan complete. $ipList generated."
}

Write-Host "Reading file: $ipList"
foreach ($ip in Get-Content $ipList)
{
    if (Test-Connection $ip -Count 1 -Quiet)
    {
        Write-Host "$ip Ping succeeded." -ForegroundColor Green
    }
    else
    {
        Write-Host "$ip Ping failed." -ForegroundColor Red
    }
}
