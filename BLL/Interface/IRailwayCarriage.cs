using System.Collections.Generic;

namespace BLL.Interface
{
    public interface IRailwayCarriage
    {
        int NumberOfSeatsInLength { get; }
        int NumberOfSeatsInWidth { get; }


        bool IsAllFree();


        List<ISeat> Seats { get; }
        ISeat this[int numWidht, int numLength] { get; }
    }
}
