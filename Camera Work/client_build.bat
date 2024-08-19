@echo off
REM Set up directories
set INCLUDE_DIR=include
set SRC_DIR=.
set LIB_DIR=.


REM Compile tkhe application
g++ -o SimpleClient.exe -s MinimalClient.cpp -I.  -L. -lNatNetLib -lNatNetML

REM Add LIB_DIR to PATH for DLL loading
set PATH=%PATH%;%CD%\%LIB_DIR%

REM Run the application
SimpleClient.exe

REM Pause the Command Prompt to see the output
@pause

