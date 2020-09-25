Function LoopThrough()
{
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $true)]
        [string[]]
        $names
    )

    foreach ($name in $names)
    {
        Write-Host $name
    }
}

LoopThrough -names @("one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten")
