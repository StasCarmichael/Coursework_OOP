using System;
using Xunit;

using BLL.LogicClass;

namespace Test_BLL
{
    public class Test_BaseTrain
    {
        [Fact]
        public void Test_How_Much_Plase()
        {
            int number = 40;

            BaseTrain train = new BaseTrain();
            train.AddCarriage(new BaseRailwayCarriage());

            Assert.Equal(train.NumberOfSeats, number);
        }
        [Fact]
        public void Test_How_Reserved()
        {
            string data = "Stas";
            int number = 1;
            Customer customer = new Customer() { Name = data };
            BaseRailwayCarriage railwayCarriage = new BaseRailwayCarriage();
            

            BaseTrain train = new BaseTrain();
            train.AddCarriage(railwayCarriage);
            train.RemoveCarriage(railwayCarriage);
            
            railwayCarriage[0, 0].Reserve(customer);
            train.AddCarriage(railwayCarriage);

            Assert.Equal(train.HowMuchReserved(), number);
        }
        [Fact]
        public void Test_IsFree()
        {
            BaseTrain train = new BaseTrain();

            Assert.True(train.IsAllFree());
        }
        [Fact]
        public void Test_NotIsFree()
        {
            string data = "Stas";
            Customer customer = new Customer() { Name = data };
            BaseRailwayCarriage railwayCarriage = new BaseRailwayCarriage();
            railwayCarriage[0, 0].Reserve(customer);


            BaseTrain train = new BaseTrain();
            train.AddCarriage(railwayCarriage);


            Assert.False(train.IsAllFree());
        }

    }
}
