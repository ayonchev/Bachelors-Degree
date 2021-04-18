#!/bin/sh

if [ $# -lt 2 ]; then
	echo "Invalid count of parameters. The first should be the database, and the second should be the letter.";
	exit 1;
fi

database=$1;
letter=$2;

if [ ! -f  $database ] || [ ! -f  $letter ]; then
	echo "Invalid file names.";
	exit 1;
fi

letterText=`cat $letter`;
while read line; do
    name=`echo $line | cut -d";" -f1`;
    address=`echo $line | cut -d";" -f2`;
    date=`echo $line | cut -d";" -f3`;

    echo `echo $letterText | sed "s/<name>/<$name>/;s/<address>/<$address>/;s/<date>/<$date>/;"`
    echo "\n---------------\n"
done < $database