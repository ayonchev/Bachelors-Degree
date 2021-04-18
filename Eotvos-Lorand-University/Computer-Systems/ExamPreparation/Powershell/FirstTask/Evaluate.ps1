if ($args.Length -ne 3)
{
    Write-Output "Invalid parameters!";
    exit 1;
}

$a=$args[0];
$b=$args[1];
$c=$args[2];


$result = $a * $b + $c;
Write-Output $result;