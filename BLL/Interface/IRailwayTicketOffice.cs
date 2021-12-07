﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public  interface IRailwayTicketOffice
    {
        int MaxTrains { get; set; }
        List<ITrain> Trains { get; set; }
    }
}
