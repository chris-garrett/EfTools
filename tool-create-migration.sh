#!/bin/bash

#  --msbuildprojectextensionspath obj/container \

pushd EfTools.Data

DOTNET_RUNNING_IN_CONTAINER=true \
ConnectionStrings__Sqlite="Data Source=eftools.sqlite" \
\
dotnet ef migrations add $1 \
  --output-dir Migrations/Sqlite \
  --context SqliteDbContext \
  --project . \
  --startup-project ../EfTools.Migrations

popd
