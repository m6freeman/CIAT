$title = "===== Date & Time ====="

$message = "Please select an option"

$option1 = New-Object System.Management.Automation.Host.ChoiceDescription "&1: Get-Date", "Displays the local machines current date."
$option2 = New-Object System.Management.Automation.Host.ChoiceDescription "&2: Get-TimeZone", "Displays the local machine's current timezone."
$option3 = New-Object System.Management.Automation.Host.ChoiceDescription "&3: Get-Culture", "Displays the local machine's language culture setting."
$option4 = New-Object System.Management.Automation.Host.ChoiceDescription "&Q", "Exit the program."

$options = [System.Management.Automation.Host.ChoiceDescription[]]($option1, $option2, $option3, $option4)
$quit = $false
do {

    $result = $Host.UI.PromptForChoice($title, $message, $options, 0)
    clear
    switch ($result)
    {
        0 { Get-Date }
        1 { Get-TimeZone | Select-Object -ExpandProperty DisplayName }
        2 { Get-Culture | Select-Object -ExpandProperty DisplayName }
        3 { $quit = $true }
        Default { }
    }

} until ($quit)
