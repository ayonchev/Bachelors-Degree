if ($args.Length -ne 1)
{
    Write-Output "Invalid parameters! The script requires only one parameter - the file path";
    exit 1;
}

if (!(Test-Path $args[0] -PathType Leaf))
{
    Write-Output "Invalid path!";
    exit 1;
}

$filepath = $args[0];
$fileContent = Get-Content -Path $filepath;
$sum = 0;

for($line = 0; $line -lt $fileContent.Length; $line++)
{
    $numbers = $fileContent[$line].Split(";");

    for($index = 0; $index -lt $numbers.Length; $index++) 
    {
        $sum += $numbers[$index];
    }
}

echo $sum;