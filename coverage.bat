taskkill /IM chrome.exe /F

set report_dir=.\Calculator.Test\reports
del %report_dir% /Q

dotnet test --no-build  /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,lcov,cobertura\" /p:Exclude=\"[*]Program*,[*]StringExtensions*\" /p:CoverletOutput=reports/ Calculator.Test 

reportgenerator -reports:%report_dir%\coverage.cobertura.xml -targetdir:%report_dir% %filters%

start %report_dir%\index.html
