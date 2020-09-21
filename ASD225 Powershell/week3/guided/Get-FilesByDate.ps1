function Get-FilesByDate
{
    [CmdletBinding()]
    Param (
        [string[]]              $fileTypes = @("*.*"),

        [Parameter(Mandatory = $true)]
        [int]                   $month,

        [Parameter(Mandatory = $true)]
        [int]                   $year,

        [ValidateScript({Test-Path $_})]
        [System.IO.FileInfo[]]  $paths = @("./")
    )

        Get-ChildItem -Path $paths -Include $fileTypes -Recurse | Where-Object {$_.LastWriteTime.Month -eq $month -and $_.LastWriteTime.Year -eq $year}
}

