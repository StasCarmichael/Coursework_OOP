using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface;

namespace BLL.LogicClass
{
    public class Train : ITrain
    {
        private List<IRailwayCarriage> carriages;


        public Train()
        {
            TrainNumber = 0;
            MaxCarriages = 10;

            carriages = new List<IRailwayCarriage>();
        }



        public uint TrainNumber { get; set; }
        public int MaxCarriages { get; private set; }


        public List<IRailwayCarriage> Carriages
        {
            get => throw new NotImplementedException();
        }


        public bool AddCarriage(IRailwayCarriage carriage)
        {
            throw new NotImplementedException();
        }
        public bool RemoveCarriage(IRailwayCarriage carriage)
        {
            throw new NotImplementedException();
        }
    }
}
