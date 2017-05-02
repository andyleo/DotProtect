using System;
using DotProtect.Core;

namespace DotProtect.Renamer {
	public interface INameReference {
		bool UpdateNameReference(DotProtectContext context, INameService service);

		bool ShouldCancelRename();
	}

	public interface INameReference<out T> : INameReference { }
}