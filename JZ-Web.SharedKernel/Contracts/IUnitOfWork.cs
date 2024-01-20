namespace JZ_Web.SharedKernel.Contracts
{
    public interface IUnitOfwork
    {
        ValueTask SaveChanges();
    }
}