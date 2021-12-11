using System;
using Xunit;

using BLL.LogicClass;

namespace Test_BLL
{
    public class Test_BaseSeat
    {
        [Fact]
        public void Test_Ctor_NO_param()
        {
            BaseSeat seat_1 = new BaseSeat();
            BaseSeat seat_2 = new BaseSeat();

            Assert.Equal(seat_1.Price, seat_2.Price);
        }
        [Fact]
        public void Test_Copy_Ctor()
        {
            BaseSeat seat_1 = new BaseSeat();
            var custome = new BLL.LogicClass.Customer("qeqqwe", "sdfsdf", 33, "345435345");
            seat_1.Reserve(custome);

            BaseSeat seat_2 = new BaseSeat(seat_1);

            Assert.Equal(custome.Name, seat_2.WhoReserved().Name);
        }
        [Fact]
        public void Test_Who_Reserve()
        {
            BaseSeat seat_1 = new BaseSeat();

            var customer = new BLL.LogicClass.Customer("qeqqwe", "sdfsdf", 33, "345435345");
            seat_1.Reserve(customer);
            seat_1.Reserve(customer);

            Assert.Equal(seat_1.WhoReserved(), customer);
        }
        [Fact]
        public void Test_UmReserve()
        {
            BaseSeat seat_1 = new BaseSeat();

            var customer = new BLL.LogicClass.Customer("qeqqwe", "sdfsdf", 33, "345435345");
            seat_1.Reserve(customer);
            seat_1.UnReserve();
            seat_1.UnReserve();

            Assert.Null(seat_1.WhoReserved()) ;
        }
        [Fact]
        public void Test_WhenReserve()
        {
            BaseSeat seat_1 = new BaseSeat();

            Assert.Null(seat_1.WhenReserved());
        }

    }
}
