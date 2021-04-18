#!/bin/sh

if [ $# -ne 1 ]; then
	echo "Invalid number of parameters. There should be one string parameter!"
	exit 1
fi

word=$1;
wordLength=`echo -n $word | wc -c`;
#wordLength=`printf $word | wc -c`;

characterToAppend='X';
charactersCount=`expr 25 - $wordLength`;

if [ $charactersCount -lt 1 ]; then
    echo $word;
    exit 0;
fi

for i in `seq $charactersCount`; do
    word="${word}${characterToAppend}";
done;

echo $word;
echo "Length: `printf $word | wc -c`";