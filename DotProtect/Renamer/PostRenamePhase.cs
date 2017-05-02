using System;
using DotProtect.Core;
using dnlib.DotNet;

namespace DotProtect.Renamer {
	internal class PostRenamePhase : ProtectionPhase {
		public PostRenamePhase(NameProtection parent)
			: base(parent) { }

		public override bool ProcessAll {
			get { return true; }
		}

		public override ProtectionTargets Targets {
			get { return ProtectionTargets.AllDefinitions; }
		}

		public override string Name {
			get { return "Post-renaming"; }
		}

        protected internal override void Execute(DotProtectContext context, ProtectionParameters parameters) {
			var service = (NameService)context.Registry.GetService<INameService>();

			foreach (IRenamer renamer in service.Renamers) {
				foreach (IDnlibDef def in parameters.Targets)
					renamer.PostRename(context, service, parameters, def);
				context.CheckCancellation();
			}
		}
	}
}