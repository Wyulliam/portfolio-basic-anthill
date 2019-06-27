using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Reporters.Tests")]
[assembly: InternalsVisibleTo("Reporters.Startup")]
//Reminder: This is necessary to the NSUbstitute to create a proxy of the interfaces
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
