# CounselingScheduler
Solution created with:
`dotnet new sln`

Then projects created:
`dotnet new api -o calendar/adapter`
`dotnet new classlib -o calendar/application`
`dotnet new api -o calendar/domain`

Then:
`dotnet sln add .\CounselingScheduler.sln .\calendar\adapter`
`dotnet sln add .\CounselingScheduler.sln .\calendar\application`
`dotnet sln add .\CounselingScheduler.sln .\calendar\domain`