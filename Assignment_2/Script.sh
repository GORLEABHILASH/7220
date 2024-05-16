#!/bin/bash

# Add Microsoft package repository
sudo rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm

# Install .NET SDK and runtimes
sudo yum install -y dotnet-sdk-7.0
sudo yum install -y aspnetcore-runtime-7.0
sudo yum install -y dotnet-runtime-7.0

# Update all packages and install git
sudo yum update -y
sudo yum install -y git

# Clone the repository
git clone https://github.com/GORLEABHILASH/7220.git

# Run Backend
cd 7220/Assignment_2/Backend
dotnet run &

# Run Frontend
cd ../Frontend
dotnet run
