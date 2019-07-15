using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Nursery.Tests")]
[assembly: InternalsVisibleTo("Nursery.Data")]
[assembly: InternalsVisibleTo("Nursery.Startup")]
[assembly: InternalsVisibleTo("Nursery.Core")]
//Reminder: This is necessary to the NSUbstitute to create a proxy of the interfaces
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
