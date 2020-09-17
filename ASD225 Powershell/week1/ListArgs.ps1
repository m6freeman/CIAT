foreach ($i in $args)
{
    Get-ChildItem $i | Where-Object Length -GT 1000 | Sort-Object -Property Name
}