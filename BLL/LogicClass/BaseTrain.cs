using System.Collections.Generic;

using BLL.Interface;


namespace BLL.LogicClass
{
    public class BaseTrain : ITrain
    {
        private List<IRailwayCarriage> carriages;


        public BaseTrain()
        {
            TrainNumber = 0;
            MaxCarriages = 10;

            carriages = new List<IRailwayCarriage>();
        }


        #region Propertis

        public uint TrainNumber { get; set; }
        public int MaxCarriages { get; private set; }

        public List<IRailwayCarriage> Carriages
        {
            get
            {
                return carriages;
            }
        }

        #endregion


        #region Methood
        public bool IsAllFree()
        {
            foreach (var item in Carriages)
            {
                if (item.IsAllFree() == false)
                {
                    return false;
                }
            }

            return true;
        }


        public bool AddCarriage(IRailwayCarriage carriage)
        {
            if (carriages.Count < MaxCarriages)
            {
                carriages.Add(carriage);
                return true;
            }

            return false;
        }
        public bool RemoveCarriage(IRailwayCarriage carriage)
        {
            if (carriage.IsAllFree())
            {
                return carriages.Remove(carriage);
            }

            return false;
        }

        #endregion
    }
}
