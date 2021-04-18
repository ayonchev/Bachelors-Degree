#!/bin/sh

if [ $# -eq 0 ]; then
    echo "Give me x1: ";
	read x1;
    echo "Give me x2: ";
    read x2;
    echo "Give me x3: ";
    read x3;
elif [ $# -eq 1 ]; then
    x1=$1;
    echo "Give me x2: ";
    read x2;
    echo "Give me x3: ";
    read x3;
elif [ $# -eq 2 ]; then
    x1=$1;
    x2=$2;
    echo "Give me x3: ";
    read x3;
elif [ $# -eq 3 ]; then
    x1=$1;
    x2=$2;
    x3=$3;
fi

result=`expr $x1 + $x2`;
result=`expr $result \* $x3`;

echo $result;
