using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Colony.Tests")]
[assembly: InternalsVisibleTo("Colony.Data")]
//Reminder: This is necessary to the NSUbstitute to create a proxy of the interfaces
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
