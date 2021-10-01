# OpenFaaS ASPNET Functions

Function setup with Newtonsoft formatters.

Learn more about the [template](https://github.com/goncalo-oliveira/faas-aspnet-template).

Learn more about [OpenFaas](https://github.com/openfaas/faas).

# Usage

> This requires template version 1.5. Prior to this version, Newtonsoft is the default serializer.

Install the package with NuGet

```
dotnet add package OpenFaaS.Functions.Newtonsoft
```

Then, configure the function to use Newtonsoft in your `Startup` file. If you are using the regular function template, the function already returns an `IHttpFunctionBuilder`, so you just need to add one line.

```csharp
public void ConfigureServices( IServiceCollection services )
{
    services.AddHttpFunction<Function>()
        .AddNewtonsoftJson();

    // add your services here.
}
```

If instead you are using the `controller` template, you can do the following to retrieve an `IHttpFunctionBuilder` first and then add the same one line.

```csharp
public void ConfigureServices( IServiceCollection services )
{
    services.ConfigureHttpFunction()
        .AddNewtonsoftJson();

    // add your services here.
}
```

And naturally, you can customize the serialization settings

```csharp
public void ConfigureServices( IServiceCollection services )
{
    services.ConfigureHttpFunction()
        .AddNewtonsoftJson( options =>
        {
            options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        } );

    // add your services here.
}
```
