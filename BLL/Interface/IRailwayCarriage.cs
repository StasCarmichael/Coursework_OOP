using System.Collections.Generic;

namespace BLL.Interface
{
    public interface IRailwayCarriage
    {
        int NumberOfSeatsInLength { get; }
        int NumberOfSeatsInWidth { get; }
        int NumberOfSeats { get; }


        bool IsAllFree();
        int HowMuchReserved();


        List<ISeat> Seats { get; }
        ISeat this[int numLength, int numWidht] { get; }
    }
}
