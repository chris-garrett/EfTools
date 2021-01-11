#!/bin/bash

#  --msbuildprojectextensionspath obj/container \

pushd EfTools.Migrations

DOTNET_RUNNING_IN_CONTAINER=true \
ConnectionStrings__Sqlite="Data Source=eftools.sqlite" \
\
dotnet ef database update \
  --context SqliteDbContext \
  --project . \
  --startup-project .
popd
