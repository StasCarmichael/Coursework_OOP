using System;
using Xunit;

using BLL.LogicClass;

namespace Test_BLL
{
    public class Test_RailwayTicketOffice
    {
        [Fact]
        public void Test_Ctor()
        {
            var number = 1;

            RailwayTicketOffice railwayTicketOffice = new RailwayTicketOffice();

            RailRoute railRoute = new RailRoute();
            railRoute.NumberOfRoute = "JK4434";
            railRoute.To = "dsfsdf";
            railRoute.From = "dsfdsfsdf";

            railwayTicketOffice.AddRailRoute(railRoute);
            railwayTicketOffice.RemoveRailRoute(railRoute);

            railRoute.Train.AddCarriage(new BaseRailwayCarriage());
            railRoute.Train.Carriages[0][0, 0].Reserve(new Customer());

            railwayTicketOffice.AddRailRoute(railRoute);
            railwayTicketOffice.RemoveRailRoute(railRoute);

            if (railwayTicketOffice.CounteOfRoutes == number)
            {
                if (railwayTicketOffice.RailRoutes[0] == railRoute)
                {
                    Assert.True(true);
                }
            }
        }

    }
}
