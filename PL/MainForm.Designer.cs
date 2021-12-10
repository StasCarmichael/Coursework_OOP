
namespace PL
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonView = new System.Windows.Forms.Button();
            this.dataGridViewRailRoute = new System.Windows.Forms.DataGridView();
            this.numberOfRouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.railRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNumberOfRoute = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxCountOfCarrige = new System.Windows.Forms.TextBox();
            this.textBoxCountOfReserveSeats = new System.Windows.Forms.TextBox();
            this.textBoxTrainId = new System.Windows.Forms.TextBox();
            this.textBoxTrainNumber = new System.Windows.Forms.TextBox();
            this.labelNumRoute = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelTrainSerialNumber = new System.Windows.Forms.Label();
            this.labelNUM = new System.Windows.Forms.Label();
            this.labelNumCarrige = new System.Windows.Forms.Label();
            this.labelCountSeats = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSerchRoute = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRailRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railRouteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonView.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonView.Location = new System.Drawing.Point(479, 175);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(359, 64);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // dataGridViewRailRoute
            // 
            this.dataGridViewRailRoute.AllowUserToAddRows = false;
            this.dataGridViewRailRoute.AllowUserToDeleteRows = false;
            this.dataGridViewRailRoute.AllowUserToResizeColumns = false;
            this.dataGridViewRailRoute.AllowUserToResizeRows = false;
            this.dataGridViewRailRoute.AutoGenerateColumns = false;
            this.dataGridViewRailRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRailRoute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRailRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRailRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfRouteDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn});
            this.dataGridViewRailRoute.DataSource = this.railRouteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRailRoute.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRailRoute.Location = new System.Drawing.Point(12, 267);
            this.dataGridViewRailRoute.Name = "dataGridViewRailRoute";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRailRoute.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRailRoute.Size = new System.Drawing.Size(595, 264);
            this.dataGridViewRailRoute.TabIndex = 3;
            this.dataGridViewRailRoute.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRailRoute_CellClick);
            // 
            // numberOfRouteDataGridViewTextBoxColumn
            // 
            this.numberOfRouteDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRoute";
            this.numberOfRouteDataGridViewTextBoxColumn.HeaderText = "NumberOfRoute";
            this.numberOfRouteDataGridViewTextBoxColumn.Name = "numberOfRouteDataGridViewTextBoxColumn";
            this.numberOfRouteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            // 
            // railRouteBindingSource
            // 
            this.railRouteBindingSource.DataSource = typeof(BLL.LogicClass.RailRoute);
            // 
            // textBoxNumberOfRoute
            // 
            this.textBoxNumberOfRoute.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberOfRoute.Location = new System.Drawing.Point(12, 37);
            this.textBoxNumberOfRoute.MaxLength = 6;
            this.textBoxNumberOfRoute.Name = "textBoxNumberOfRoute";
            this.textBoxNumberOfRoute.Size = new System.Drawing.Size(200, 27);
            this.textBoxNumberOfRoute.TabIndex = 4;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFrom.Location = new System.Drawing.Point(12, 91);
            this.textBoxFrom.MaxLength = 50;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(200, 27);
            this.textBoxFrom.TabIndex = 5;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTo.Location = new System.Drawing.Point(12, 151);
            this.textBoxTo.MaxLength = 50;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(200, 27);
            this.textBoxTo.TabIndex = 6;
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.BackColor = System.Drawing.Color.Lime;
            this.buttonAddRoute.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRoute.Location = new System.Drawing.Point(233, 139);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(222, 44);
            this.buttonAddRoute.TabIndex = 7;
            this.buttonAddRoute.Text = "Add new Route";
            this.buttonAddRoute.UseVisualStyleBackColor = false;
            this.buttonAddRoute.Click += new System.EventHandler(this.buttonAddRoute_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Orange;
            this.buttonRemove.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(233, 194);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(222, 44);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove Route";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(628, 490);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(210, 41);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxCountOfCarrige
            // 
            this.textBoxCountOfCarrige.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountOfCarrige.Location = new System.Drawing.Point(628, 365);
            this.textBoxCountOfCarrige.MaxLength = 50;
            this.textBoxCountOfCarrige.Name = "textBoxCountOfCarrige";
            this.textBoxCountOfCarrige.ReadOnly = true;
            this.textBoxCountOfCarrige.Size = new System.Drawing.Size(210, 27);
            this.textBoxCountOfCarrige.TabIndex = 10;
            // 
            // textBoxCountOfReserveSeats
            // 
            this.textBoxCountOfReserveSeats.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountOfReserveSeats.Location = new System.Drawing.Point(628, 432);
            this.textBoxCountOfReserveSeats.MaxLength = 20;
            this.textBoxCountOfReserveSeats.Name = "textBoxCountOfReserveSeats";
            this.textBoxCountOfReserveSeats.ReadOnly = true;
            this.textBoxCountOfReserveSeats.Size = new System.Drawing.Size(210, 27);
            this.textBoxCountOfReserveSeats.TabIndex = 11;
            // 
            // textBoxTrainId
            // 
            this.textBoxTrainId.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTrainId.Location = new System.Drawing.Point(628, 301);
            this.textBoxTrainId.MaxLength = 50;
            this.textBoxTrainId.Name = "textBoxTrainId";
            this.textBoxTrainId.ReadOnly = true;
            this.textBoxTrainId.Size = new System.Drawing.Size(210, 27);
            this.textBoxTrainId.TabIndex = 12;
            // 
            // textBoxTrainNumber
            // 
            this.textBoxTrainNumber.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTrainNumber.Location = new System.Drawing.Point(12, 211);
            this.textBoxTrainNumber.MaxLength = 6;
            this.textBoxTrainNumber.Name = "textBoxTrainNumber";
            this.textBoxTrainNumber.Size = new System.Drawing.Size(200, 27);
            this.textBoxTrainNumber.TabIndex = 13;
            // 
            // labelNumRoute
            // 
            this.labelNumRoute.AutoSize = true;
            this.labelNumRoute.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumRoute.Location = new System.Drawing.Point(12, 14);
            this.labelNumRoute.Name = "labelNumRoute";
            this.labelNumRoute.Size = new System.Drawing.Size(135, 20);
            this.labelNumRoute.TabIndex = 14;
            this.labelNumRoute.Text = "Number of Route";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(12, 68);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(49, 20);
            this.labelFrom.TabIndex = 15;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(12, 128);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(28, 20);
            this.labelTo.TabIndex = 16;
            this.labelTo.Text = "To";
            // 
            // labelTrainSerialNumber
            // 
            this.labelTrainSerialNumber.AutoSize = true;
            this.labelTrainSerialNumber.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainSerialNumber.Location = new System.Drawing.Point(12, 188);
            this.labelTrainSerialNumber.Name = "labelTrainSerialNumber";
            this.labelTrainSerialNumber.Size = new System.Drawing.Size(164, 20);
            this.labelTrainSerialNumber.TabIndex = 17;
            this.labelTrainSerialNumber.Text = "Train Serial Number";
            // 
            // labelNUM
            // 
            this.labelNUM.AutoSize = true;
            this.labelNUM.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNUM.Location = new System.Drawing.Point(624, 278);
            this.labelNUM.Name = "labelNUM";
            this.labelNUM.Size = new System.Drawing.Size(186, 20);
            this.labelNUM.TabIndex = 18;
            this.labelNUM.Text = "Серійной номер потяга";
            // 
            // labelNumCarrige
            // 
            this.labelNumCarrige.AutoSize = true;
            this.labelNumCarrige.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumCarrige.Location = new System.Drawing.Point(624, 342);
            this.labelNumCarrige.Name = "labelNumCarrige";
            this.labelNumCarrige.Size = new System.Drawing.Size(227, 20);
            this.labelNumCarrige.TabIndex = 19;
            this.labelNumCarrige.Text = "Кількіть вагонів на маршуті";
            // 
            // labelCountSeats
            // 
            this.labelCountSeats.AutoSize = true;
            this.labelCountSeats.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountSeats.Location = new System.Drawing.Point(624, 409);
            this.labelCountSeats.Name = "labelCountSeats";
            this.labelCountSeats.Size = new System.Drawing.Size(195, 20);
            this.labelCountSeats.TabIndex = 20;
            this.labelCountSeats.Text = "Кількіть зайнятих місць";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(281, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter route number";
            // 
            // textBoxSerchRoute
            // 
            this.textBoxSerchRoute.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSerchRoute.Location = new System.Drawing.Point(272, 37);
            this.textBoxSerchRoute.MaxLength = 6;
            this.textBoxSerchRoute.Name = "textBoxSerchRoute";
            this.textBoxSerchRoute.Size = new System.Drawing.Size(183, 27);
            this.textBoxSerchRoute.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(272, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Search Route";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSerchRoute);
            this.Controls.Add(this.labelCountSeats);
            this.Controls.Add(this.labelNumCarrige);
            this.Controls.Add(this.labelNUM);
            this.Controls.Add(this.labelTrainSerialNumber);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelNumRoute);
            this.Controls.Add(this.textBoxTrainNumber);
            this.Controls.Add(this.textBoxTrainId);
            this.Controls.Add(this.textBoxCountOfReserveSeats);
            this.Controls.Add(this.textBoxCountOfCarrige);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddRoute);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxNumberOfRoute);
            this.Controls.Add(this.dataGridViewRailRoute);
            this.Controls.Add(this.buttonView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(880, 580);
            this.MinimumSize = new System.Drawing.Size(880, 580);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Railway Ticket Office";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRailRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railRouteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.BindingSource railRouteBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewRailRoute;
        private System.Windows.Forms.TextBox textBoxNumberOfRoute;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonAddRoute;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxCountOfCarrige;
        private System.Windows.Forms.TextBox textBoxCountOfReserveSeats;
        private System.Windows.Forms.TextBox textBoxTrainId;
        private System.Windows.Forms.TextBox textBoxTrainNumber;
        private System.Windows.Forms.Label labelNumRoute;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelTrainSerialNumber;
        private System.Windows.Forms.Label labelNUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelNumCarrige;
        private System.Windows.Forms.Label labelCountSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSerchRoute;
        private System.Windows.Forms.Button button1;
    }
}

