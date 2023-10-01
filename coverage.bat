taskkill /IM chrome.exe /F

set report_dir=.\Caculator.Test\reports
set filters="-assemblyFilters:+*.*" "-classfilters:-*Test;-*Program;-*StringExtensions"
rem set filters=""

dotnet-coverage collect -f xml -o %report_dir%\coverage.xml dotnet test 
reportgenerator -reports:%report_dir%\coverage.xml -targetdir:%report_dir% %filters%


start %report_dir%\index.html
