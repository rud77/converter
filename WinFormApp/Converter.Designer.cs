namespace WinFormApp
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.currencyList = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.DaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateLabel = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // currencyList
            // 
            this.currencyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyList.FormattingEnabled = true;
            this.currencyList.Location = new System.Drawing.Point(33, 32);
            this.currencyList.Name = "currencyList";
            this.currencyList.Size = new System.Drawing.Size(243, 21);
            this.currencyList.TabIndex = 0;
            this.currencyList.SelectedIndexChanged += new System.EventHandler(this.OnSelectCurrency);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DaysColumn,
            this.RatesColumn});
            this.table.Location = new System.Drawing.Point(33, 90);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(243, 91);
            this.table.TabIndex = 1;
            // 
            // DaysColumn
            // 
            this.DaysColumn.HeaderText = "Days";
            this.DaysColumn.Name = "DaysColumn";
            this.DaysColumn.ReadOnly = true;
            // 
            // RatesColumn
            // 
            this.RatesColumn.HeaderText = "Rates";
            this.RatesColumn.Name = "RatesColumn";
            this.RatesColumn.ReadOnly = true;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stateLabel.Location = new System.Drawing.Point(33, 225);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(41, 17);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.state.Location = new System.Drawing.Point(112, 225);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(0, 17);
            this.state.TabIndex = 3;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 274);
            this.Controls.Add(this.state);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.currencyList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Converter";
            this.Text = "Rub Converter";
            this.Load += new System.EventHandler(this.OnLoadForm);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyList;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatesColumn;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label state;
    }
}

