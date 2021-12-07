using BLL.Interface;
using BLL.RegEx;
using BLL.MyExceptions;


namespace BLL.LogicClass
{
    class RailRoute : IRailRoute
    {
        private string numberOfRoute;


        //ctor  
        public RailRoute() { Train = new BaseTrain(); }


        #region Propertics

        public string From { get; set; }
        public string To { get; set; }
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

        #endregion


        public ITrain Train { get; private set; }
    }
}
