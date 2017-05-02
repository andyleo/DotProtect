using System;
using DotProtect.Core;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace DotProtect.Renamer.References {
	public class StringTypeReference : INameReference<TypeDef> {
		readonly Instruction reference;
		readonly TypeDef typeDef;

		public StringTypeReference(Instruction reference, TypeDef typeDef) {
			this.reference = reference;
			this.typeDef = typeDef;
		}

		public bool UpdateNameReference(DotProtectContext context, INameService service) {
			reference.Operand = typeDef.ReflectionFullName;
			return true;
		}

		public bool ShouldCancelRename() {
			return false;
		}
	}
}