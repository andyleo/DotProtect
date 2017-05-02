using System;
using DotProtect.Core;
using DotProtect.Core.Services;
using DotProtect.DynCipher;
using DotProtect.Renamer;
using dnlib.DotNet;

namespace DotProtect.Protections.Resources {
	internal class REContext {
		public DotProtectContext Context;

		public FieldDef DataField;
		public TypeDef DataType;
		public IDynCipherService DynCipher;
		public MethodDef InitMethod;
		public IMarkerService Marker;

		public Mode Mode;

		public IEncodeMode ModeHandler;
		public ModuleDef Module;
		public INameService Name;
		public RandomGenerator Random;
	}
}