using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ISeat
    {
        bool IsReserve { get; }
        double Price { get; set; }
        bool Reserve(ICustomer customer);
    }
}
