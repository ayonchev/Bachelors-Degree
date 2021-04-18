#!/bin/sh

if [ $# -ne 1 ]; then
	echo "Invalid number of parameters. There should be one file name parameter!"
	exit 1
fi

fileName=$1;

if [ ! -f $fileName ]; then
    echo "The file doesn't exist!";
fi

echo "File exists.";

while read line; do
    names=$line;
    namesCount=0;
    for n in $names; do
        namesCount=`expr $namesCount + 1`;
    done;

    if [ $namesCount -eq 2 ]; then
        echo $names >> people-with-two-names.txt;
    elif [ $namesCount -eq 3 ]; then
        echo $names >> people-with-three-names.txt;
    fi
done < $fileName