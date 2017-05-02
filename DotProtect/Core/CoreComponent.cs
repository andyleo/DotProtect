using System;
using DotProtect.Core.API;
using DotProtect.Core.Services;

namespace DotProtect.Core {
	/// <summary>
	///     Core component of DotProtect.
	/// </summary>
	public class CoreComponent : DotProtectComponent {
		/// <summary>
		///     The service ID of RNG
		/// </summary>
		public const string _RandomServiceId = "DotProtect.Random";

		/// <summary>
		///     The service ID of Marker
		/// </summary>
		public const string _MarkerServiceId = "DotProtect.Marker";

		/// <summary>
		///     The service ID of Trace
		/// </summary>
		public const string _TraceServiceId = "DotProtect.Trace";

		/// <summary>
		///     The service ID of Runtime
		/// </summary>
		public const string _RuntimeServiceId = "DotProtect.Runtime";

		/// <summary>
		///     The service ID of Compression
		/// </summary>
		public const string _CompressionServiceId = "DotProtect.Compression";

		/// <summary>
		///     The service ID of API Store
		/// </summary>
		public const string _APIStoreId = "DotProtect.APIStore";

		readonly Marker marker;
		readonly DotProtectParameters parameters;

		/// <summary>
		///     Initializes a new instance of the <see cref="CoreComponent" /> class.
		/// </summary>
		/// <param name="parameters">The parameters.</param>
		/// <param name="marker">The marker.</param>
		internal CoreComponent(DotProtectParameters parameters, Marker marker) {
			this.parameters = parameters;
			this.marker = marker;
		}

		/// <inheritdoc />
		public override string Name {
			get { return "DotProtect Core"; }
		}

		/// <inheritdoc />
		public override string Description {
			get { return "Initialization of DotProtect core services."; }
		}

		/// <inheritdoc />
		public override string Id {
			get { return "DotProtect.Core"; }
		}

		/// <inheritdoc />
		public override string FullId {
			get { return "DotProtect.Core"; }
		}

		/// <inheritdoc />
		protected internal override void Initialize(DotProtectContext context) {
			context.Registry.RegisterService(_RandomServiceId, typeof(IRandomService), new RandomService(parameters.Project.Seed));
			context.Registry.RegisterService(_MarkerServiceId, typeof(IMarkerService), new MarkerService(context, marker));
			context.Registry.RegisterService(_TraceServiceId, typeof(ITraceService), new TraceService(context));
			context.Registry.RegisterService(_RuntimeServiceId, typeof(IRuntimeService), new RuntimeService());
			context.Registry.RegisterService(_CompressionServiceId, typeof(ICompressionService), new CompressionService(context));
			context.Registry.RegisterService(_APIStoreId, typeof(IAPIStore), new APIStore(context));
		}

		/// <inheritdoc />
		protected internal override void PopulatePipeline(ProtectionPipeline pipeline) {
			//
		}
	}
}