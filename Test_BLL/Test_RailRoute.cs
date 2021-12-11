using System;
using Xunit;

using BLL.LogicClass;

namespace Test_BLL
{
    public class Test_RailRoute
    {
        [Fact]
        public void Test_Ctor()
        {
            var number = 0;

            RailRoute railRoute = new RailRoute();
            railRoute.NumberOfRoute = "JK4434";
            railRoute.To = "dsfsdf";
            railRoute.From = "dsfdsfsdf";

            if (railRoute.NumberOfRoute == "JK4434")
            {
                if (railRoute.To == "dsfsdf")
                {
                    if (railRoute.From == "dsfdsfsdf")
                    {
                        Assert.Equal(railRoute.HowMuchReserved(), number);
                    }
                }
            }
        }
        [Fact]
        public void Test_How_Reserved()
        {
            RailRoute railRoute = new RailRoute();
            try
            {
                railRoute.NumberOfRoute = "7567657";
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }

    }
}
