# Sonarqube demo

## General notes

- deafult branch is master (rename to "main" branch beforehand, if needed)

## etbaas-backend

- Requirment: `dotnet tool install --global dotnet-sonarscanner`
- Generate token
- execute:

> dotnet sonarscanner begin /k:"{{ SONAR_PROJECT_NAME}}" /d:sonar.host.url="{{ SONAR_HOST_URL }}"  /d:sonar.login="{{ SONAR_TOKEN }}"
>
> dotnet build ...
>dotnet test ...
>
> dotnet sonarscanner end /d:sonar.login="{{ SONAR_TOKEN }}"

## etbaas-frontend

- Requirment: download and install sonar-scanner (OS dependent)
- Generate token
- execute: `sonar-scanner.bat -D"sonar.projectKey=etbaas-frontend" -D"sonar.sources=." -D"sonar.host.url={{ SONAR_HOST_URL }}" -D"sonar.login={{ SONAR_TOKEN }}"`

## sonarqube-demo
