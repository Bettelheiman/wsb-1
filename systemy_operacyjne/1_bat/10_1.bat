@echo off
::pass - utworzenie hasla, check - sprawdzenie hasla
:start
cls
echo ###############################															
echo Wpisz jedna z opcji:
echo.
echo pass (tworzy haslo)
echo check (sprawdza haslo)
echo end (koniec programu)
echo.
echo ###############################
echo.

set /p program=Co wybierasz? 
goto %program%

:pass
cls
set /p password= Podaj haslo: 
echo %password% > pass.txt
goto start

:check
cls
set /p password1= Podaj haslo: 
for /f %%a in (pass.txt) do (
	set PASS=%%a
)
::echo %PASS%
if %password1%==%PASS% goto correct
echo Bledne haslo!
echo.
pause
goto start

:correct
echo Poprawne haslo ;)
echo.
pause
goto start

:end
cls
echo Koniec programu
echo.
