using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using BLL.RegEx;
using BLL.Interface;
using BLL.LogicClass;


namespace PL.ServiceForm
{
    public partial class RailRouteForm : Form
    {

        #region DrawButtonInfo

        Color BaseColor = Color.Gray;
        Color LockColor = Color.Red;
        int numLenght = 10;
        int numWieght = 4;
        int startX = 50;
        int startY = 65;
        int sizeX = 40;
        int sizeY = 40;
        int gapsX = 5;
        int gapsY = 5;

        #endregion


        #region Data

        private MainForm mainForm;
        private Button[,] buttons;
        private IRailRoute railRoute;

        private ISeat currentSeat;
        private string currntSeatNumber;

        #endregion



        //ctor
        public RailRouteForm(MainForm _mainForm, IRailRoute _railRoute)
        {
            InitializeComponent();

            mainForm = _mainForm;
            railRoute = _railRoute;


            //содная кнопок + подписки
            CreateSeatsButton();
            SubscribeUpdatesSeats();

            //Добавления даних к привязке
            AddDataInBingingNavigation();

            //Обновления даних по цвету
            UpdataSeatsAndRestrictCounter();

            //Отключения кнопок по-умолчанию
            DisEnableAllMenageButton();
        }



        #region ServiceMethod



        #region ButtonSeatsFunstion

        private void CreateSeatsButton()
        {
            int tempX = startX;
            int tempY = startY;


            buttons = new Button[numLenght, numWieght];
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(tempX, tempY);
                    buttons[i, j].Size = new Size(sizeX, sizeY);
                    buttons[i, j].BackColor = BaseColor;

                    buttons[i, j].Click += ButtonSeatsHeandler;

                    this.Controls.Add(buttons[i, j]);

                    tempX += sizeX + gapsX;
                }

                tempX = startX;
                tempY += sizeY + gapsY;
            }
        }
        private void ButtonSeatsHeandler(object sender, EventArgs e)
        {
            var currButton = sender as Button;

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (buttons[i, j].Location == currButton.Location)
                    {
                        var carrige = bindingSourceCarriges.Current as IRailwayCarriage;

                        currentSeat = carrige[i, j];

                        currntSeatNumber = ("Seat : " + (i + 1).ToString() + " : " + (j + 1).ToString());

                        SetCustomerInfo();
                    }
                }
            }
        }

        #endregion



        #region CustomInfo

        private void SetCustomerInfo()
        {
            ClearCustomInfo();


            labelSeat.Text = currntSeatNumber;
            labelPrice.Text = currentSeat.Price.ToString();


            if (currentSeat.WhenReserved() != null && currentSeat?.WhenReserved()?.Length >= 10)
            {
                labelWhenReserve.Text = currentSeat.WhenReserved().Substring(0, 10);
            }

            var customer = currentSeat.WhoReserved();

            if (customer != null)
            {
                textBoxName.Text = customer.Name;
                textBoxSurname.Text = customer.Surname;
                textAge.Text = customer.Age.ToString();
                textBoxPassportNumber.Text = customer.NumberOfPassport;

                buttonReserve.Enabled = false;
                buttonUnreserve.Enabled = true;
                buttonsSaveChange.Enabled = true;
            }
            else
            {
                buttonReserve.Enabled = true;
                buttonUnreserve.Enabled = false;
                buttonsSaveChange.Enabled = false;
            }
        }
        private void ClearCustomInfo()
        {
            labelSeat.Text = "Seat";

            labelPrice.Text = String.Empty;
            labelWhenReserve.Text = String.Empty;


            textBoxName.Text = String.Empty;
            textBoxSurname.Text = String.Empty;
            textAge.Text = String.Empty;
            textBoxPassportNumber.Text = String.Empty;

        }
        private void DisEnableAllMenageButton()
        {
            buttonReserve.Enabled = false;
            buttonUnreserve.Enabled = false;
            buttonsSaveChange.Enabled = false;
        }

        #endregion



        #region MenageButton

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (currentSeat.WhoReserved() == null)
            {
                try
                {

                    if (RegExpressions.Name.IsMatch(textBoxName.Text))
                    {
                        if (RegExpressions.Surname.IsMatch(textBoxSurname.Text))
                        {
                            if (RegExpressions.Age(int.Parse(textAge.Text)))
                            {
                                if (RegExpressions.NumberOfPassport.IsMatch(textBoxPassportNumber.Text))
                                {
                                    Customer customer = new Customer()
                                    {
                                        Name = textBoxName.Text,
                                        Surname = textBoxSurname.Text,
                                        Age = int.Parse(textAge.Text),
                                        NumberOfPassport = textBoxPassportNumber.Text,
                                    };

                                    currentSeat.Reserve(customer);


                                    SetCustomerInfo();
                                    UpdataSeatsAndRestrictCounter();

                                    return;
                                }
                            }
                        }
                    }


                    MessageBox.Show("Ведіть коректні дані");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ведіть коректні дані");
                }
            }
            else
            {
                MessageBox.Show("Місце вже зарезервовано");
            }

        }
        private void buttonsSaveChange_Click(object sender, EventArgs e)
        {
            if (currentSeat.WhoReserved() != null)
            {
                try
                {

                    if (RegExpressions.Name.IsMatch(textBoxName.Text))
                    {
                        if (RegExpressions.Surname.IsMatch(textBoxSurname.Text))
                        {
                            if (RegExpressions.Age(int.Parse(textAge.Text)))
                            {
                                if (RegExpressions.NumberOfPassport.IsMatch(textBoxPassportNumber.Text))
                                {
                                    ICustomer customer = currentSeat.WhoReserved();

                                    customer.Name = textBoxName.Text;
                                    customer.Surname = textBoxSurname.Text;
                                    customer.Age = int.Parse(textAge.Text);
                                    customer.NumberOfPassport = textBoxPassportNumber.Text;


                                    SetCustomerInfo();
                                    UpdataSeatsAndRestrictCounter();

                                    return;
                                }
                            }
                        }
                    }

                    MessageBox.Show("Ведіть коректні дані");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ведіть коректні дані");
                }
            }
            else
            {
                MessageBox.Show("Це місце не заброньовано");
            }
        }
        private void buttonUnreserve_Click(object sender, EventArgs e)
        {
            if (currentSeat.WhoReserved() != null)
            {
                try
                {
                    currentSeat.UnReserve();

                    SetCustomerInfo();
                    UpdataSeatsAndRestrictCounter();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ведіть коректні дані");
                }
            }
            else
            {
                MessageBox.Show("Це місце не заброньовано");
            }
        }

        #endregion



        #region UpdateSeatsInColor

        /// <summary>
        /// Обновления цвета кнопки
        /// </summary>
        private void UpdataSeatsAndRestrictCounter()
        {
            try
            {
                if (bindingSourceCarriges.List.Count >= railRoute.Train.MaxCarriages) { bindingNavigatorAddNewItem.Enabled = false; }
                else { bindingNavigatorAddNewItem.Enabled = true; }


                var carriage = bindingSourceCarriges.Current as IRailwayCarriage;


                if (bindingSourceCarriges.List.Count == 0)
                {
                    for (int i = 0; i < buttons.GetLength(0); i++)
                        for (int j = 0; j < buttons.GetLength(1); j++)
                            buttons[i, j].BackColor = BaseColor;
                }
                else
                {
                    for (int i = 0; i < buttons.GetLength(0); i++)
                    {
                        for (int j = 0; j < buttons.GetLength(1); j++)
                        {
                            if (carriage[i, j].IsReserve)
                                buttons[i, j].BackColor = LockColor;
                            else
                                buttons[i, j].BackColor = BaseColor;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some problem with UpdataSeat");
            }
        }
        private void UpdateSeatsAndRestrictCountHendler(object obj, EventArgs e)
        {
            UpdataSeatsAndRestrictCounter();
        }
        private void SubscribeUpdatesSeats()
        {
            bindingNavigatorPositionItem.TextChanged += UpdateSeatsAndRestrictCountHendler;

            bindingNavigatorMoveLastItem.Click += UpdateSeatsAndRestrictCountHendler;
            bindingNavigatorMoveFirstItem.Click += UpdateSeatsAndRestrictCountHendler;

            bindingNavigatorMovePreviousItem.Click += UpdateSeatsAndRestrictCountHendler;
            bindingNavigatorMoveNextItem.Click += UpdateSeatsAndRestrictCountHendler;

            bindingNavigatorDeleteItem.Click += UpdateSeatsAndRestrictCountHendler;
            bindingNavigatorAddNewItem.Click += UpdateSeatsAndRestrictCountHendler;
        }

        #endregion



        //Функция удаления для навгатора
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((bindingSourceCarriges.Current as IRailwayCarriage)?.IsAllFree() == true)
            {
                bindingSourceCarriges.RemoveCurrent();
            }
            else
            {
                MessageBox.Show("Неможливо видалити вагон бо є заьроньовані місця.");
            }
        }



        #region DataBindingFunction

        private void AddDataInBingingNavigation()
        {
            foreach (var item in railRoute.Train.Carriages)
            {
                bindingSourceCarriges.Add(new BaseRailwayCarriage(item as BaseRailwayCarriage));
            }
        }
        private void GetDataInMainForm()
        {
            var allCarrigesObj = bindingSourceCarriges.List;


            List<IRailwayCarriage> railwayCarriages = new List<IRailwayCarriage>();
            foreach (var item in allCarrigesObj)
                railwayCarriages.Add(item as IRailwayCarriage);



            //Unreserve all carriges
            foreach (var carriageOnRoute in railRoute.Train.Carriages)
                foreach (var item in carriageOnRoute.Seats)
                    item.UnReserve();


            railRoute.Train.Carriages.Clear();


            //add new carriges
            foreach (var item in railwayCarriages)
                railRoute.Train.AddCarriage(item);

        }

        #endregion


        #endregion



        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            GetDataInMainForm();

            mainForm.Show();
            mainForm.WriteInfoAboutCurrentRoute();

            this.Close();
        }



        #region Move Form

        Point lastPoint;
        private void RailRouteForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void RailRouteForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        #endregion

    }
}
