@echo off
echo Iniciando proceso de instalacion...

set /p instancia="Ingrese el nombre de instancia del SQL SERVER: "
echo %instancia%

rem ejecutar script de creacion de base de datos
set sqlserver=.\%instancia%
sqlcmd -S %sqlserver% -E -i TalentFinder.DB.sql

rem setear variable de entorno de usuario
setx path "%USERPROFILE%\c:\Windows\Microsoft.NET\Framework\v4.0.30319\"

rem ejecutar instalador de la aplicacion
TalentFinder.Setup.msi

echo ------------------------
echo Finalizando proceso de instalacion...
pause