$str=Get-Content;
echo $str | Select-String "ddd" | Measure-Object -