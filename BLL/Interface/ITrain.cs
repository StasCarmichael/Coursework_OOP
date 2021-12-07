using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ITrain
    {
        int MaxCarriages { get; set; }
        List<IRailwayCarriage> Carriages { get; set; }
    }
}
