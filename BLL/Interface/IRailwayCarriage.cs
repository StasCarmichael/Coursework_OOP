using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
