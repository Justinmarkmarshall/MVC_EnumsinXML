
$invocationLocation = (Get-Item .).FullName

# Publish locations
$PublishPath = "$PSScriptRoot/PublishOutput"

if (Test-path "Docker") {
  Write-Host "Removing existing publish.." -ForegroundColor Yellow
  Remove-Item "Docker" - Force -Recurse -ErrorAction Ignore
}

dotnet publish "$PSScriptRoot/../SerializationDemo/SerializationDemo.csproj" -c:Docker -o:$PublishPath /nodereuse:false -v:q

Set-Location $PSScriptRoot

Write-Host "Done!" -ForegroundColor Green