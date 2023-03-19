# Drycodes.NET-Wrapper
A [names.drycodes.com](https://names.drycodes.com) API wrapper for .NET, serving the purpose of random name generation. 

## What actually is this?
This is an API wrapper for the site listed above. This site provides a variety of random name and number generators through an API. All of which is deserialized via JSON and fed to you in an easy-to-use form via a variety of methods.

## How can I use it?
You have two options, you can either reference the [NuGet package](https://www.nuget.org/packages/Drycodes.NET/), or you can download one of the releases and directly reference the DLL assembly.

### Okay, I've added it to my project... what now?
Drycodes.NET is super simple, and extremely easy. To begin using it in your code, do the following:

```csharp           
DrycodesApi api = new();
```

Now you have created a Drycodes API object and you can use a variety of the methods via your `api` object.

Here is an example: 
```csharp
string boyName = api.GenerateBoyName();
Console.WriteLine(boyName);
```
And... boom! It's as simple as that. The following code will simply generate one random boy name and output it to the console.

If you want to generate a list (or array, to be more specific) of names, you can do the following:
```csharp
string[] objects = api.GenerateObjects();
foreach(string obj in objects){
  Console.WriteLine(obj);
}
```
The following code will retrieve 10 random objects, iterate through each one and output it to the console.

There are a couple of parameters that are defaulted, but you can modify them to your liking, here are a couple examples:
```csharp
string[] planets = api.GeneratePlanets(100);
```
This will generate 100 planets and store them in the string array. The default quantity, without any arguments is 10.

The last parameter is a seperator between the spaces between words, this is really done for one reason, and that's because the API automatically swaps spaces for underscores. With this wrapper, I made it a bit easier for all of you and got rid of all those by default, but you can change the seperator (if you want) like so:
```csharp
string game = api.GenerateGame("_!_");
Console.WriteLine(game);
```

This will generate something along the lines of `Mario_!_Party`. You can even remove the space entirely by just using `""` for the seperator and that'll remove all spaces.

Thanks for checking this out. If you have any questions, or issues, feel free to let me know! PRs are always welcome :)

