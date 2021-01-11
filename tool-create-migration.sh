#!/bin/bash

pushd EfTools.Migrations

DOTNET_RUNNING_IN_CONTAINER=true \
ConnectionStrings__Sqlite="Data Source=eftools.sqlite" \
\
dotnet ef migrations add $1 \
  --msbuildprojectextensionspath obj/container \
  --output-dir Migrations/Sqlite \
  --context SqliteDbContext \
  --project . \
  --startup-project .

popd
