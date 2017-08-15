# simple-core-ngular
A containerizable .NET Core 2.0 Angular Web Application based on the RazorPages template

Prerequisites:
  - dotnet Core 2.0.0 SDK
  - Docker for Windows
  - Visual Studio 2017 15.3 or Visual Studio Code
  - angular cli

Currently, this is just a basic basic implementation to see if this could be done.
There is no pre-build configuration to build the angular app, publish the dotnet app and build the docker container. This has to be done manually. The steps involved here are listed below.

Build the angular app using cli [from the ClientApp folder]

```sh
npm install
ng build
```
Publish the dotnet core app [from the WebApp folder]

```sh
dotnet restore
dotnet build
dotnet publish
```

Build the container [from the solution folder]

```sh
docker build -t simple-core-ngular .
```


### Todos
 - Improve the overall architecture of the Application
 - Automate the buidling process

License
----

MIT
