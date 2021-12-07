using System.Collections.Generic;

namespace BLL.Interface
{
    public interface ITrain
    {
        uint TrainNumber { get; set; }
        int MaxCarriages { get; }

        bool IsAllFree();

        bool RemoveCarriage(IRailwayCarriage carriage);
        bool AddCarriage(IRailwayCarriage carriage);

        List<IRailwayCarriage> Carriages { get; }
    }
}
