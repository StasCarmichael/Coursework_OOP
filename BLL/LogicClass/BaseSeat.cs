using System;
using BLL.Interface;


namespace BLL.LogicClass
{
    [Serializable]
    public class BaseSeat : ISeat
    {
        #region Data

        private ICustomer customer;
        private string whenReserved;

        #endregion


        //ctor
        public BaseSeat()
        {
            customer = null;
            IsReserve = false;
            Price = 200;
        }


        public bool IsReserve { get; private set; }
        public double Price { get; private set; }


        public ICustomer WhoReserved() { return customer; }


        public string WhenReserved() { return whenReserved; }
        public bool Reserve(ICustomer customer)
        {
            if (IsReserve)
            {
                return false;
            }
            else
            {
                this.customer = customer;
                whenReserved = DateTime.Now.Date.ToString();
                IsReserve = true;
                return true;
            }
        }
        public bool UnReserve()
        {
            if (!IsReserve)
            {
                return false;
            }
            else
            {
                customer = null;
                whenReserved = String.Empty;
                IsReserve = false;
                return true;
            }
        }



    }
}
