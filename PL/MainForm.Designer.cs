
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
            this.buttonView = new System.Windows.Forms.Button();
            this.railRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewRailRoute = new System.Windows.Forms.DataGridView();
            this.numberOfRouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.railRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRailRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(346, 110);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(249, 59);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "button1";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // railRouteBindingSource
            // 
            this.railRouteBindingSource.DataSource = typeof(BLL.LogicClass.RailRoute);
            // 
            // dataGridViewRailRoute
            // 
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
            this.toDataGridViewTextBoxColumn,
            this.ColumnRoute});
            this.dataGridViewRailRoute.DataSource = this.railRouteBindingSource;
            this.dataGridViewRailRoute.Location = new System.Drawing.Point(12, 250);
            this.dataGridViewRailRoute.Name = "dataGridViewRailRoute";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRailRoute.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRailRoute.Size = new System.Drawing.Size(719, 281);
            this.dataGridViewRailRoute.TabIndex = 3;
            // 
            // numberOfRouteDataGridViewTextBoxColumn
            // 
            this.numberOfRouteDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRoute";
            this.numberOfRouteDataGridViewTextBoxColumn.HeaderText = "NumberOfRoute";
            this.numberOfRouteDataGridViewTextBoxColumn.Name = "numberOfRouteDataGridViewTextBoxColumn";
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
            // ColumnRoute
            // 
            this.ColumnRoute.HeaderText = "Count Route";
            this.ColumnRoute.Name = "ColumnRoute";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 543);
            this.Controls.Add(this.dataGridViewRailRoute);
            this.Controls.Add(this.buttonView);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.railRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRailRoute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.BindingSource railRouteBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewRailRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoute;
    }
}

