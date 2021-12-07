using BLL.Interface;

namespace BLL.LogicClass
{
    public class BaseSeat : ISeat
    {
        private ICustomer Customer;


        //ctor
        public BaseSeat()
        {
            Customer = null;
            IsReserve = false;
            Price = 200;
        }


        public bool IsReserve { get; private set; }
        public double Price { get; private set; }


        public ICustomer WhoReserved() { return Customer; }
        public bool Reserve(ICustomer customer)
        {
            if (IsReserve)
            {
                return false;
            }
            else
            {
                Customer = customer;
                return true;
            }
        }
    }
}
