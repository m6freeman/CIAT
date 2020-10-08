function OuterMethod
{
    param (
        [string]
        $first,

        [string]
        $second
    )

    Write-Host ($first) -NoNewline
    InnerMethod @PSBoundParameters
}

function InnerMethod
{
    param (
        [string]
        $second
    )
    Write-Host (" {0}!" -f $second)
}

$params = @{
    first = "Hello"
    second = "world"
}


OuterMethod @params