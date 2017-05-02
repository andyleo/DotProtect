﻿using System;
using System.Collections.Generic;
using DotProtect.Core;
using DotProtect.Core.Services;
using DotProtect.DynCipher;
using DotProtect.Renamer;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace DotProtect.Protections.Constants {
	internal class CEContext {
		public DotProtectContext Context;
		public ConstantProtection Protection;
		public ModuleDef Module;

		public FieldDef BufferField;
		public FieldDef DataField;
		public TypeDef DataType;
		public MethodDef InitMethod;

		public int DecoderCount;
		public List<Tuple<MethodDef, DecoderDesc>> Decoders;

		public EncodeElements Elements;
		public List<uint> EncodedBuffer;

		public Mode Mode;
		public IEncodeMode ModeHandler;

		public IDynCipherService DynCipher;
		public IMarkerService Marker;
		public INameService Name;
		public RandomGenerator Random;

		public TypeDef CfgCtxType;
		public MethodDef CfgCtxCtor;
		public MethodDef CfgCtxNext;
		public Dictionary<MethodDef, List<Tuple<Instruction, uint, IMethod>>> ReferenceRepl;
	}

	internal class DecoderDesc {
		public object Data;
		public byte InitializerID;
		public byte NumberID;
		public byte StringID;
	}
}