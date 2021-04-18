if ($args.Length -ne 2)
{
    Write-Output "Invalid parameters!";
    exit 1;
}

$dimensionLength = $args[0];
$diagonalLetter = $args[1];

$result = "";
$letter = "A";

for($row = 0; $row -lt $dimensionLength; $row++) 
{
    for($col = 0; $col -lt $dimensionLength; $col++)
    {
        if($col -eq $row) 
        {
            $result += $diagonalLetter;
            continue;
        }

        $result += $letter;
    }

    #$result += "`r`n";
    $result += [Environment]::NewLine;
}

$result;