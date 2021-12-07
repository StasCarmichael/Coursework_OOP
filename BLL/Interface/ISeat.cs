namespace BLL.Interface
{
    public interface ISeat
    {
        bool IsReserve { get; }
        double Price { get;}

        ICustomer WhoReserved();
        string WhenReserved();

        bool Reserve(ICustomer customer);
        bool UnReserve();
    }
}
