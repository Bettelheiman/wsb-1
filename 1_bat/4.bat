@echo off
cls
set /A x = 5
set /A y = 3
set /A wynik = %x% + %y%
echo Suma = %wynik%
set /A wynik = %x% - %y%
echo Roznica = %wynik%
set /A wynik = %x% * %y%
echo Iloczyn = %wynik%
set /A wynik = %x% / %y%
echo Iloraz = %wynik%