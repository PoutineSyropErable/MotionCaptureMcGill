@echo off
REM Set up directories
set INCLUDE_DIR=include
set SRC_DIR=.
set LIB_DIR=lib



g++ %SRC_DIR%\MinimalClient.cpp -o MinimalClient.exe  -I%INCLUDE_DIR% -L".\%LIB_DIR%" -lNatNetLib

REM Add LIB_DIR to PATH for DLL loading
set PATH=%PATH%;%CD%\%LIB_DIR%

REM Run the application
MinimalClient.exe

REM Pause the Command Prompt to see the output
@pause

