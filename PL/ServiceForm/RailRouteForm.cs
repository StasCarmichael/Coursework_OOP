using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL.Interface;
using BLL.LogicClass;


namespace PL.ServiceForm
{
    public partial class RailRouteForm : Form
    {
        private IRailRoute railRoute;

        public RailRouteForm(IRailRoute railRoute)
        {
            InitializeComponent();
            this.railRoute = railRoute;
        }
    }
}
