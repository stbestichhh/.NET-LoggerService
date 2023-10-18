[![Nuget](https://img.shields.io/badge/Nuget-v1.2.0-purple)](https://www.nuget.org/packages/StLogger/1.2.0#readme-body-tab)
![Nuget](https://img.shields.io/nuget/dt/StLogger)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Open Source Love](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/)

# File Logger

It's a [.NET 6](https://dotnet.microsoft.com/en-us/apps/maui) logger for C# code. It works on any .net framework.

## [CHANGELOG](CHANGELOG.md)

## Instalation

1. Download it form [NuGet.org](https://www.nuget.org/packages/StLogger/)
2. Download [last release](https://github.com/stbestichhh/dotNET-LoggerService/releases/tag/v1.2.0)

or use this command instead:

```bash
dotnet add package StLogger --version 1.2.0
```
    
## USAGE

1. [Install](#Instalation) NuGet package.
2. Connect it to your code 
`using EasyLogPackage;`
3. Create class instance and paste class name in '<>':

`Logf<YOUR_CLASS> logger = new Logf<YOUR_CLASS>("FILE_NAME", "DIRECTORY")`

‼️***Remeber***, **it is not necessary to write 'FILE_NAME' and 'DIRECTORY' in constructor**‼️

4. Then call necessary function:

`logger.LogInfo("YOUR_MESSAGE")`

##### Usage examples
> [EXAMPLES](EXAMPLES.md)

## Links
* **NuGet [Website](https://www.nuget.org) | [My Package](https://www.nuget.org/packages/StLogger/)**
* **.NET [Website](https://dotnet.microsoft.com/en-us/) | [Instalation](https://dotnet.microsoft.com/en-us/download)**

## Authors

- [@stbestichhh](https://www.github.com/stbestichhh)


## Support

For support, you have my [email](mailto:stbestich@gmail.com).
