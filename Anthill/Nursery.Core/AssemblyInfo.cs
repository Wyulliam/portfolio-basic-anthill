using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Nursery.Tests")]
[assembly: InternalsVisibleTo("Nursery.Data")]
//Reminder: This is necessary to the NSUbstitute to create a proxy of the interfaces
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
