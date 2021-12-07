using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IRailwayCarriage
    {
        int NumberOfSeatsInLength { get; set; }
        int NumberOfSeatsInWidth { get; set; }

        List<ISeat> Seats { get; set; }
        ISeat this[int numWidht, int numLength] { get; set; }
    }
}
