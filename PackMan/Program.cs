// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using PackMan.Telemetry;

Console.WriteLine("Hello, World!");

string currentVersion = Assembly.GetEntryAssembly()
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
    .InformationalVersion;

// Use the NuGet package manager to check for updates
var updateChecker = new UpdateChecker();
var updateAvailable = updateChecker.CheckForUpdates("myusername", "myrepository", currentVersion);

if (updateAvailable)
{
    Console.WriteLine("A new version is available. Please update your application.");
}
else
{
    Console.WriteLine("Your application is up to date.");
}
