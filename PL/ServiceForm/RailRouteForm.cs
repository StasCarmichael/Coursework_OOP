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

        #region DrawButton

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


        private Button[,] buttons;
        private IRailRoute railRoute;



        #region ServiceMethod

        private void CreateButton()
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


                    this.Controls.Add(buttons[i, j]);

                    tempX += sizeX + gapsX;
                }

                tempX = startX;
                tempY += sizeY + gapsY;
            }
        }
        private void UpdateSeatsAndRestrictCountOfCarrige(object obj, EventArgs e)
        {
            try
            {
                if (bindingSourceCarriges.List.Count >= railRoute.Train.MaxCarriages) { bindingNavigatorAddNewItem.Enabled = false; }
                else { bindingNavigatorAddNewItem.Enabled = true; }


                var carriage = bindingSourceCarriges.Current as IRailwayCarriage;


                if (bindingSourceCarriges.List.Count == 0)
                {
                    for (int i = 0; i < numLenght; i++)
                        for (int j = 0; j < numWieght; j++)
                            buttons[i, j].BackColor = BaseColor;
                }
                else
                {
                    for (int i = 0; i < numLenght; i++)
                    {
                        for (int j = 0; j < numWieght; j++)
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
        private void SubscribeUpdatesSeat()
        {
            bindingNavigatorPositionItem.TextChanged += UpdateSeatsAndRestrictCountOfCarrige;

            bindingNavigatorMoveLastItem.Click += UpdateSeatsAndRestrictCountOfCarrige;
            bindingNavigatorMoveFirstItem.Click += UpdateSeatsAndRestrictCountOfCarrige;

            bindingNavigatorMovePreviousItem.Click += UpdateSeatsAndRestrictCountOfCarrige;
            bindingNavigatorMoveNextItem.Click += UpdateSeatsAndRestrictCountOfCarrige;

            bindingNavigatorDeleteItem.Click += UpdateSeatsAndRestrictCountOfCarrige;
            bindingNavigatorAddNewItem.Click += UpdateSeatsAndRestrictCountOfCarrige;
        }


        private void AddDataInBingingSourse()
        {
            foreach (var item in railRoute.Train.Carriages)
            {
                bindingSourceCarriges.Add(item);
            }
        }
        private void GetDataInMainForm()
        {
            var allCarrigesObj = bindingSourceCarriges.List;


            List<IRailwayCarriage> railwayCarriages = new List<IRailwayCarriage>();
            foreach (var item in allCarrigesObj)
            {
                railwayCarriages.Add(item as IRailwayCarriage);
            }



            //нужен допил
            foreach (var item in railwayCarriages)
            {
                foreach (var carriageOnRoute in railRoute.Train.Carriages)
                {
                    if (carriageOnRoute.Equals(item))
                    {

                    }
                    else
                    {
                        railRoute.Train.RemoveCarriage(carriageOnRoute);
                    }
                }
            }


            var carriges = railRoute.Train.Carriages;
        }


        #endregion



        //ctor
        public RailRouteForm(IRailRoute _railRoute)
        {
            InitializeComponent();


            this.railRoute = _railRoute;
            railRoute = new RailRoute() { };
            railRoute.Train.AddCarriage(new BaseRailwayCarriage());
            railRoute.Train.Carriages[0][0, 0].Reserve(new Customer());
            railRoute.Train.Carriages[0][2, 3].Reserve(new Customer());
            railRoute.Train.Carriages[0][6, 2].Reserve(new Customer());


            CreateButton();

            SubscribeUpdatesSeat();

            AddDataInBingingSourse();

            UpdateSeatsAndRestrictCountOfCarrige(this, new EventArgs());
        }


        private void buttonBackToMain_Click(object sender, EventArgs e)
        {

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
