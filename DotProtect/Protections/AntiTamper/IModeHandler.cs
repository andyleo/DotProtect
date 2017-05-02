using System;
using DotProtect.Core;

namespace DotProtect.Protections.AntiTamper {
	internal interface IModeHandler {
		void HandleInject(AntiTamperProtection parent, DotProtectContext context, ProtectionParameters parameters);
		void HandleMD(AntiTamperProtection parent, DotProtectContext context, ProtectionParameters parameters);
	}
}