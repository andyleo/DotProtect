using System;
using DotProtect.Core;

namespace DotProtect.DynCipher
{
    internal class DynCipherComponent : DotProtectComponent
    {
        public const string _ServiceId = "DotProtect.DynCipher";

        public override string Name
        {
            get { return "Dynamic Cipher"; }
        }

        public override string Description
        {
            get { return "Provides dynamic cipher generation services."; }
        }

        public override string Id
        {
            get { return _ServiceId; }
        }

        public override string FullId
        {
            get { return _ServiceId; }
        }

        protected internal override void Initialize(DotProtectContext context)
        {
            context.Registry.RegisterService(_ServiceId, typeof(IDynCipherService), new DynCipherService());
        }

        protected internal override void PopulatePipeline(ProtectionPipeline pipeline)
        {
            //
        }
    }
}