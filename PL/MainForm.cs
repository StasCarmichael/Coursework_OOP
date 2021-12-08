using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL.Provider;
using DataService;
using DataService.Interface;
using BLL.LogicClass;
using BLL.Interface;
using BLL.RegEx;
using PL.ServiceForm;


namespace PL
{
    public partial class MainForm : Form
    {

        private Form ViewForm;
        private IRailwayTicketOffice railwayTicketOffice;
        private IDataService<RailwayTicketOffice> dataService;



        public MainForm()
        {
            InitializeComponent();

            railwayTicketOffice = new RailwayTicketOffice();
            railwayTicketOffice = GetOffice();


            BindingDataSource();

            UpdataDataInGridView();
        }


        private void BindingDataSource()
        {
            dataGridViewRailRoute.DataSource = railRouteBindingSource;
        }
        private void UpdataDataInGridView()
        {
            railRouteBindingSource.Clear();

            foreach (var item in railwayTicketOffice?.RailRoutes)
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
            railRoute.Train.SerialTrainNumber = 100;
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());
            railRoute.Train.Carriages[0][0, 0].Reserve(new Customer());
            railRoute.Train.Carriages[0][2, 3].Reserve(new Customer());
            railRoute.Train.Carriages[0][6, 2].Reserve(new Customer());


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
            var railRoute = dataGridViewRailRoute.CurrentRow.DataBoundItem as IRailRoute;

            foreach (var item in railwayTicketOffice.RailRoutes)
            {
                if (item.Equals(railRoute))
                {
                    MessageBox.Show("good");
                }
            }

            ViewForm = new RailRouteForm(railRoute);
            ViewForm.Show();
        }



        #region AddRoute

        private void ClearAddInfo()
        {
            textBoxNumberOfRoute.Text = String.Empty;
            textBoxTo.Text = String.Empty;
            textBoxFrom.Text = String.Empty;
            textBoxTrainNumber.Text = String.Empty;
        }
        private void buttonAddRoute_Click(object sender, EventArgs e)
        {
            uint trainNumber = 0;

            if (RegExpressions.NumberOfRoute.IsMatch(textBoxNumberOfRoute.Text))
            {
                if (textBoxTo.Text.Length > 0 && textBoxFrom.Text.Length > 0)
                {
                    if (textBoxTrainNumber.Text.Length > 0 && uint.TryParse(textBoxTrainNumber.Text, out trainNumber))
                    {


                        try
                        {
                            bool granted = true;

                            var dataList = railRouteBindingSource.List;
                            foreach (var item in dataList)
                            {
                                if ((item as RailRoute)?.NumberOfRoute == textBoxNumberOfRoute.Text)
                                {
                                    granted = false;
                                }
                            }


                            if (granted)
                            {
                                IRailRoute railRoute = new RailRoute()
                                {
                                    NumberOfRoute = textBoxNumberOfRoute.Text,
                                    From = textBoxFrom.Text,
                                    To = textBoxTo.Text
                                };
                                railRoute.Train.SerialTrainNumber = trainNumber;



                                railwayTicketOffice.AddRailRoute(railRoute);

                                ClearAddInfo();

                                UpdataDataInGridView();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Рейс з даним номером вже існує");
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Перевірте коректність вводу даних.");
                        }


                    }
                }
            }

            MessageBox.Show("Перевірте коректність вводу даних.");
        }

        #endregion



        #region GetDataAboutRoute

        private void SetDataInTextBox(IRailRoute railRoute)
        {
            textBoxTrainId.Text = railRoute.Train.SerialTrainNumber.ToString();
            textBoxCountOfCarrige.Text = railRoute.Train.Carriages.Count.ToString() + "/" + railRoute.Train.MaxCarriages.ToString();
            textBoxCountOfReserveSeats.Text = railRoute.Train.HowMuchReserved().ToString() + "/" + railRoute.Train.NumberOfSeats.ToString() + " OR "
                + (double)(((double)railRoute.Train.HowMuchReserved()) / (double)(railRoute.Train.NumberOfSeats)) + "%";
        }
        private void dataGridViewRailRoute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var route = dataGridViewRailRoute.CurrentRow.DataBoundItem as IRailRoute;

                if (route != null)
                {
                    SetDataInTextBox(route);
                }
            }
            catch (Exception)
            {

            }

        }

        #endregion


        private void buttonExit_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
