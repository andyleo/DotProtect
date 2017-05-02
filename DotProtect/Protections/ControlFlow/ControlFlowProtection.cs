﻿using System;
using DotProtect.Core;
using DotProtect.Protections.ControlFlow;
using dnlib.DotNet;

namespace DotProtect.Protections {
	public interface IControlFlowService {
		void ExcludeMethod(DotProtectContext context, MethodDef method);
	}

	internal class ControlFlowProtection : Protection, IControlFlowService {
		public const string _Id = "ctrl flow";
		public const string _FullId = "Ki.ControlFlow";
		public const string _ServiceId = "Ki.ControlFlow";

		public override string Name {
			get { return "Control Flow Protection"; }
		}

		public override string Description {
			get { return "This protection mangles the code in the methods so that decompilers cannot decompile the methods."; }
		}

		public override string Id {
			get { return _Id; }
		}

		public override string FullId {
			get { return _FullId; }
		}

		public override ProtectionPreset Preset {
			get { return ProtectionPreset.Normal; }
		}

		public void ExcludeMethod(DotProtectContext context, MethodDef method) {
			ProtectionParameters.GetParameters(context, method).Remove(this);
		}

        protected internal override void Initialize(DotProtectContext context) {
			context.Registry.RegisterService(_ServiceId, typeof(IControlFlowService), this);
		}

        protected internal override void PopulatePipeline(ProtectionPipeline pipeline) {
			pipeline.InsertPreStage(PipelineStage.OptimizeMethods, new ControlFlowPhase(this));
		}
	}
}