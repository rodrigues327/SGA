namespace SMC.Infrastructure.SharedKernel.Interfaces
{
    public interface IDbContextFactory<T> where T : IDbContext
    {
        T Get();
    }
}