using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL.Interface;
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
        private readonly string DB_path;
        private Form ViewForm;
        private RailwayTicketOffice railwayTicketOffice;
        private IDataService<RailwayTicketOffice> dataService;
        private IDataProvider<RailwayTicketOffice> dataProvider;


        public MainForm(string DB_path)
        {
            this.DB_path = DB_path;


            InitializeComponent();


            railwayTicketOffice = new RailwayTicketOffice();


            railwayTicketOffice = GetOffice();

            SetDataProviderAndDataService();

            //dataService.AddNewData(railwayTicketOffice);

            //railwayTicketOffice = dataService.GetData();



            UpdataDataInGridView();
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
        private void SetDataProviderAndDataService()
        {
            dataProvider = new BinaryProvider<RailwayTicketOffice>(DB_path);

            dataService = new EntityService<RailwayTicketOffice>(dataProvider);
        }



        private RailwayTicketOffice GetOffice()
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



            RailwayTicketOffice railwayTicketOffice = new RailwayTicketOffice();
            railwayTicketOffice.AddRailRoute(railRoute);

            railRoute = new RailRoute()
            {
                NumberOfRoute = "TK2343",
                From = "Minsk",
                To = "Paris",

            };
            railRoute.Train.SerialTrainNumber = 100;
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());
            railRoute.Train.Carriages[0][0, 0].Reserve(new Customer() { Name = "Igor" , Surname = "Valilew" , Age = 15 , NumberOfPassport = "034174936"});
            railRoute.Train.Carriages[0][2, 3].Reserve(new Customer() { Name = "Igor", Surname = "Valilew", Age = 15, NumberOfPassport = "034174936" });
            railRoute.Train.Carriages[0][6, 2].Reserve(new Customer() { Name = "Igor", Surname = "Valilew", Age = 15, NumberOfPassport = "034174936" });


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
            var railRoute = dataGridViewRailRoute?.CurrentRow?.DataBoundItem as IRailRoute;

            if (railRoute == null) { MessageBox.Show("Немає запланованих рейсів."); return; }
                       
            ViewForm = new RailRouteForm(this, railRoute);
            this.Hide();
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



        #region SetDataAboutRoute

        private void SetDataInTextBox(IRailRoute railRoute)
        {
            textBoxTrainId.Text = railRoute.Train.SerialTrainNumber.ToString();
            textBoxCountOfCarrige.Text = railRoute.Train.Carriages.Count.ToString() + "/" + railRoute.Train.MaxCarriages.ToString();
            textBoxCountOfReserveSeats.Text = railRoute.Train.HowMuchReserved().ToString() + "/" + railRoute.Train.NumberOfSeats.ToString() + " OR "
                + (double)(((double)railRoute.Train.HowMuchReserved()) / (double)(railRoute.Train.NumberOfSeats)) + "%";
        }
        public void WriteInfoAboutCurrentRoute()
        {
            try
            {
                var route = dataGridViewRailRoute.CurrentRow.DataBoundItem as IRailRoute;

                if (route != null)
                    SetDataInTextBox(route);

            }
            catch (Exception)
            {

            }
        }
        private void dataGridViewRailRoute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            WriteInfoAboutCurrentRoute();
        }

        #endregion



        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var railRoute = dataGridViewRailRoute?.CurrentRow?.DataBoundItem as IRailRoute;


            if (railRoute == null) { MessageBox.Show("Немає запланованих рейсів."); return; }


            if (!railRoute.Train.IsAllFree())
            {
                MessageBox.Show("Рейс видалити неможливо оскількі є зарезервовані місця");
                return;
            }

            if (railwayTicketOffice.RemoveRailRoute(railRoute))
            {
                UpdataDataInGridView();
                WriteInfoAboutCurrentRoute();

                MessageBox.Show("Рейс успішно видалений");
            }
            else { MessageBox.Show("Під час видалення сталася помилка!!!"); }
        }



        private void buttonExit_Click(object sender, EventArgs e) { Application.Exit(); }

    }
}
