Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/validate -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client


(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj).replace('<Authors>Swagger</Authors>', "<Authors>Cloudmersive</Authors>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj).replace('<Company>Swagger</Company>', "<Company>Cloudmersive</Company>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj).replace('<AssemblyTitle>Swagger Library</AssemblyTitle>', "<AssemblyTitle>Cloudmersive Validate API Client</AssemblyTitle>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj).replace('<Description>A library generated from a Swagger doc</Description>', "<Description>The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.</Description>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj).replace('<TargetFramework>net45</TargetFramework>', "<TargetFramework>netcoreapp2.1</TargetFramework>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj



& dotnet build ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj -c Release
& dotnet pack ./client/src/Cloudmersive.APIClient.NETCore.Validate/Cloudmersive.APIClient.NETCore.Validate.csproj -c Release