using System;
using System.Collections.Generic;

using BLL.Interface;


namespace BLL.LogicClass
{
    [Serializable]
    public class BaseTrain : ITrain
    {
        private List<IRailwayCarriage> carriages;


        public BaseTrain()
        {
            SerialTrainNumber = 0;
            MaxCarriages = 10;

            carriages = new List<IRailwayCarriage>();
        }


        #region Propertis

        public uint SerialTrainNumber { get; set; }
        public int MaxCarriages { get; private set; }
        public int NumberOfSeats
        {
            get
            {
                int counter = 0;

                foreach (var item in Carriages)
                {
                    counter += item.NumberOfSeats;
                }

                return counter;
            }
        }


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
        public int HowMuchReserved()
        {
            int counter = 0;

            foreach (var item in Carriages)
            {
                counter += item.HowMuchReserved();
            }

            return counter;
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
