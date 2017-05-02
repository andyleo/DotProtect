using System;
using DotProtect.Core;
using dnlib.DotNet;

namespace DotProtect.Renamer {
	public interface IRenamer {
		void Analyze(DotProtectContext context, INameService service, ProtectionParameters parameters, IDnlibDef def);
		void PreRename(DotProtectContext context, INameService service, ProtectionParameters parameters, IDnlibDef def);
		void PostRename(DotProtectContext context, INameService service, ProtectionParameters parameters, IDnlibDef def);
	}
}