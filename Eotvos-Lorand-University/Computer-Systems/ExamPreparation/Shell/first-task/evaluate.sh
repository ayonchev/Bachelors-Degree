#!/bin/sh

if [ $# -ne 3 ]; then
	echo "Invalid number of parameters. Three number parameters must be provided!"
	exit 1
fi

a=$1;
b=$2;
c=$3;

result=`expr $a + $b`;
result=`expr $result \* $c`;

echo $result;