Function WhatIsUp {
    if ($args -ne $null)
    {
        "You specified : $args"
        "Argument number: $($args.Count)"
        $count = 1
        foreach ($item in $args)
        {
            "$count Argument: $item"
            $count++
        }
    }
    Else
    {
        "You haven't specified any arguments!"
    }
}