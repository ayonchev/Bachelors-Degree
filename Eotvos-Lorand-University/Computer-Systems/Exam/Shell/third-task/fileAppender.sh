#!/bin/sh

if [ -f "result.txt" ]; then
    rm result.txt;
fi

for fileName in "$@"; do
    echo $fileName;
    if [ -f $fileName ]; then
        while read line; do
            echo $line >> result.txt;
        done < $fileName;
    else
        if [ -f "result.txt" ]; then
            rm result.txt;
        fi
        echo "The file doesn't exist!";
        exit 1;
    fi 
done