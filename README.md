# Geek.HangfireServer

Geek.HangfireServer

基于Hangfire .NET Core开发

## 结构

项目结构：

test
src
    Geek.HangfireServer.sln
    Geek.HangfireServer.WebApi
    Geek.HangfireServer.Application
    Geek.Hangfire.Core(数据模型、*Manager、*Helper、consts)
    Geek.Hangfire.EntityFrameworkCore
docker

## 起步

### Core

dotnet new classlib -o src/Geek.Hangfire.Core
dotnet add package Microsoft.EntityFrameworkCore

dotnet new classlib -o src/Geek.Infrastructrue.Mail
dotnet new classlib -o src/Geek.Infrastructrue.DependencyInjection
