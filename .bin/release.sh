#!/bin/sh

name=PersistOptions
version=$(jq -r .Version $name/manifest.json)

cat "$name/bin/Release/$name $version.zip"
