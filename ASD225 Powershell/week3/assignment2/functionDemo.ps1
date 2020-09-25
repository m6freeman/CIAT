Function WhatIsUp {
    if ($args -ne $null)
    {
        "You specified : $args"
        "Argument number: $($args.Count)"
        foreach ($item in $args)
        {
            "$($args.IndexOf($item) + 1). Argument: $item"
        }
    }
    Else
    {
        "You haven't specified any arguments!"
    }
}

WhatIsUp test2 test1 test