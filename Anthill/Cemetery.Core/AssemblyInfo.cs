﻿using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Cemetery.Tests")]
[assembly: InternalsVisibleTo("Cemetery.Data")]
[assembly: InternalsVisibleTo("Cemetery.Startup")]
//Reminder: This is necessary to the NSUbstitute to create a proxy of the interfaces
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
