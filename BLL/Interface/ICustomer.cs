using System;
using System.Collections.Generic;

namespace BLL.Interface
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        string NumberOfPassport { get; set; }
    }
}
