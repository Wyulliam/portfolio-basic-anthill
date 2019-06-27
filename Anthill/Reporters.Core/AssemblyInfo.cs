using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Reporters.Tests")]
//Reminder: This is necessary to the NSUbstitute to create a proxy of the interfaces
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
