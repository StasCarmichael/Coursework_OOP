using System;
using Xunit;

using BLL.LogicClass;


namespace Test_BLL
{
    public class Test_BaseRailwayCarriage
    {
        [Fact]
        public void Test_Customer_Name()
        {
            string data = "Stas";
            Customer customer = new Customer() { Name = data };
            BaseRailwayCarriage railwayCarriage = new BaseRailwayCarriage();
            railwayCarriage[0, 0].Reserve(customer);

            Assert.Equal(railwayCarriage[0,0].WhoReserved(), customer);
        }
        [Fact]
        public void Test_Copy_Ctor()
        {
            string data = "Stas";
            Customer customer = new Customer() { Name = data };
            BaseRailwayCarriage railwayCarriage = new BaseRailwayCarriage();
            railwayCarriage[0, 0].Reserve(customer);
            BaseRailwayCarriage baseRailwayCarriage = new BaseRailwayCarriage(railwayCarriage);

            Assert.Equal(baseRailwayCarriage[0, 0].WhoReserved().Name, data);
        }
        [Fact]
        public void Test_How_Reserved()
        {
            string data = "Stas";
            int number = 1;
            Customer customer = new Customer() { Name = data };
            BaseRailwayCarriage railwayCarriage = new BaseRailwayCarriage();
            railwayCarriage[0, 0].Reserve(customer);

            Assert.Equal(railwayCarriage.HowMuchReserved(), number);
        }
        [Fact]
        public void Test_IsFree()
        {
            BaseRailwayCarriage railwayCarriage = new BaseRailwayCarriage();

            Assert.True(railwayCarriage.IsAllFree());
        }
        [Fact]
        public void Test_NotIsFree()
        {
            string data = "Stas";
            Customer customer = new Customer() { Name = data };
            BaseRailwayCarriage railwayCarriage = new BaseRailwayCarriage();
            railwayCarriage[0, 0].Reserve(customer);

            Assert.False(railwayCarriage.IsAllFree());
        }


    }
}
