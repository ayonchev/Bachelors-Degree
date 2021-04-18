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
$fileContent=Get-Content -Path $filepath;
$words=$fileContent.Split(" ");

$mostFrequentWord="";
$maxCount=0;

for ($i = 0; $i -lt $words.Length; $i++) 
{
    $currentWord = $words[$i];
    $currentWordCount = 0;

    for ($j = 0; $j -lt $words.Length; $j++)
    {
        $currentComparisonWord = $words[$j];

        if ($i -ne $j -and $currentComparisonWord.Contains($currentWord)) 
        {
            $currentWordCount++;
        }
    }
    
    if ($currentWordCount -gt $maxCount)
    {
        $mostFrequentWord = $currentWord;
        $maxCount = $currentWordCount;
    }
}

Write-Output "The most frequent word is: $mostFrequentWord -> $maxCount times";