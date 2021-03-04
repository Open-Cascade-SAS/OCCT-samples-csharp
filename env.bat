set "aSampleSrc=%~dp0"

rem Configuration file
if exist "%~dp0custom.bat" call "%~dp0custom.bat"

call "%CASROOT%\env.bat" %1 %2 %3

set "BIN_DIR=win%ARCH%\%VCVER%\bind"
set "LIB_DIR=win%ARCH%\%VCVER%\libd"

if ["%CASDEB%"] == [""] (
  set "BIN_DIR=win%ARCH%\%VCVER%\bin"
  set "LIB_DIR=win%ARCH%\%VCVER%\lib"
)

set "PATH=%~dp0%LIB_DIR%;%~dp0%BIN_DIR%;%PATH%"
