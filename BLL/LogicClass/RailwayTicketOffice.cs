using System;
using System.Collections.Generic;

using BLL.Interface;

namespace BLL.LogicClass
{
    [Serializable]
    public class RailwayTicketOffice : IRailwayTicketOffice
    {
        private List<IRailRoute> railRoutes;

        //ctor
        public RailwayTicketOffice()
        {
            railRoutes = new List<IRailRoute>();
        }


        public int CounteOfRoutes { get { return RailRoutes.Count; } }
        public List<IRailRoute> RailRoutes { get { return railRoutes; } }


        #region Method

        public bool AddRailRoute(IRailRoute railRoute)
        {
            RailRoutes.Add(railRoute);
            return true;
        }
        public bool RemoveRailRoute(IRailRoute railRoute)
        {
            if (railRoute.Train.IsAllFree() == true)
            {
                return RailRoutes.Remove(railRoute);
            }

            return false;
        }

        #endregion
    }
}
