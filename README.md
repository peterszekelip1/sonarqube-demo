# Sonarqube demo

- General overview about sonarqube
- How to integrate it to the daily routines (when using locally with Rider / Visual Studio)
- How to integrate it to the pipelines running on Github
- Language support (c#, but also Typescript / React)
- What are some interesting “smart” checks it can do for code quality and architecture?

## General notes

- default branch is master (rename to "main" branch beforehand, if needed)

## dotnet csharp

- Requirment: `dotnet tool install --global dotnet-sonarscanner`
- Generate token
- execute:

```cs

 dotnet sonarscanner begin /k:"{{ SONAR_PROJECT_KEY }}" /d:sonar.host.url="{{ SONAR_HOST_URL }}"  /d:sonar.login="{{ SONAR_TOKEN }}"

 dotnet build ...
 dotnet test ...

 dotnet sonarscanner end /d:sonar.login="{{ SONAR_TOKEN }}"

```

## javascript / typescript

- Requirment: download and install sonar-scanner (OS dependent)
- Generate token
- execute:  
  `sonar-scanner.bat -D"sonar.projectKey={{ SONAR_PROJECT_KEY }}" -D"sonar.sources=." -D"sonar.host.url={{ SONAR_HOST_URL }}" -D"sonar.login={{ SONAR_TOKEN }}"`

## sonarqube-demo
