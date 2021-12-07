using System.Collections.Generic;

namespace BLL.Interface
{
    public interface IRailwayTicketOffice
    {
        int CounteOfRoutes { get; }

        bool AddRailRoute(IRailRoute railRoute);
        bool RemoveRailRoute(IRailRoute railRoute);


        List<IRailRoute> RailRoutes { get; }
    }
}
