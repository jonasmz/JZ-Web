namespace JZ_Web.SharedKernel.Contracts
{
    public interface IBaseEntity<TId>
    {
        public TId Id { get; set; }
    }
}
