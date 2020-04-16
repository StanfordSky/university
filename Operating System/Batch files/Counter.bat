echo Off
 
set i=0
for /f "usebackq" %%i in ("%1") do (
 set /a i=i+1
)
echo %i% strings
 
set k=0
for /f "usebackq delims=" %%i in ("%1") do (
 for %%j in (%%i) do (
  set /a k=k+1
 )
)
echo %k% words

set j=0 
for %%i in ("%1") do (
 set j=%%~zi
)
echo %j% characters
 
pause