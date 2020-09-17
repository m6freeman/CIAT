foreach ($item in $collection)
{
    Get-ChildItem $item | Where-Object Length -GT 1000 | Sort-Object -Property Name
}