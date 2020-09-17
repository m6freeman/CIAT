$intFolders = 10
$intPad
$i = 1
New-Variable -Name 'strPrefix' -Value 'testFolder' -Option Constant

do
{
    if ($i -lt 10)
    {
        $intPad = 0
        New-Item -Path './' -Name "$strPrefix$intPad$i" -ItemType Directory
    }
    else
    {
        New-Item -Path './' -Name "$strPrefix$i" -ItemType Directory
    }
    $i++
}
until ($i -gt $intFolders)
