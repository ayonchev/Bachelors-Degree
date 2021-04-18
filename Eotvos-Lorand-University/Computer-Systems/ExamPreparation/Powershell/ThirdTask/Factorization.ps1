if ($args.Length -ne 1)
{
    Write-Output "Invalid parameters!";
    exit 1;
}

$number = $args[0];
$result = "";

#Not optimized solution
#for($i = 2; $i -le $number; $i++)
#{
#    if($number -eq 1)
#    {
#        break;
#    }
#    while($number % $i -eq 0)
#    {
#        $number /= $i;
#        $result += "$i ";
#    }
#}

for($i = 2; $i * $i -le $number; $i++)
{
    while($number % $i -eq 0)
    {
        $number /= $i;
        $result += "$i ";
    }
}

if($number -ne 1)
{
    $result += $number;
}

echo $result;