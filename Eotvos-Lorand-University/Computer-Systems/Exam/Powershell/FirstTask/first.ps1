$x1 = 0;
$x2 = 0;
$x3 = 0;

if ($args.Length -ge 3)
{
    [int] $x1 = $args[0];
    [int] $x2 = $args[1];
    [int] $x3 = $args[2];
}
else
{
    switch($args.Length)
    {
        0 {
            [int] $x1 = Read-Host "Give me x1: ";
            [int] $x2 = Read-Host "Give me x2: ";
            [int] $x3 = Read-Host "Give me x3: ";
        }
        1 {
            [int] $x1 = $args[0];
            [int] $x2 = Read-Host "Give me x2: ";
            [int] $x3 = Read-Host "Give me x3: ";
        }
        2 {
            [int] $x1 = $args[0];
            [int] $x2 = $args[1];
            [int] $x3 = Read-Host "Give me x3: ";
        }
    }
}

#if ($args.Length -lt 3)
#{
#    [int] $x1 = Read-Host "Give me x1: ";
#    [int] $x2 = Read-Host "Give me x2: ";
#    [int] $x3 = Read-Host "Give me x3: ";
#}
#else 
#{
#    [int] $x1 = $args[0];
#    [int] $x2 = $args[1];
#    [int] $x3 = $args[2]; 
#}

$result = ( $x1 + $x2 ) * $x3;

Write-Output "Result is: $result"