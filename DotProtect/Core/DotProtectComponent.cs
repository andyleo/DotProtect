using System;

namespace DotProtect.Core {
	/// <summary>
	///     Represent a component in DotProtect
	/// </summary>
	public abstract class DotProtectComponent {
		/// <summary>
		///     Gets the name of component.
		/// </summary>
		/// <value>The name of component.</value>
		public abstract string Name { get; }

		/// <summary>
		///     Gets the description of component.
		/// </summary>
		/// <value>The description of component.</value>
		public abstract string Description { get; }

		/// <summary>
		///     Gets the identifier of component used by users.
		/// </summary>
		/// <value>The identifier of component.</value>
		public abstract string Id { get; }

		/// <summary>
		///     Gets the full identifier of component used in DotProtect.
		/// </summary>
		/// <value>The full identifier of component.</value>
		public abstract string FullId { get; }

		/// <summary>
		///     Initializes the component.
		/// </summary>
		/// <param name="context">The working context.</param>
		protected internal abstract void Initialize(DotProtectContext context);

		/// <summary>
		///     Inserts protection stages into processing pipeline.
		/// </summary>
		/// <param name="pipeline">The processing pipeline.</param>
		protected internal abstract void PopulatePipeline(ProtectionPipeline pipeline);
	}
}