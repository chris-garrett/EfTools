#!/bin/bash

find . -type d -name obj | grep -v .git | xargs rm -fr
find . -type d -name bin | grep -v .git | xargs rm -fr

