namespace usecase_try4
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bank_AppDataSet = new usecase_try4.Bank_AppDataSet();
            this.details2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.details_2TableAdapter = new usecase_try4.Bank_AppDataSetTableAdapters.details_2TableAdapter();
            this.accidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_AppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accidDataGridViewTextBoxColumn,
            this.accnameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.details2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bank_AppDataSet
            // 
            this.bank_AppDataSet.DataSetName = "Bank_AppDataSet";
            this.bank_AppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // details2BindingSource
            // 
            this.details2BindingSource.DataMember = "details_2";
            this.details2BindingSource.DataSource = this.bank_AppDataSet;
            // 
            // details_2TableAdapter
            // 
            this.details_2TableAdapter.ClearBeforeFill = true;
            // 
            // accidDataGridViewTextBoxColumn
            // 
            this.accidDataGridViewTextBoxColumn.DataPropertyName = "acc_id";
            this.accidDataGridViewTextBoxColumn.HeaderText = "acc_id";
            this.accidDataGridViewTextBoxColumn.Name = "accidDataGridViewTextBoxColumn";
            // 
            // accnameDataGridViewTextBoxColumn
            // 
            this.accnameDataGridViewTextBoxColumn.DataPropertyName = "acc_name";
            this.accnameDataGridViewTextBoxColumn.HeaderText = "acc_name";
            this.accnameDataGridViewTextBoxColumn.Name = "accnameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_AppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bank_AppDataSet bank_AppDataSet;
        private System.Windows.Forms.BindingSource details2BindingSource;
        private Bank_AppDataSetTableAdapters.details_2TableAdapter details_2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}