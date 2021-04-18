#!/bin/sh

if [ ! -f  $1 ]; then
	echo "Invalid file name.";
	exit 1;
fi

while read line; do
	line=`echo $line | sed 's/\,/\ /g'`;
	inputBase=-1;
	outputBase=-1;

	for i in $line; do
		if [ $inputBase -eq -1 ];
		then 
			inputBase=$i;
		else
			if [ $outputBase -eq -1 ];
			then
				outputBase=$i;
			else
				maxNumber=`expr $inputBase - 1`;
				currentNumber=`echo $i | grep -Ew "[0-$maxNumber]+"`;
				if [ "$currentNumber" = "$i" ];
				then
					convertedNumber=`echo "obase=$outputBase; ibase=$inputBase; $currentNumber" | bc`;
					echo "$currentNumber (base = $inputBase) => $convertedNumber (base = $outputBase)";
				else
					echo "$i (base = $inputBase) - BAD";
				fi
			fi
		fi
	done
done < $1
