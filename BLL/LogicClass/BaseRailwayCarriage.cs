using System;
using System.Collections.Generic;

using BLL.Interface;


namespace BLL.LogicClass
{
    [Serializable]
    public class BaseRailwayCarriage : IRailwayCarriage
    {

        #region Data_ServiceMethod

        private ISeat[,] seats;
        private void SetNewFreeBaseSeat()
        {
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    seats[i, j] = new BaseSeat();
                }
            }
        }

        #endregion


        //ctor
        public BaseRailwayCarriage()
        {
            NumberOfSeatsInLength = 10;
            NumberOfSeatsInWidth = 4;
            NumberOfSeats = NumberOfSeatsInLength * NumberOfSeatsInWidth;


            seats = new ISeat[NumberOfSeatsInLength, NumberOfSeatsInWidth];

            SetNewFreeBaseSeat();
        }
        public BaseRailwayCarriage(BaseRailwayCarriage railwayCarriage)
        {
            NumberOfSeatsInLength = railwayCarriage.NumberOfSeatsInLength;
            NumberOfSeatsInWidth = railwayCarriage.NumberOfSeatsInWidth; ;
            NumberOfSeats = NumberOfSeatsInLength * NumberOfSeatsInWidth;


            seats = new ISeat[NumberOfSeatsInLength, NumberOfSeatsInWidth];

            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    seats[i, j] = new BaseSeat(railwayCarriage[i,j] as BaseSeat);
                }
            }
        }


        public int NumberOfSeatsInLength { get; private set; }
        public int NumberOfSeatsInWidth { get; private set; }
        public int NumberOfSeats { get; set; }


        public bool IsAllFree()
        {
            foreach (var item in Seats)
            {
                if (item.IsReserve == true)
                {
                    return false;
                }
            }

            return true;
        }
        public int HowMuchReserved()
        {
            int counter = 0;

            foreach (var item in Seats)
            {
                if (item.IsReserve == true)
                {
                    counter++;
                }
            }

            return counter;
        }


        public List<ISeat> Seats
        {
            get
            {
                List<ISeat> listSeats = new List<ISeat>();

                for (int i = 0; i < seats.GetLength(0); i++)
                {
                    for (int j = 0; j < seats.GetLength(1); j++)
                    {
                        listSeats.Add(seats[i, j]);
                    }
                }

                return listSeats;
            }
        }
        public ISeat this[int numLength, int numWidht]
        {
            get
            {
                return seats[numLength, numWidht];
            }
        }
    }
}
