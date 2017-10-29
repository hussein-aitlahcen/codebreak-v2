#!/bin/bash

# Parameters
grpc_version=1.7.0
platform=$1
exec_ext=$2

# Paths
nuget_path=$(realpath ~)/.nuget/packages
grpc_path=$nuget_path/grpc.tools/$grpc_version/tools/$platform
output_path=../CodebreakV2.Shared/Intercom

# Clean output
rm $output_path/*.cs

# Generate
$grpc_path/protoc$exec_ext -I ./ --csharp_out=$output_path --grpc_out=$output_path --plugin=protoc-gen-grpc=$grpc_path/grpc_csharp_plugin$exec_ext *.proto