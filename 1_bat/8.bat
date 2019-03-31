@echo off
cls
::skrypt oblicza działania matematyczne
:start
set /p oblicz= Wpisz dzialanie: 
set /a wynik=%oblicz% 
echo %wynik%
if %wynik%==5 start cmd.exe
if %wynik%==10 start notepad.exe
if %wynik%==15 start chrome.exe
if %wynik%==0 goto koniec
goto start

:koniec
cls
echo Koniec programu!
