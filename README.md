# ConfigR

C# configuration for .NET apps based on [scriptcs](https://github.com/scriptcs/scriptcs) :sunglasses:.

Fed up with XML soup? Frustrated that app settings can only be strings? Then ConfigR is for you!

Get it at [NuGet](https://nuget.org/packages/ConfigR/ "ConfigR on Nuget").

## Quickstart

* Create a console application project in Visual Studio
* Install ConfigR from [NuGet](https://nuget.org/packages/ConfigR/ "ConfigR on Nuget")
* Add a new file named `<Your assembly>.csx`, e.g. `ConsoleAppliction1.exe.csx` and in the file properties set `Copy to Output Directory` to `Copy if newer`
* Add some configuration to the csx file e.g.

```C#
Configurator.Add("Count", 123);
Configurator.Add("Uri", new Uri("https://github.com/config-r/config-r"));
```

* Add some code to your project which uses the configuration, e.g.:

```C#
void Main(string[] args)
{ 
    var count = Configurator.Get<int>("Count");     // it's a System.Int32!
    var uri = Configurator.Get<Uri>("Uri");         // it's a System.Uri!
}
```

Congratulations! You've freed yourself from the shackles of XML and strings! :trophy:

## Updates

Releases will be pushed regularly to [NuGet](https://nuget.org/packages/ConfigR/). For update notifications, follow [@adamralph](https://twitter.com/#!/adamralph).

To build manually, clone or fork this repository and see ['How to build'](https://github.com/config-r/config-r/blob/master/how_to_build.md).

## Can I help to improve it and/or fix bugs? ##

Absolutely! Please feel free to raise issues, fork the source code, send pull requests, etc.

No pull request is too small. Even whitespace fixes are appreciated. Before you contribute anything make sure you read [CONTRIBUTING.md](https://github.com/config-r/config-r/blob/master/CONTRIBUTING.md).

## What do the version numbers mean? ##

ConfigR uses [Semantic Versioning](http://semver.org/). The current release is 0.x which means 'initial development'. Version 1.0 will follow the release of [scriptcs](https://github.com/scriptcs/scriptcs) version 1.0.