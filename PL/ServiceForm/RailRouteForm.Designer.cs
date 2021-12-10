
namespace PL.ServiceForm
{
    partial class RailRouteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RailRouteForm));
            this.bindingNavigatorCarriages = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceCarriges = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.labelPassportNumber = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonsSaveChange = new System.Windows.Forms.Button();
            this.buttonUnreserve = new System.Windows.Forms.Button();
            this.labelSeat = new System.Windows.Forms.Label();
            this.labelPriceInfo = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelWhenReserve = new System.Windows.Forms.Label();
            this.labelWhen = new System.Windows.Forms.Label();
            this.labelRouteName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCarriages)).BeginInit();
            this.bindingNavigatorCarriages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarriges)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorCarriages
            // 
            this.bindingNavigatorCarriages.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorCarriages.BindingSource = this.bindingSourceCarriges;
            this.bindingNavigatorCarriages.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCarriages.DeleteItem = null;
            this.bindingNavigatorCarriages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorCarriages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorCarriages.Location = new System.Drawing.Point(0, 575);
            this.bindingNavigatorCarriages.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCarriages.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCarriages.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCarriages.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCarriages.Name = "bindingNavigatorCarriages";
            this.bindingNavigatorCarriages.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCarriages.Size = new System.Drawing.Size(600, 25);
            this.bindingNavigatorCarriages.TabIndex = 1;
            this.bindingNavigatorCarriages.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingSourceCarriges
            // 
            this.bindingSourceCarriges.DataSource = typeof(BLL.LogicClass.BaseRailwayCarriage);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonBackToMain.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackToMain.Location = new System.Drawing.Point(80, 12);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(446, 41);
            this.buttonBackToMain.TabIndex = 10;
            this.buttonBackToMain.Text = "Повернутися на головну форму";
            this.buttonBackToMain.UseVisualStyleBackColor = false;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // labelPassportNumber
            // 
            this.labelPassportNumber.AutoSize = true;
            this.labelPassportNumber.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassportNumber.Location = new System.Drawing.Point(340, 370);
            this.labelPassportNumber.Name = "labelPassportNumber";
            this.labelPassportNumber.Size = new System.Drawing.Size(138, 20);
            this.labelPassportNumber.TabIndex = 25;
            this.labelPassportNumber.Text = "Passport Number";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(340, 310);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 20);
            this.labelAge.TabIndex = 24;
            this.labelAge.Text = "Age";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(340, 250);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(77, 20);
            this.labelSurname.TabIndex = 23;
            this.labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(340, 196);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Name";
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassportNumber.Location = new System.Drawing.Point(340, 393);
            this.textBoxPassportNumber.MaxLength = 9;
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(248, 27);
            this.textBoxPassportNumber.TabIndex = 21;
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAge.Location = new System.Drawing.Point(340, 333);
            this.textAge.MaxLength = 3;
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(248, 27);
            this.textAge.TabIndex = 20;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(340, 273);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(248, 27);
            this.textBoxSurname.TabIndex = 19;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(340, 219);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 27);
            this.textBoxName.TabIndex = 18;
            // 
            // buttonReserve
            // 
            this.buttonReserve.BackColor = System.Drawing.Color.Lime;
            this.buttonReserve.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReserve.Location = new System.Drawing.Point(340, 437);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(120, 57);
            this.buttonReserve.TabIndex = 26;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = false;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonsSaveChange
            // 
            this.buttonsSaveChange.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonsSaveChange.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsSaveChange.Location = new System.Drawing.Point(468, 437);
            this.buttonsSaveChange.Name = "buttonsSaveChange";
            this.buttonsSaveChange.Size = new System.Drawing.Size(120, 57);
            this.buttonsSaveChange.TabIndex = 27;
            this.buttonsSaveChange.Text = "Save Change";
            this.buttonsSaveChange.UseVisualStyleBackColor = false;
            this.buttonsSaveChange.Click += new System.EventHandler(this.buttonsSaveChange_Click);
            // 
            // buttonUnreserve
            // 
            this.buttonUnreserve.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonUnreserve.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUnreserve.Location = new System.Drawing.Point(340, 500);
            this.buttonUnreserve.Name = "buttonUnreserve";
            this.buttonUnreserve.Size = new System.Drawing.Size(248, 57);
            this.buttonUnreserve.TabIndex = 28;
            this.buttonUnreserve.Text = "Unreserve";
            this.buttonUnreserve.UseVisualStyleBackColor = false;
            this.buttonUnreserve.Click += new System.EventHandler(this.buttonUnreserve_Click);
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeat.Location = new System.Drawing.Point(434, 100);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(54, 23);
            this.labelSeat.TabIndex = 29;
            this.labelSeat.Text = "Seat";
            // 
            // labelPriceInfo
            // 
            this.labelPriceInfo.AutoSize = true;
            this.labelPriceInfo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceInfo.Location = new System.Drawing.Point(340, 124);
            this.labelPriceInfo.Name = "labelPriceInfo";
            this.labelPriceInfo.Size = new System.Drawing.Size(65, 20);
            this.labelPriceInfo.TabIndex = 30;
            this.labelPriceInfo.Text = "Price = ";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(411, 124);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 20);
            this.labelPrice.TabIndex = 31;
            // 
            // labelWhenReserve
            // 
            this.labelWhenReserve.AutoSize = true;
            this.labelWhenReserve.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhenReserve.Location = new System.Drawing.Point(478, 161);
            this.labelWhenReserve.Name = "labelWhenReserve";
            this.labelWhenReserve.Size = new System.Drawing.Size(0, 20);
            this.labelWhenReserve.TabIndex = 33;
            // 
            // labelWhen
            // 
            this.labelWhen.AutoSize = true;
            this.labelWhen.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhen.Location = new System.Drawing.Point(340, 161);
            this.labelWhen.Name = "labelWhen";
            this.labelWhen.Size = new System.Drawing.Size(134, 20);
            this.labelWhen.TabIndex = 32;
            this.labelWhen.Text = "When Reserve = ";
            // 
            // labelRouteName
            // 
            this.labelRouteName.AutoSize = true;
            this.labelRouteName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRouteName.Location = new System.Drawing.Point(180, 65);
            this.labelRouteName.Name = "labelRouteName";
            this.labelRouteName.Size = new System.Drawing.Size(0, 23);
            this.labelRouteName.TabIndex = 34;
            // 
            // RailRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.labelRouteName);
            this.Controls.Add(this.labelWhenReserve);
            this.Controls.Add(this.labelWhen);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPriceInfo);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.buttonUnreserve);
            this.Controls.Add(this.buttonsSaveChange);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.labelPassportNumber);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPassportNumber);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonBackToMain);
            this.Controls.Add(this.bindingNavigatorCarriages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RailRouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rail Route Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RailRouteForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RailRouteForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RailRouteForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCarriages)).EndInit();
            this.bindingNavigatorCarriages.ResumeLayout(false);
            this.bindingNavigatorCarriages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarriges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bindingNavigatorCarriages;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSourceCarriges;
        private System.Windows.Forms.Button buttonBackToMain;
        private System.Windows.Forms.Label labelPassportNumber;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonsSaveChange;
        private System.Windows.Forms.Button buttonUnreserve;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.Label labelPriceInfo;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelWhenReserve;
        private System.Windows.Forms.Label labelWhen;
        private System.Windows.Forms.Label labelRouteName;
    }
}