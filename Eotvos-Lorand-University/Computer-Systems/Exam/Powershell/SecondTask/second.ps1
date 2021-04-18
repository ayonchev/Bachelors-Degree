if ($args.Length -ne 2)
{
    [int] $firstNum = Read-Host "Give me the first number: ";
    [int] $secondNum = Read-Host "Give me the second number: ";
}
else
{
    [int] $firstNum = $args[0];
    [int] $secondNum = $args[1];
}

$result = 1;

for($i = 0; $i -lt $secondNum; $i++)
{
    $result *= $firstNum;
}

Write-Output "The result is: $result"
