using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ITrain
    {
        uint TrainNumber { get; set; }
        int MaxCarriages { get; }


        bool RemoveCarriage(IRailwayCarriage carriage);
        bool AddCarriage(IRailwayCarriage carriage);

        List<IRailwayCarriage> Carriages { get; }
    }
}
