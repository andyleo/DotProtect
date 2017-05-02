using System;
using System.Collections.Generic;
using DotProtect.Core;
using DotProtect.Core.Services;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace DotProtect.Protections.AntiTamper {
	internal enum Mode {
		Normal,
		Dynamic
	}

	internal interface IKeyDeriver {
		void Init(DotProtectContext ctx, RandomGenerator random);
		uint[] DeriveKey(uint[] a, uint[] b);
		IEnumerable<Instruction> EmitDerivation(MethodDef method, DotProtectContext ctx, Local dst, Local src);
	}
}