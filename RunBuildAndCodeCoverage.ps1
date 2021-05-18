Push-Location $PSScriptRoot

Write-Host Building solution ...
dotnet build -c Release
Write-Host Build completed. -ForegroundColor Green

Write-Host Running code coverage ...
dotnet test --logger trx --no-build /p:CollectCoverage=true /p:CoverletOutputFormat='opencover%2cjson' /p:CoverletOutput=$PSScriptRoot\coverage\ /p:MergeWith=$PSScriptRoot\coverage\coverage.json /m:1
Write-Host Code coverage completed. -ForegroundColor Green

Pop-Location