using System;

namespace DotProtect.Core {
	/// <summary>
	///     Base class of protection phases.
	/// </summary>
	public abstract class ProtectionPhase {
		/// <summary>
		///     Initializes a new instance of the <see cref="ProtectionPhase" /> class.
		/// </summary>
		/// <param name="parent">The parent component of this phase.</param>
		public ProtectionPhase(DotProtectComponent parent) {
			Parent = parent;
		}

		/// <summary>
		///     Gets the parent component.
		/// </summary>
		/// <value>The parent component.</value>
		public DotProtectComponent Parent { get; private set; }

		/// <summary>
		///     Gets the targets of protection.
		/// </summary>
		/// <value>The protection targets.</value>
		public abstract ProtectionTargets Targets { get; }

		/// <summary>
		///     Gets the name of the phase.
		/// </summary>
		/// <value>The name of phase.</value>
		public abstract string Name { get; }

		/// <summary>
		///     Gets a value indicating whether this phase process all targets, not just the targets that requires the component.
		/// </summary>
		/// <value><c>true</c> if this phase process all targets; otherwise, <c>false</c>.</value>
		public virtual bool ProcessAll {
			get { return false; }
		}

		/// <summary>
		///     Executes the protection phase.
		/// </summary>
		/// <param name="context">The working context.</param>
		/// <param name="parameters">The parameters of protection.</param>
		protected internal abstract void Execute(DotProtectContext context, ProtectionParameters parameters);
	}
}