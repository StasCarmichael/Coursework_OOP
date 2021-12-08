using System;

using BLL.Interface;
using BLL.RegEx;
using BLL.MyExceptions;


namespace BLL.LogicClass
{
    [Serializable]
    public class RailRoute : IRailRoute
    {
        private string numberOfRoute;


        //ctor  
        public RailRoute() { Train = new BaseTrain(); }


        #region Propertics

        public string NumberOfRoute
        {
            get
            {
                return numberOfRoute;
            }
            set
            {
                if (RegExpressions.NumberOfRoute.IsMatch(value))
                {
                    numberOfRoute = value;
                }
                else { throw new RegException("Prop NumberOfRoute Error"); }
            }
        }
        public string From { get; set; }
        public string To { get; set; }


        #endregion

        public int HowMuchReserved()
        {
            return Train.HowMuchReserved();
        }


        public ITrain Train { get; private set; }
    }
}
