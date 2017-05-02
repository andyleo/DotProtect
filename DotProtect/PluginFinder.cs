using DotProtect.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotProtect
{
    /// <summary>
    /// Finds protection types
    /// </summary>
    public static class PluginFinder
    {
        /// <summary>
        /// Finds protection types.
        /// </summary>
        /// <param name="protections">The protections.</param>
        /// <param name="packers">The packers.</param>
        /// <param name="components">The components.</param>
        public static void Find(out IList<Protection> protections, out IList<Packer> packers, out IList<DotProtectComponent> components)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();

            var all = new List<Type>(currentAssembly.GetTypes().Where(x => typeof(DotProtectComponent).IsAssignableFrom(x) && !x.IsAbstract && x.GetConstructor(Type.EmptyTypes) != null));

            protections = new List<Protection>();
            packers = new List<Packer>();
            components = new List<DotProtectComponent>();

            foreach (var item in all)
            {
                if (typeof(Protection).IsAssignableFrom(item))
                {
                    protections.Add(Activator.CreateInstance(item) as Protection);
                }
                else if (typeof(Packer).IsAssignableFrom(item))
                {
                    packers.Add(Activator.CreateInstance(item) as Packer);
                }
                else if (typeof(DotProtectComponent).IsAssignableFrom(item))
                {
                    components.Add(Activator.CreateInstance(item) as DotProtectComponent);
                }
            }
        }
    }
}
