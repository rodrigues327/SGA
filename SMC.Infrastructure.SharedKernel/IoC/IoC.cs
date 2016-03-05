using StructureMap;

namespace SMC.Infrastructure.SharedKernel.IoC
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            return new Container(c => c.AddRegistry<DefaultRegistry>());
        }
    }
}