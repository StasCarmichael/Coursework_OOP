using System;
using System.Collections.Generic;
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
        #region Data

        private readonly string DB_path;
        private Form ViewForm;

        private RailwayTicketOffice railwayTicketOffice;

        private IDataService<RailwayTicketOffice> dataService;
        private IDataProvider<RailwayTicketOffice> dataProvider;

        #endregion


        //ctor
        public MainForm(string DB_path)
        {
            this.DB_path = DB_path;

            InitializeComponent();
            SetDataProviderAndDataService();

            railwayTicketOffice = new RailwayTicketOffice();

            railwayTicketOffice = dataService.GetData();


            SetDataInGridView();
        }



        #region ServiceMethod

        private void SetDataInGridView()
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

        #endregion



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
                                if ((item as IRailRoute)?.NumberOfRoute == textBoxNumberOfRoute.Text)
                                    granted = false;


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

                                SetDataInGridView();
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



        #region RemoveRoute

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
                SetDataInGridView();
                WriteInfoAboutCurrentRoute();

                MessageBox.Show("Рейс успішно видалений");
            }
            else { MessageBox.Show("Під час видалення сталася помилка!!!"); }
        }

        #endregion



        #region SetDataAboutRoute

        private void SetDataInTextBox(IRailRoute railRoute)
        {
            textBoxTrainId.Text = railRoute.Train.SerialTrainNumber.ToString();
            textBoxCountOfCarrige.Text = railRoute.Train.Carriages.Count.ToString() + "/" + railRoute.Train.MaxCarriages.ToString();

            string persentReserve = ((((double)railRoute.Train.HowMuchReserved()) / (double)(railRoute.Train.NumberOfSeats)) * 100).ToString();
            if (persentReserve.Length > 4) { persentReserve = persentReserve.Substring(0, 4); }

            textBoxCountOfReserveSeats.Text = railRoute.Train.HowMuchReserved().ToString() + "/" + railRoute.Train.NumberOfSeats.ToString() + " OR "
                + persentReserve + "%";
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
                MessageBox.Show("Сталася помилка в обробіці даних");
            }
        }
        private void dataGridViewRailRoute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            WriteInfoAboutCurrentRoute();
        }

        #endregion



        #region SearchData

        private void buttonSearchRoute_Click(object sender, EventArgs e)
        {
            if (RegExpressions.NumberOfRoute.IsMatch(textBoxSerchRoute.Text))
            {
                foreach (var item in railwayTicketOffice.RailRoutes)
                {
                    if (item.NumberOfRoute == textBoxSerchRoute.Text)
                    {
                        ViewForm = new RailRouteForm(this, item);
                        this.Hide();
                        ViewForm.Show();

                        return;
                    }
                }

                MessageBox.Show("Маршут з даним номером не знайдено");
            }
            else
            {
                MessageBox.Show("Ведіть коректні дані");
            }
        }
        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            List<ICustomer> searchedCustomer = new List<ICustomer>();
            string customerInfo = default;


            #region data

            bool _name = false;
            bool _surname = false;
            bool _age = false;
            bool _passportNumber = false;

            string name = default;
            string surname = default;
            int age = default;
            string passportNumber = default;

            #endregion


            try
            {
                if (textBoxName.Text.Length > 0)
                {
                    if (!RegExpressions.Name.IsMatch(textBoxName.Text)) { throw new Exception(); }

                    name = textBoxName.Text;
                    _name = true;
                }
                if (textBoxSurname.Text.Length > 0)
                {
                    if (!RegExpressions.Surname.IsMatch(textBoxSurname.Text)) { throw new Exception(); }

                    surname = textBoxSurname.Text;
                    _surname = true;
                }
                if (textAge.Text.Length > 0)
                {
                    if (!RegExpressions.Age(int.Parse(textAge.Text))) { throw new Exception(); }

                    age = int.Parse(textAge.Text);
                    _age = true;
                }
                if (textBoxPassportNumber.Text.Length > 0)
                {
                    if (!RegExpressions.NumberOfPassport.IsMatch(textBoxPassportNumber.Text)) { throw new Exception(); }

                    passportNumber = textBoxPassportNumber.Text;
                    _passportNumber = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ведіть коректні дані.");
                return;
            }


            if ((_name || _surname || _age || _passportNumber) == false)
            {
                MessageBox.Show("Задайте параметри для пошуку");
                return;
            }


            foreach (var route in railwayTicketOffice.RailRoutes)
            {
                int carrigeNumber = 1;
                foreach (var carriage in route.Train.Carriages)
                {
                    for (int rows = 0; rows < carriage.NumberOfSeatsInLength; rows++)
                    {
                        for (int seat = 0; seat < carriage.NumberOfSeatsInWidth; seat++)
                        {
                            ISeat currentSeat = carriage[rows, seat];


                            bool granted = true;
                            if (currentSeat.IsReserve)
                            {
                                ICustomer customer = currentSeat.WhoReserved();


                                #region CheckData

                                if (_name)
                                {
                                    if (!(customer.Name == name))
                                        granted = false;
                                }
                                if (_surname)
                                {
                                    if (!(customer.Surname == surname))
                                        granted = false;
                                }
                                if (_age)
                                {
                                    if (!(customer.Age == age))
                                        granted = false;
                                }
                                if (_passportNumber)
                                {
                                    if (!(customer.NumberOfPassport == passportNumber))
                                        granted = false;
                                }

                                #endregion


                                if (granted)
                                {
                                    searchedCustomer.Add(customer);


                                    customerInfo += $"Рейс з номером {route.NumberOfRoute}\n" +
                                        $"Вагон з порядковим номером {carrigeNumber}\n" +
                                        $"Сидіння з номером : ряд = {rows + 1} місце =  {seat + 1}\n\n\n";
                                }
                            }
                        }
                    }

                    carrigeNumber++;
                }
            }

            if (searchedCustomer.Count > 0)
            {
                MessageBox.Show(customerInfo);
            }
            else
            {
                MessageBox.Show("Клієнта з такими даними немає !!!");
            }

        }

        #endregion



        #region Exit

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save data
            dataService.AddNewData(railwayTicketOffice);
        }
        private void buttonExit_Click(object sender, EventArgs e) { Application.Exit(); }



        #endregion


    }
}
