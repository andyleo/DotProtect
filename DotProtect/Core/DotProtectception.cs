using System;

namespace DotProtect.Core {
	/// <summary>
	///     The exception that is thrown when a handled error occurred during the protection process.
	/// </summary>
	public class DotProtectception : Exception {
		/// <summary>
		///     Initializes a new instance of the <see cref="DotProtectception" /> class.
		/// </summary>
		/// <param name="innerException">The inner exception, or null if no exception is associated with the error.</param>
		public DotProtectception(Exception innerException)
			: base("Exception occurred during the protection process.", innerException) { }
	}
}