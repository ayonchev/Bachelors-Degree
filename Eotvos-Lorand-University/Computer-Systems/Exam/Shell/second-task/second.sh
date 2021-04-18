#!/bin/sh

if [ $# -eq 0 ]; then
    echo "Give me a: ";
	read a;
    echo "Give me b: ";
    read b;
    echo "Give me c: ";
    read c;
elif [ $# -eq 1 ]; then
    a=$1;
    echo "Give me b: ";
    read b;
    echo "Give me c: ";
    read c;
elif [ $# -eq 2 ]; then
    a=$1;
    b=$2;
    echo "Give me c: ";
    read c;
elif [ $# -eq 3 ]; then
    a=$1;
    b=$2;
    c=$3;
fi

result="";
while [ $b -le $c ]; do
    if [ `expr $b % $a` -eq 0 ]; then
        result="${result} $b";
    fi
    b=`expr $b + 1`;
done

echo $result;