@echo off
cls
::skrypt oblicza działania matematyczne
:start
set /p oblicz= Wpisz dzialanie: 
set /a wynik=%oblicz% 
echo %wynik%
goto start