namespace SGA.Infrastructure.Data.Context
{
    public interface IDbContextFactory<T> where T : IDbContext
    {
        T Get();
    }
}