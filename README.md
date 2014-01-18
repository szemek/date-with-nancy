## Date with Nancy on OS X

1. Download Mono MDK: http://www.go-mono.com/mono-downloads/download.html
2. Download Xamarin Studio: http://monodevelop.com/Download
3. Install NuGet AddIn: https://github.com/mrward/monodevelop-nuget-addin
4. Create C# Console Project
5. __Manage Nuget Packages...__ and add `Nancy` and `Nancy.Hosting.Self` packages.
6. In `Program.cs` at the top add:

```csharp
  using Nancy;
  using Nancy.Hosting.Self;
```

in `Main` method add:

```csharp
  using (var host = new NancyHost(new Uri("http://localhost:3000")))
  {
    host.Start();
    Console.ReadLine();
  }
```

7. Add empty C# class `HelloModule` and replace with following code:

```csharp
using System;
using Nancy;

public class HelloModule : NancyModule
{
  public HelloModule()
  {
    Get["/"] = parameters => "Hello World";
  }
}
```

8. Check http://localhost:3000
