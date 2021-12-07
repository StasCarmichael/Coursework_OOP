using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using DataService;
using BLL.LogicClass;
using BLL.Interface;
using PL.ServiceForm;


namespace PL
{
    public partial class MainForm : Form
    {
        private Form ViewForm;

        public MainForm()
        {
            InitializeComponent();

            AddDataInGrid(GetOffice());
        }


        private void AddDataInGrid(IRailwayTicketOffice railwayTicketOffice)
        {
           dataGridViewRailRoute.DataSource = railwayTicketOffice.RailRoutes;

            int index = 0;
            foreach (var item in railwayTicketOffice.RailRoutes)
            {
                ColumnRoute.ValueType = typeof(System.String);

                dataGridViewRailRoute.Rows[index].Cells[3].Value = item.Train.Carriages.Count.ToString();
                index++;
            }                       
        }



        private IRailwayTicketOffice GetOffice()
        {
            IRailRoute railRoute = new RailRoute()
            {
                NumberOfRoute = "RY3242",
                From = "Kiev",
                To = "Gamburg",

            };
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());



            IRailwayTicketOffice railwayTicketOffice = new RailwayTicketOffice();
            railwayTicketOffice.AddRailRoute(railRoute);

            railRoute = new RailRoute()
            {
                NumberOfRoute = "TK2343",
                From = "Minsk",
                To = "Paris",

            };
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());


            railwayTicketOffice.AddRailRoute(railRoute);
            railRoute.NumberOfRoute = "AM3433";
            railwayTicketOffice.AddRailRoute(railRoute);


            return railwayTicketOffice;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show(dataGridViewRailRoute.CurrentCell.ColumnIndex.ToString());

            var railRoute = dataGridViewRailRoute.Rows[dataGridViewRailRoute.CurrentCell.RowIndex].DataBoundItem as IRailRoute;
            MessageBox.Show(railRoute.NumberOfRoute);


            ViewForm = new RailRouteForm(railRoute);
            ViewForm.Show();
        }
    }
}
