#!/usr/bin/env bash

export GOOGLE_SERVICES_JSON_PATH=$APPCENTER_SOURCE_DIRECTORY/src/TestApp.Android/google-services.json

echo "Creating google-service.json"
echo $GOOGLE_SERVICES_JSON > $GOOGLE_SERVICES_JSON_PATH
sed -i -e 's/\\"/'\"'/g' $GOOGLE_SERVICES_JSON_PATH
echo "File created"