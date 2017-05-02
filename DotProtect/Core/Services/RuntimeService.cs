using System;
using System.IO;
using System.Reflection;
using dnlib.DotNet;

namespace DotProtect.Core.Services
{
    internal class RuntimeService : IRuntimeService
    {
        ModuleDef rtModule;

        /// <inheritdoc />
        public TypeDef GetRuntimeType(string fullName)
        {
            if (rtModule == null)
            {
                rtModule = ModuleDefMD.Load(typeof(RuntimeService).Assembly.ManifestModule);
                rtModule.EnableTypeDefFindCache = true;
            }
            return rtModule.Find(fullName, true);
        }
    }

    /// <summary>
    ///     Provides methods to obtain runtime library injection type.
    /// </summary>
    public interface IRuntimeService
    {
        /// <summary>
        ///     Gets the specified runtime type for injection.
        /// </summary>
        /// <param name="fullName">The full name of the runtime type.</param>
        /// <returns>The requested runtime type.</returns>
        TypeDef GetRuntimeType(string fullName);
    }
}