namespace RentACar
{
    partial class frmAracListesi
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
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.arabalarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarsTableAdapter = new RentACar.RentACarDataSetTableAdapters.ArabalarsTableAdapter();
            this.dgv_AracListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AracListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarsBindingSource
            // 
            this.arabalarsBindingSource.DataMember = "Arabalars";
            this.arabalarsBindingSource.DataSource = this.rentACarDataSet;
            // 
            // arabalarsTableAdapter
            // 
            this.arabalarsTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_AracListesi
            // 
            this.dgv_AracListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AracListesi.Location = new System.Drawing.Point(-11, -4);
            this.dgv_AracListesi.Name = "dgv_AracListesi";
            this.dgv_AracListesi.Size = new System.Drawing.Size(930, 356);
            this.dgv_AracListesi.TabIndex = 0;
            this.dgv_AracListesi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_AracListesi_CellMouseDoubleClick);
            // 
            // frmAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 349);
            this.Controls.Add(this.dgv_AracListesi);
            this.Name = "frmAracListesi";
            this.Text = "frmAracListesi";
            this.Load += new System.EventHandler(this.frmAracListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AracListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource arabalarsBindingSource;
        private RentACarDataSetTableAdapters.ArabalarsTableAdapter arabalarsTableAdapter;
        private System.Windows.Forms.DataGridView dgv_AracListesi;
    }
}