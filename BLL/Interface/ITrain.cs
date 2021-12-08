using System.Collections.Generic;

namespace BLL.Interface
{
    public interface ITrain
    {
        uint SerialTrainNumber { get; set; }
        int MaxCarriages { get; }
        int NumberOfSeats { get; }


        bool IsAllFree();
        int HowMuchReserved();


        bool RemoveCarriage(IRailwayCarriage carriage);
        bool AddCarriage(IRailwayCarriage carriage);

        List<IRailwayCarriage> Carriages { get; }
    }
}
