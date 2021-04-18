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

$filePath = $args[0];
$fileContent = Get-Content -Path $filePath;

for($i = 0; $i -lt $fileContent.Length; $i++)
{
    $currentLine = $fileContent[$i];
    $length = $currentLine.Length;
    #In case of empty lines just prints 0.
    Write-Output "$currentLine $length"
}