#!/bin/sh

if [ $# -ne 1 ]; then
	echo "Invalid number of parameters. There should be one number parameter!"
	exit 1
fi

number=$1;

if [ $number -lt 2 ]; then
    echo "The number should be greater than 1.";
    exit 1;
fi

i=2;
powerOfI=`expr $i \* $i`;

while [ $powerOfI -le $number ]; do
    if [ `expr $number % $i` -eq 0 ]; then
        echo "The number is not prime.";
        exit 0;
    fi

    i=`expr $i + 1`;
    powerOfI=`expr $i \* $i`;
done;

echo "The number is prime."