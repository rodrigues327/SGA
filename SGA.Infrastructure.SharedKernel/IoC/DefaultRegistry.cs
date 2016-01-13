using StructureMap.Graph;
using System;
using System.Reflection;

namespace SGA.Infrastructure.SharedKernel.IoC
{
    public class DefaultRegistry : StructureMap.Registry
    {
        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.WithDefaultConventions();
                    scan.AssembliesFromApplicationBaseDirectory(WithinNamespace);
                    scan.LookForRegistries();
                });
        }

        private static readonly Func<Assembly, bool> WithinNamespace = o => o.FullName.Contains("SGA") && !o.FullName.Contains("Test");
    }
}