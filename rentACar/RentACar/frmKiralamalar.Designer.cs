namespace RentACar
{
    partial class frmKiralamalar
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
            this.rentACarDataSet1 = new RentACar.RentACarDataSet1();
            this.kiralamasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiralamasTableAdapter = new RentACar.RentACarDataSet1TableAdapters.KiralamasTableAdapter();
            this.alisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralamaSuresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alisTarihiDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.kiralamaSuresiDataGridViewTextBoxColumn,
            this.faturaTutariDataGridViewTextBoxColumn,
            this.aktifMiDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.kiralamasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rentACarDataSet1
            // 
            this.rentACarDataSet1.DataSetName = "RentACarDataSet1";
            this.rentACarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kiralamasBindingSource
            // 
            this.kiralamasBindingSource.DataMember = "Kiralamas";
            this.kiralamasBindingSource.DataSource = this.rentACarDataSet1;
            // 
            // kiralamasTableAdapter
            // 
            this.kiralamasTableAdapter.ClearBeforeFill = true;
            // 
            // alisTarihiDataGridViewTextBoxColumn
            // 
            this.alisTarihiDataGridViewTextBoxColumn.DataPropertyName = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.HeaderText = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.Name = "alisTarihiDataGridViewTextBoxColumn";
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            // 
            // kiralamaSuresiDataGridViewTextBoxColumn
            // 
            this.kiralamaSuresiDataGridViewTextBoxColumn.DataPropertyName = "KiralamaSuresi";
            this.kiralamaSuresiDataGridViewTextBoxColumn.HeaderText = "KiralamaSuresi";
            this.kiralamaSuresiDataGridViewTextBoxColumn.Name = "kiralamaSuresiDataGridViewTextBoxColumn";
            // 
            // faturaTutariDataGridViewTextBoxColumn
            // 
            this.faturaTutariDataGridViewTextBoxColumn.DataPropertyName = "FaturaTutari";
            this.faturaTutariDataGridViewTextBoxColumn.HeaderText = "FaturaTutari";
            this.faturaTutariDataGridViewTextBoxColumn.Name = "faturaTutariDataGridViewTextBoxColumn";
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            this.aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            // 
            // frmKiralamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 254);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKiralamalar";
            this.Text = "frmKiralamalar";
            this.Load += new System.EventHandler(this.frmKiralamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RentACarDataSet1 rentACarDataSet1;
        private System.Windows.Forms.BindingSource kiralamasBindingSource;
        private RentACarDataSet1TableAdapters.KiralamasTableAdapter kiralamasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamaSuresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
    }
}