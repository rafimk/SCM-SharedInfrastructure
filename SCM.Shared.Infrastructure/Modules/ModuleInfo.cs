using System.Collections.Generic;

namespace SCM.Shared.Infrastructure.Modules;

internal record ModuleInfo(string Name, IEnumerable<string> Policies);