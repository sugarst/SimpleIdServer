@echo off
rem Helper script for those who want to run psake from cmd.exe.
rem The psake engine lives in eng\psake; the build definition is default.ps1 at the repository root.
rem Example run from cmd.exe:
rem psake ci

if '%1'=='/?' goto help
if '%1'=='-help' goto help
if '%1'=='-h' goto help

powershell -NoProfile -ExecutionPolicy Bypass -Command "& '%~dp0eng\psake\psake.ps1' -buildFile '%~dp0default.ps1' %*"
exit /B %errorlevel%

:help
powershell -NoProfile -ExecutionPolicy Bypass -Command "& '%~dp0eng\psake\psake.ps1' -help"
