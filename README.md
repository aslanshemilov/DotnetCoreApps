# DotnetCoreApps

.NET Extensions
===============

[![Build Status](https://dev.azure.com/dnceng/public/_apis/build/status/dotnet/extensions/Extensions-ci)](https://dev.azure.com/dnceng/public/_build/latest?definitionId=23)

.NET Extensions is an open-source, cross-platform set of APIs for commonly used programming patterns and utilities, such as dependency injection, logging, and app configuration. Most of the API in this project is meant to work on many .NET platforms, such as .NET Core, .NET Framework, Xamarin, and others. While commonly used in ASP.NET Core applications, these APIs are not coupled to the ASP.NET Core application model. They can be used in console apps, WinForms and WPF, and others.

---

## *** Important Updates ***

As part of the [ongoing repository consolidation effort in .NET 5](https://github.com/dotnet/announcements/issues/119), we have moved most of the content from dotnet/extensions into other repositories. Most of these packages were developed by and are currently maintained by the ASP.NET team. However, moving forward we want to enable more scenarios with these packages, outside of ASP.NET. You can find more details on this in the [official announcement](https://github.com/aspnet/Announcements/issues/411) of the changes coming to extensions.

The full list of packages that have moved can be found below and in the [official announcement](https://github.com/aspnet/Announcements/issues/411). In general, tests and samples have moved to the relevant repo based on where the main package moved. Issue tracking for the relevant packages has also moved to that repository.

## Package List

The following list identifies all the packages we currently ship from [dotnet/extensions](https://github.com/dotnet/extensions) and which repo they have moved to.

* Moved to [dotnet/runtime](https://github.com/dotnet/runtime)
    * **Caching**
        * [`Microsoft.Extensions.Caching.Abstractions`](https://nuget.org/packages/Microsoft.Extensions.Caching.Abstractions)
        * [`Microsoft.Extensions.Caching.Memory`](https://nuget.org/packages/Microsoft.Extensions.Caching.Memory)
    * **Configuration**
        * [`Microsoft.Extensions.Configuration`](https://nuget.org/packages/Microsoft.Extensions.Configuration)
        * [`Microsoft.Extensions.Configuration.Abstractions`](https://nuget.org/packages/Microsoft.Extensions.Configuration.Abstractions)
        * [`Microsoft.Extensions.Configuration.Binder`](https://nuget.org/packages/Microsoft.Extensions.Configuration.Binder)
        * [`Microsoft.Extensions.Configuration.CommandLine`](https://nuget.org/packages/Microsoft.Extensions.Configuration.CommandLine)
        * [`Microsoft.Extensions.Configuration.EnvironmentVariables`](https://nuget.org/packages/Microsoft.Extensions.Configuration.EnvironmentVariables)
        * [`Microsoft.Extensions.Configuration.FileExtensions`](https://nuget.org/packages/Microsoft.Extensions.Configuration.FileExtensions)
        * [`Microsoft.Extensions.Configuration.Ini`](https://nuget.org/packages/Microsoft.Extensions.Configuration.Ini)
        * [`Microsoft.Extensions.Configuration.Json`](https://nuget.org/packages/Microsoft.Extensions.Configuration.Json)
        * [`Microsoft.Extensions.Configuration.UserSecrets`](https://nuget.org/packages/Microsoft.Extensions.Configuration.UserSecrets)
        * [`Microsoft.Extensions.Configuration.Xml`](https://nuget.org/packages/Microsoft.Extensions.Configuration.Xml)
    * **Dependency Injection**
        * [`Microsoft.Extensions.DependencyInjection`](https://nuget.org/packages/Microsoft.Extensions.DependencyInjection)
        * [`Microsoft.Extensions.DependencyInjection.Abstractions`](https://nuget.org/packages/Microsoft.Extensions.DependencyInjection.Abstractions)
    * **File Providers**
        * [`Microsoft.Extensions.FileProviders.Abstractions`](https://nuget.org/packages/Microsoft.Extensions.FileProviders.Abstractions)
        * [`Microsoft.Extensions.FileProviders.Composite`](https://nuget.org/packages/Microsoft.Extensions.FileProviders.Composite)
        * [`Microsoft.Extensions.FileProviders.Physical`](https://nuget.org/packages/Microsoft.Extensions.FileProviders.Physical)
    * **File System Globbing**
        * [`Microsoft.Extensions.FileSystemGlobbing`](https://nuget.org/packages/Microsoft.Extensions.FileSystemGlobbing)
    * **Hosting**
        * [`Microsoft.Extensions.Hosting`](https://nuget.org/packages/Microsoft.Extensions.Hosting)
        * [`Microsoft.Extensions.Hosting.Abstractions`](https://nuget.org/packages/Microsoft.Extensions.Hosting.Abstractions)
    * **Http Client Factory**
        * [`Microsoft.Extensions.Http`](https://nuget.org/packages/Microsoft.Extensions.Http)
    * **Logging**
        * [`Microsoft.Extensions.Logging`](https://nuget.org/packages/Microsoft.Extensions.Logging)
        * [`Microsoft.Extensions.Logging.Abstractions`](https://nuget.org/packages/Microsoft.Extensions.Logging.Abstractions)
        * [`Microsoft.Extensions.Logging.Configuration`](https://nuget.org/packages/Microsoft.Extensions.Logging.Configuration)
        * [`Microsoft.Extensions.Logging.Console`](https://nuget.org/packages/Microsoft.Extensions.Logging.Console)
        * [`Microsoft.Extensions.Logging.Debug`](https://nuget.org/packages/Microsoft.Extensions.Logging.Debug)
        * [`Microsoft.Extensions.Logging.EventLog`](https://nuget.org/packages/Microsoft.Extensions.Logging.EventLog)
        * [`Microsoft.Extensions.Logging.EventSource`](https://nuget.org/packages/Microsoft.Extensions.Logging.EventSource)
        * [`Microsoft.Extensions.Logging.Testing`](https://nuget.org/packages/Microsoft.Extensions.Logging.Testing)
        * [`Microsoft.Extensions.Logging.TraceSource`](https://nuget.org/packages/Microsoft.Extensions.Logging.TraceSource)
    * **Options**
        * [`Microsoft.Extensions.Options`](https://nuget.org/packages/Microsoft.Extensions.Options)
        * [`Microsoft.Extensions.Options.ConfigurationExtensions`](https://nuget.org/packages/Microsoft.Extensions.Options.ConfigurationExtensions)
        * [`Microsoft.Extensions.Options.DataAnnotations`](https://nuget.org/packages/Microsoft.Extensions.Options.DataAnnotations)
    * **Primitives**
        * [`Microsoft.Extensions.Primitives`](https://nuget.org/packages/Microsoft.Extensions.Primitives)
* Moved to [dotnet/aspnetcore](https://github.com/dotnet/aspnetcore)
    * **Configuration**
        * [`Microsoft.Extensions.Configuration.KeyPerFile`](https://nuget.org/packages/Microsoft.Extensions.Configuration.KeyPerFile)
    * **File Providers**
        * [`Microsoft.Extensions.FileProviders.Embedded`](https://nuget.org/packages/Microsoft.Extensions.FileProviders.Embedded)
        * [`Microsoft.Extensions.FileProviders.Embedded.Manifest.Task`](https://nuget.org/packages/Microsoft.Extensions.FileProviders.Embedded.Manifest.Task)
    * **Health Checks**
        * [`Microsoft.Extensions.Diagnostics.HealthChecks`](https://nuget.org/packages/Microsoft.Extensions.Diagnostics.HealthChecks)
        * [`Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions`](https://nuget.org/packages/Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions)
    * **JS Interop**
        * [`Microsoft.JSInterop`](https://nuget.org/packages/Microsoft.JSInterop)
        * [`Mono.WebAssembly.Interop`](https://nuget.org/packages/Mono.WebAssembly.Interop)
    * **Localization**
        * [`Microsoft.Extensions.Localization`](https://nuget.org/packages/Microsoft.Extensions.Localization)
        * [`Microsoft.Extensions.Localization.Abstractions`](https://nuget.org/packages/Microsoft.Extensions.Localization.Abstractions)
    * **Logging**
        * [`Microsoft.Extensions.Logging.AzureAppServices`](https://nuget.org/packages/Microsoft.Extensions.Logging.AzureAppServices)
    * **Object Pool**
        * [`Microsoft.Extensions.ObjectPool`](https://nuget.org/packages/Microsoft.Extensions.ObjectPool)
    * **Web Encoders**
        * [`Microsoft.Extensions.WebEncoders`](https://nuget.org/packages/Microsoft.Extensions.WebEncoders)
* Remaining in [dotnet/extensions](https://github.com/dotnet/extensions) for now
    * **Caching**
        * [`Microsoft.Extensions.Caching.SqlServer`](https://nuget.org/packages/Microsoft.Extensions.Caching.SqlServer)
        * [`Microsoft.Extensions.Caching.StackExchangeRedis`](https://nuget.org/packages/Microsoft.Extensions.Caching.StackExchangeRedis)
    * **Configuration**
        * [`Microsoft.Extensions.Configuration.NewtonsoftJson`](https://nuget.org/packages/Microsoft.Extensions.Configuration.NewtonsoftJson)
    * **Hosting**
        * [`Microsoft.Extensions.Hosting.Systemd`](https://nuget.org/packages/Microsoft.Extensions.Hosting.Systemd)
        * [`Microsoft.Extensions.Hosting.WindowsServices`](https://nuget.org/packages/Microsoft.Extensions.Hosting.WindowsServices)
    * **Http Client Factory**
        * [`Microsoft.Extensions.Http.Polly`](https://nuget.org/packages/Microsoft.Extensions.Http.Polly)
    * **Logging**
        * `Microsoft.Extensions.Logging.Analyzers` (has not been released to NuGet.org as of writing)
        * [`Microsoft.Extensions.DependencyInjection.Specification.Tests`](https://nuget.org/packages/Microsoft.Extensions.DependencyInjection.Specification.Tests)
* No longer shipping in 5.0
    * [`Microsoft.Extensions.DiagnosticAdapter`](https://nuget.org/packages/Microsoft.Extensions.DiagnosticAdapter)

---

## Get Started

Follow the [Get Started](https://www.microsoft.com/net) guide for .NET to setup an initial .NET application.
Microsoft.Extensions APIs can then be added to the project using the [NuGet Package Manager](https://nuget.org).

## How to Engage, Contribute, and Give Feedback

Some of the best ways to contribute are to try things out, file issues, join in design conversations,
and make pull-requests.

* [Download our latest daily builds](./docs/DailyBuilds.md)
* [Build .NET Extensions from source code](./docs/BuildFromSource.md)
* Check out the [contributing](CONTRIBUTING.md) page to see the best places to log issues and start discussions.

## Reporting security issues and bugs

Security issues and bugs should be reported privately, via email, to the Microsoft Security Response Center (MSRC)  secure@microsoft.com. You should receive a response within 24 hours. If for some reason you do not, please follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the [Security TechCenter](https://technet.microsoft.com/en-us/security/ff852094.aspx).

## Related projects

These are some other repos for related projects:

* [.NET Core](https://github.com/dotnet/core) - a cross-platform, open-source .NET platform
* [ASP.NET Core](https://github.com/dotnet/aspnetcore) - a .NET Core framework for building web apps
* [Entity Framework Core](https://github.com/dotnet/efcore) - data access technology

## Code of conduct

See [CODE-OF-CONDUCT](./CODE-OF-CONDUCT.md)

## Community forks

Some parts of this project have been forked by the community to add additional functionality:

#### [McMaster.Extensions.CommandLineUtils](https://github.com/natemcmaster/CommandLineUtils)

This is a fork of Microsoft.Extensions.CommandLineUtils.

 - GitHub: <https://github.com/natemcmaster/CommandLineUtils>
 - NuGet: <https://www.nuget.org/packages/McMaster.Extensions.CommandLineUtils>

---
https://help.smash.gg/en/articles/1987102-customizing-text-with-markdown

[`Fundamentals of Logging in .NET Core`](https://www.tutorialsteacher.com/core/fundamentals-of-logging-in-dotnet-core),

.NET Core SDK is a light weight SDK which includes a bare minimum set of features required to build an application. We can install NuGet packages for other features we require for our application. For this, Microsoft provides .NET APIs as .NET Extensions.

.NET Extensions is an open-source, cross-platform set of APIs for commonly used programming patterns and utilities, such as dependency injection, logging, and app configuration. Most APIs in this project are meant to work on many .NET platforms, such as .NET Core, .NET Framework, Xamarin, and other. While commonly used in ASP.NET Core applications, these APIs are not coupled to the ASP.NET Core application model. They can be used in console apps, WinForms and WPF, etc. You can find the documentation and the source code of extensions at [`https://github.com/aspnet/Extensions.`](https://github.com/aspnet/Extensions)

All the extensions are included under the Microsoft.Extensions namespace. You can find all built-in and third party extensions at [`nuget.org/packages`](https://www.nuget.org/packages?q=Microsoft.Extensions)

 The Logging API is included in the Microsoft.Extensions.Logging package. The Logging API does not work as standalone. It works with one or more logging providers that store or display logs to a particular medium such as Console, Debug, TraceListeners etc.

So, there are two important building blocks for implementing logging in a .NET Core based application: 

- Logging API 
- Logging Providers 

The following figure illustrates logging in .NET Core:

![alt text](https://www.tutorialsteacher.com/Content/images/core/logging-dotnet-core.png)

As you can see in the above figure, the logging API in Microsoft.Extensions.Logging works on the .NET Core based applications whether it is ASP.NET Core or EF Core. You just need to use the logging API with one or more logging providers to implement logging in any .NET Core based application.


## Logging API 

As mentioned before, Microsoft provides logging API as an extension in the wrapper [`Microsoft.Extensions.Logging`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging) which comes as a NuGet package. 

`Microsoft.Extensions.Logging` includes the necessary classes and interfaces for logging. The most important are the ILogger, ILoggerFactory, ILoggerProvider interfaces and the LoggerFactory class.

The following figure shows the relationship between logging classes.

![alt Logging API](https://www.tutorialsteacher.com/Content/images/core/logging-api.png)

>>>>>>>>>>>>Logging API

Let's have an overview of each of the above class. 


## ILoggerFactory

The `ILoggerFactory` is the factory interface for creating an appropriate ILogger type instance and also for adding the `ILoggerProvider` instance. 

```C#
public interface ILoggerFactory : IDisposable
{
    ILogger CreateLogger(string categoryName);
    void AddProvider(ILoggerProvider provider);
}
```

The Logging API includes the built-in `LoggerFactory` class that implements the `ILoggerFactory` interface. We can use it to add an instance of type `ILoggerProvider` and to retrieve the `ILogger` instance for the specified category. Visit `ILoggerFactory` and `LoggerFactory` for more information. 

## ILoggerProvider

The `ILoggerProvider` manages and creates an appropriate logger, specified by the logging category. 

```C#
public interface ILoggerProvider : IDisposable
{
    ILogger CreateLogger(string categoryName);
}
```

We can create our own logging provider by implementing the `ILoggerProvider` interface. Visit [`ILoggerProvider`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.iloggerprovider) for more information. 

## ILogger

The `ILogger` interface includes methods for logging to the underlying storage. There are many extension methods which make logging easy. Visit [`ILogger`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger) for more information. 

```C#
public interface ILogger
{
    void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter);
    bool IsEnabled(LogLevel logLevel);
    IDisposable BeginScope<TState>(TState state);
} 
```

## Logging Providers

A logging provider displays or stores logs to a particular medium such as a console, a debugging event, an event log, a trace listener, and others. Microsoft provides various logging providers as NuGet packages.

The following table lists important logging providers. 

| Logging Provider's NuGet Package | Output Target |
|---|---|
| [`Microsoft.Extensions.Logging.Console`](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Console/) | Console |
| [`Microsoft.Extensions.Logging.AzureAppServices`](https://www.nuget.org/packages/Microsoft.Extensions.Logging.AzureAppServices/) | Azure App Services 'Diagnostics logs' and 'Log stream' features |
| [`Microsoft.Extensions.Logging.Debug`](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Debug/) | Debugger Monitor |
| [`Microsoft.Extensions.Logging.EventLog`](https://www.nuget.org/packages/Microsoft.Extensions.Logging.EventLog/) | Windows Event Log |
| [`Microsoft.Extensions.Logging.EventSource`](https://www.nuget.org/packages/Microsoft.Extensions.Logging.EventSource/) | EventSource/EventListener |
| [`Microsoft.Extensions.Logging.TraceSource`](https://www.nuget.org/packages/Microsoft.Extensions.Logging.TraceSource/) | Trace Listener |

Microsoft has also collaborated with various logging framework teams (including third parties like NLog, Serilog, Loggr, Log4Net, and others) to extend the list of providers compatible with `Microsoft.Extensions.Logging`. The following are some thrid-party logging providers: 

| Logging Provider | Description |
|---|---|
| [`elmah.io`](elmah.io) | Provider for the Elmah.Io service |
| [`Loggr`](https://github.com/imobile3/Loggr.Extensions.Logging) | Provider for the Logger service |
| [`NLog`](https://github.com/NLog/NLog.Extensions.Logging) | Provider for the NLog library |
| [`Serilog`](https://github.com/serilog/serilog-framework-logging) | Provider for the Serilog library  |


Let's take an example using the `Microsoft.Extensions.Logging.Console` package which displays logs on the Console. 

## Console Logging Provider

Let's see how to display logs on the console using the NuGet package for a console provider.

The `Microsoft.Extensions.Logging.Console` package includes logging classes which send log output to the console.

The following figure illustrates how the logging API works with the console logging provider.

![alt Logging API with Console Logging Provider](https://www.tutorialsteacher.com/Content/images/core/console-logger.png)

>>>>>>>>>>>>>>>>>>>>>Logging API with Console Logging Provider

 As you can see in the above figure, the `ConsoleLogger` implements `ILogger`, while the `ConsoleLoggingProvider` implements `ILoggingProvider`. The `ConsoleLoggerExtensions` class includes extension method `AddConsole()`, which adds a console logger to the `LoggerFactory`.

Now, let's see how to display logs on the Console in the .NET Core console application.

First of all, create a new console application using the Console App (.NET Core) template in Visual Studio 2017 (or later).

Now, you need to install a NuGet package of `Microsoft.Extensions.Logging`. You can install it either using the NuGet Package Manager or executing the following command in the Package Manager Console.

```bash
PM> Install-Package Microsoft.Extensions.Logging
```

Now, you need to install a logging provider of your choice. Here, we will send logs on the Console, so, install the `Microsoft.Extensions.Logging.Console` package either using NPM or execute the following command in the Package Manager Console in Visual Studio.

```bash
PM> Install-Package Microsoft.Extensions.Logging.Console
```

After successfully installing the above two packages, you can now implement logging in your .NET Core console application, as shown below. 

### Example: Logging in .NET Core Console App
```C#
namespace DotnetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory(
                            new[] { new ConsoleLoggerProvider((_, __) => true, true) }
                        );
            //or
            //ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();
            
            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("This is log message.");
        }
    }
}
```

### Output
```bash
info: DotnetCoreConsoleApp.Program[0]
      This is log message. 
```

In the above example, we created an object of the `LoggerFactory` class and assigned it to the `ILoggerFactory` type variable, as shown below.

```C#
ILoggerFactory loggerFactory = new LoggerFactory(
    new[] { new ConsoleLoggerProvider ((_, __) => true, true) }
);
```

The `LoggerFactory` can contain one or more logging providers, which can be used to log to multiple mediums concurrently. The constructor of the `LoggerFactory` accepts an array of different logger provider objects as `new[] { }`. We want to display logs on the console, so we need to create an object of the console logger provider `ConsoleLoggerProvider`.

There are four constructors of the `ConsoleLoggerProvider`. Use the one that allows lambda expression (Func<>) for log filtration and includeScope Boolean. Here, we don't want to filter any information so the lambda expression would always return true `(_, __) => true`, as shown below. 

```C#
new ConsoleLoggerProvider((_, __) => true, true)
```

Then, we can use this object of the `LoggerFactory` to create a logger using which we can actually log information, errors, warnings, traces, debugs etc. `loggerFactory.CreateLogger<Program>()` creates a logger specific to the `Program` class so that the logger will display a message with context info, e.g. DotnetCoreConsoleApp.Program[0].

Most logging providers include an extension method of `ILoggerFactory`, which is a shortcut to add a provider to the logger factory. For example, to add a console logger provider to the `LoggerFactory`, just call the `LoggerFactory.AddConsole()` extension method with the same parameters as `ConsoleLoggerProvider`, as shown below. 

```C#
public ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();
```

This is more readable and maintainable than creating a logger provider manually. The above logger factory will display the same output as above.

## Log Levels

Log levels indicate the importance or severity of log messages. Built-in log providers include extension methods to indicate log levels.

The following table lists log levels in .NET Core. 

| Log Level  | Severity | Extension Method | Description |
|---|---|---|---|
| Trace | 0 | LogTrace() | Logs messages only for tracing purposes for the developers. |
| Debug | 1 | LogDebug() | Logs messages for short-term debugging purposes.  |
| Information | 2 | Logs messages for the flow of the application.  |
| Warning | 3| LogWarning() | Logs messages for abnormal or unexpected events in the application flow.  |
| Error | 4 | LogError() |Logs error messages.  |
| Critical | 5 | LogCritical() | Logs failures messages that require immediate attention.  |

We can use extension methods to indicate the level of the log messages as shown below. 

```C#
namespace DotnetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory().AddConsole((_, __) => true);
            ILogger logger = loggerFactory.CreateLogger<Program>();
    
            logger.LogInformation("Logging information.");
            logger.LogCritical("Logging critical information.");
            logger.LogDebug("Logging debug information.");
            logger.LogError("Logging error information.");
            logger.LogTrace("Logging trace");
            logger.LogWarning("Logging warning.");
        }
    }
}
```

The above example will display the following output:

![alt Logging API with Console Logging Provider](https://www.tutorialsteacher.com/Content/images/core/example-output.png)


