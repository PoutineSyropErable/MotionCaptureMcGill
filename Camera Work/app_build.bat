@echo off
REM Set up directories
set INCLUDE_DIR=include
set SRC_DIR=.
set OBJ_DIR=obj
set LIB_DIR=lib

REM Create the obj directory if it does not exist
if not exist %OBJ_DIR% mkdir %OBJ_DIR%


REM Compile the application
g++ -o CameraLogger.exe -s %SRC_DIR%\CameraLogger.cpp -I %INCLUDE_DIR%  -L".\%LIB_DIR%" -lNatNetLib -lNatNetML

REM Add LIB_DIR to PATH for DLL loading
set PATH=%PATH%;%CD%\%LIB_DIR%

REM Run the application
CameraLogger.exe

REM Pause the Command Prompt to see the output
@pause

