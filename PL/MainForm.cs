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
using BLL.RegEx;
using PL.ServiceForm;


namespace PL
{
    public partial class MainForm : Form
    {
        private Form ViewForm;
        IRailwayTicketOffice railwayTicketOffice;

        public MainForm()
        {
            InitializeComponent();

            
            railwayTicketOffice = GetOffice();


            BindingData();

            AddDataInGrid();
        }


        private void BindingData()
        {
            dataGridViewRailRoute.DataSource = railRouteBindingSource;
        }

        private void AddDataInGrid()
        {
            railRouteBindingSource.Clear();

            foreach (var item in railwayTicketOffice.RailRoutes)
            {
                railRouteBindingSource.Add(item);
            }

            dataGridViewRailRoute.Update();
            Update();
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

            railRoute = new RailRoute()
            {
                NumberOfRoute = "AM3433",    
                From = "Stambul",
                To = "London",

            };
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());
            
            railwayTicketOffice.AddRailRoute(railRoute);


            return railwayTicketOffice;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            var railRoute = dataGridViewRailRoute.Rows[dataGridViewRailRoute.CurrentCell.RowIndex].DataBoundItem as IRailRoute;
          
            ViewForm = new RailRouteForm(railRoute);
            ViewForm.Show();
        }

        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            if (RegExpressions.NumberOfRoute.IsMatch(textBoxNumberOfRoute.Text))
            {
                if (textBoxTo.Text.Length > 0 && textBoxFrom.Text.Length > 0)
                {
                    try
                    {
                        IRailRoute railRoute = new RailRoute()
                        {
                            NumberOfRoute = textBoxNumberOfRoute.Text,
                            From = textBoxFrom.Text,
                            To = textBoxTo.Text
                        };
                        railwayTicketOffice.AddRailRoute(railRoute);

                        AddDataInGrid();

                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Перевірте коректність вводу даних.");
                    }
                }
            }

            MessageBox.Show("Перевірте коректність вводу даних.");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
