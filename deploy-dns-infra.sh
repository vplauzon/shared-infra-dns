#!/bin/bash

##########################################################################
##  Deploys DNS Azure infrastructure solution
##
##  Parameters:
##
##  1- Name of resource group

rg=$1

echo "Resource group:  $rg"
echo "Current directory:  $(pwd)"

echo
echo "Deploying ARM template"

az deployment group create -n "deploy-$(uuidgen)" -g $rg \
    --template-file dns.json \
    --parameters @dns.parameters.json