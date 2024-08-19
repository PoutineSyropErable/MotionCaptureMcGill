REM ---- You need to run this inside visual studio command prompt. Do open in terminal

@echo off
REM Set up directories
set INCLUDE_DIR=include
set SRC_DIR=.
set LIB_DIR=lib

REM Compile with cl.exe
cl /EHsc /Fe:MinimalClient.exe %SRC_DIR%\MinimalClient.cpp /I%INCLUDE_DIR% /link /LIBPATH:%LIB_DIR% NatNetLib.lib

REM Add LIB_DIR to PATH for DLL loading
set PATH=%PATH%;%CD%\%LIB_DIR%

REM Run the application
MinimalClient.exe

REM Pause the Command Prompt to see the output
@pause
