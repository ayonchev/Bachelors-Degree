#!/bin/sh

if [ $# -ne 1 ]; then
	echo "Invalid number of parameters. There should be one file name parameter!"
	exit 1
fi

fileName=$1;

if [ ! -f $fileName ]; then
    echo "The file doesn't exist!";
fi

result="";
while read line; do
    #removing the ';' so that way I can iterate through the words with the for loop
    line=`echo $line | sed 's/\;/\ /g'`;
    
    for word in $line; do
        result="${result} $word";
    done;

done < $fileName;

echo $result;