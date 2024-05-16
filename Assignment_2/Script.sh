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

# Fetch the public IP address
PUBLIC_IP=$(curl -s http://169.254.169.254/latest/meta-data/public-ipv4)

# Update the Song1.cshtml file with the public IP address
sed -i "s|https://54.163.249.138:5001|https://${PUBLIC_IP}:5001|g" 7220/Assignment_2/Frontend/Pages/Song1.cshtml
sed -i "s|https://54.163.249.138:5001|https://${PUBLIC_IP}:5001|g" 7220/Assignment_2/Frontend/Pages/Song2.cshtml
sed -i "s|https://54.163.249.138:5001|https://${PUBLIC_IP}:5001|g" 7220/Assignment_2/Frontend/Pages/Song3.cshtml

# Run Backend
cd 7220/Assignment_2/Backend
dotnet run &

# Run Frontend
cd ../Frontend
dotnet run
