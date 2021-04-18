#!/bin/sh

if [ $# -ne 1 ]; then
	echo "Invalid number of parameters. There should be one number parameter!"
	exit 1
fi

dimension=$1;
defaultChar="A";
diagonalChar="B";

result="";

for i in `seq $dimension`; do
    for j in `seq $dimension`; do
        if [ $i -eq $j ]; then
            result="${result}${diagonalChar}";
        else
            result="${result}${defaultChar}";
        fi
    done;
    result="${result}\n"
done;

echo $result;