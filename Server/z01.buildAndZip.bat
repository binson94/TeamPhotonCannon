@echo off

cd Server
dotnet publish -r linux-x64
cd ..\LoginServer
dotnet publish -r linux-x64
cd ..\Server

if exist Server\ (
    rmdir /s /q Server
)

if exist toLinux.zip (
    del toLinux.zip
)

mkdir Server\Json\Datas

copy Json\Datas\Monsterstats.json Server\Json\Datas\
copy bin\Debug\net6.0\Server.dll Server\
copy bin\Debug\net6.0\ServerCore.dll Server\
copy bin\Debug\net6.0\Newtonsoft.Json.dll Server\

copy bin\Debug\net6.0\Microsoft.Extensions.Logging.Abstractions.dll Server\
copy bin\Debug\net6.0\Npgsql.dll Server\

copy bin\Debug\net6.0\Server.runtimeconfig.json Server\

copy ..\LoginServer\bin\Debug\net6.0\LoginServer.dll Server\
copy ..\LoginServer\bin\Debug\net6.0\LoginServer.runtimeconfig.json Server\


bandizip bc -y "Server"
rmdir /s /q Server
timeout /t 2