@echo off
REM Set up directories
set INCLUDE_DIR=..\\..\\include
set SRC_DIR=.
set LIB_DIR=..\..\lib\x64



REM Compile the application
g++ -o SimpleClient.exe -s %SRC_DIR%\MinimalClient.cpp -I %INCLUDE_DIR%  -L %LIB_DIR% -lNatNetlib -lNatNetML

REM Add LIB_DIR to PATH for DLL loading
set PATH=%PATH%;%CD%\%LIB_DIR%

REM Run the application
SimpleClient.exe

REM Pause the Command Prompt to see the output
@pause

