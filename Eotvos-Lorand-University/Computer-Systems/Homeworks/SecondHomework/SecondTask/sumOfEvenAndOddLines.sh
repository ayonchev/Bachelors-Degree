#!/bin/sh

if [ $# -eq 0 ]
then
	echo "You must provide the file name!";
	exit 1;
fi

if [ ! -f  $1 ];
then
	echo "Invalid file name!";
	exit 1;
fi

lineCount=1;
oddLinesSum=0;
evenLinesSum=0;

while read line	; do
	echo "The line with number $lineCount contains the numbers: $line";
	currentLineSum=0;
	for i in $line; do
		currentLineSum=`expr $currentLineSum + $i`;
	done

	if [ `expr $lineCount % 2` -eq 0 ]
	then
		evenLinesSum=`expr $evenLinesSum + $currentLineSum`;
	else 
		oddLinesSum=`expr $oddLinesSum + $currentLineSum`;
	fi
	
	lineCount=`expr $lineCount + 1`;
done < $1

echo "odd lines sum: $oddLinesSum";
echo "even lines sum: $evenLinesSum";
