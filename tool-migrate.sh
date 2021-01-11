#!/bin/bash

pushd EfTools.Migrations

DOTNET_RUNNING_IN_CONTAINER=true \
ConnectionStrings__Sqlite="Data Source=eftools.sqlite" \
\
dotnet ef database update \
  --msbuildprojectextensionspath obj/container \
  --context SqliteDbContext \
  --project . \
  --startup-project .
popd
