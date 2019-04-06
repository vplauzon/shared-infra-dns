#!/bin/bash

uniqueId=$(uuidgen)
name="deploy-$uniqueId"

az group deployment create -n $name -g vpl-dns --template-file dns.json --parameters @dns.parameters.json