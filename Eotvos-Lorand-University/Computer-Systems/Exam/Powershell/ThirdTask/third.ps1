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

$shortestLineLength = 1000000;
$shortestLineIndex = 0;

for($i = 0; $i -lt $fileContent.Length; $i++)
{
    $currentLine = $fileContent[$i];
    if($currentLine.Length -lt $shortestLineLength)
    {
        $shortestLineLength = $currentLine.Length;
        $shortestLineIndex = $i;
    }
}

$shortestLine = $fileContent[$shortestLineIndex];

Write-Output "The shortest line has $shortestLineLength characters and is: "
Write-Output $shortestLine;