$title = "Welcome to The Number Guessing Game"
$highest = 100
$lowest = 1
$randGen = New-Object System.Random

function Game
{
    do
    {
        Clear-Host
        Write-Host $title -ForegroundColor Red
        if ($IsLinux) {
            cowsay "I have chosen a number between $lowest and $highest. Try to guess it!"
        } else {
            Write-Host "Enter a number between $lowest and $highest."
        }

        $numberToGuess = $randGen.Next($lowest, $highest) + 1
        $tries = Guess -numberToGuess $numberToGuess

        Clear-Host
        if ($IsLinux) {
            cowsay "Congrats! You guessed my number in $tries tries!" | lolcat
        } else {
            Write-Host "Congrats! You guessed the number in $tries tries!"
        }

        $playAgain = Read-Host -Prompt "Do you wish to play again? [y/n]"
    }
    until ($playAgain -eq 'n')
}

function Guess
{
    param( [Int32] $numberToGuess )

    $tries = 0

    do {
        $try = Read-Host -Prompt "Guess"
        if ($try -lt $numberToGuess) { Write-Host "Too low..." }
        if ($try -gt $numberToGuess) { Write-Host "Too high..." }
        $tries++
    }
    until ($try -eq $numberToGuess)
    return $tries
}

Game
Clear-Host
Exit-PSHostProcess
