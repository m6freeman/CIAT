Function WhatIsUp {
    if ($args -ne $null)
    {
        "You specified : $args"
        "Argument number: $($args.Count)"
        foreach ($item in $args)
        {
            $index = $args.IndexOf($item)
            "$($index + 1). Argument: $item"
        }
    }
    Else
    {
        "You haven't specified any arguments!"
    }
}
