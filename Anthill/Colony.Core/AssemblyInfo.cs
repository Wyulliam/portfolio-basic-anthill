﻿using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Colony.Tests")]
[assembly: InternalsVisibleTo("Colony.Data")]
[assembly: InternalsVisibleTo("Colony.Startup")]
//Reminder: This is necessary to the NSUbstitute to create a proxy of the interfaces
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
