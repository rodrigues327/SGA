using StructureMap;

namespace SGA.Infrastructure.SharedKernel.IoC
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            return new Container(c => c.AddRegistry<DefaultRegistry>());
        }
    }
}