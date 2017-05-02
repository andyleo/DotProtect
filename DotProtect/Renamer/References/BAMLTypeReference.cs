using System;
using DotProtect.Core;
using DotProtect.Renamer.BAML;
using dnlib.DotNet;

namespace DotProtect.Renamer.References {
	internal class BAMLTypeReference : INameReference<TypeDef> {
		readonly TypeInfoRecord rec;
		readonly TypeSig sig;

		public BAMLTypeReference(TypeSig sig, TypeInfoRecord rec) {
			this.sig = sig;
			this.rec = rec;
		}

		public bool UpdateNameReference(DotProtectContext context, INameService service) {
			rec.TypeFullName = sig.ReflectionFullName;
			return true;
		}

		public bool ShouldCancelRename() {
			return false;
		}
	}
}