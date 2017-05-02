using System;
using DotProtect.Core;
using dnlib.DotNet;

namespace DotProtect.Renamer.References {
	internal class CAMemberReference : INameReference<IDnlibDef> {
		readonly IDnlibDef definition;
		readonly CANamedArgument namedArg;

		public CAMemberReference(CANamedArgument namedArg, IDnlibDef definition) {
			this.namedArg = namedArg;
			this.definition = definition;
		}

		public bool UpdateNameReference(DotProtectContext context, INameService service) {
			namedArg.Name = definition.Name;
			return true;
		}

		public bool ShouldCancelRename() {
			return false;
		}
	}
}