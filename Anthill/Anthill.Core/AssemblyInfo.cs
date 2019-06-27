using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AntHill.Tests")]
[assembly: InternalsVisibleTo("AntHill.Startup")]
//Reminder: This is necessary to the NSUbstitute to create a proxy of the interfaces
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
