using System;
using DotProtect.Core;
using DotProtect.Renamer.BAML;
using dnlib.DotNet;

namespace DotProtect.Renamer.References {
	internal class BAMLAttributeReference : INameReference<IDnlibDef> {
		readonly AttributeInfoRecord attrRec;
		readonly IDnlibDef member;
		readonly PropertyRecord propRec;

		public BAMLAttributeReference(IDnlibDef member, AttributeInfoRecord rec) {
			this.member = member;
			attrRec = rec;
		}

		public BAMLAttributeReference(IDnlibDef member, PropertyRecord rec) {
			this.member = member;
			propRec = rec;
		}

		public bool UpdateNameReference(DotProtectContext context, INameService service) {
			if (attrRec != null)
				attrRec.Name = member.Name;
			else
				propRec.Value = member.Name;
			return true;
		}

		public bool ShouldCancelRename() {
			return false;
		}
	}
}