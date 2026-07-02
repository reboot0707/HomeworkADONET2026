namespace HomeworkADONET2026.HW
{
    partial class FrmHW02
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.buttonProdNameFilt = new System.Windows.Forms.Button();
            this.dataGridViewNW = new System.Windows.Forms.DataGridView();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUnitPriceFilt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPriceMax = new System.Windows.Forms.TextBox();
            this.textBoxPriceMin = new System.Windows.Forms.TextBox();
            this.dataSetNW1 = new HomeworkADONET2026.DataSetNW();
            this.productsTableAdapter1 = new HomeworkADONET2026.DataSetNWTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNW1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(35, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 133;
            this.label3.Text = "NWDataSet";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(30, 138);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 34);
            this.lblResult.TabIndex = 132;
            // 
            // buttonProdNameFilt
            // 
            this.buttonProdNameFilt.Location = new System.Drawing.Point(487, 78);
            this.buttonProdNameFilt.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.buttonProdNameFilt.Name = "buttonProdNameFilt";
            this.buttonProdNameFilt.Size = new System.Drawing.Size(129, 30);
            this.buttonProdNameFilt.TabIndex = 131;
            this.buttonProdNameFilt.Text = "Search";
            this.buttonProdNameFilt.UseVisualStyleBackColor = true;
            this.buttonProdNameFilt.Click += new System.EventHandler(this.buttonProdNameFilt_Click);
            // 
            // dataGridViewNW
            // 
            this.dataGridViewNW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNW.Location = new System.Drawing.Point(30, 182);
            this.dataGridViewNW.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dataGridViewNW.Name = "dataGridViewNW";
            this.dataGridViewNW.RowHeadersWidth = 62;
            this.dataGridViewNW.RowTemplate.Height = 31;
            this.dataGridViewNW.Size = new System.Drawing.Size(795, 447);
            this.dataGridViewNW.TabIndex = 130;
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(170, 82);
            this.textBoxProdName.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(276, 22);
            this.textBoxProdName.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 128;
            this.label1.Text = "ProductName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 127;
            this.label5.Text = "UnitPrice:";
            // 
            // buttonUnitPriceFilt
            // 
            this.buttonUnitPriceFilt.Location = new System.Drawing.Point(487, 42);
            this.buttonUnitPriceFilt.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.buttonUnitPriceFilt.Name = "buttonUnitPriceFilt";
            this.buttonUnitPriceFilt.Size = new System.Drawing.Size(129, 30);
            this.buttonUnitPriceFilt.TabIndex = 126;
            this.buttonUnitPriceFilt.Text = "Search";
            this.buttonUnitPriceFilt.UseVisualStyleBackColor = true;
            this.buttonUnitPriceFilt.Click += new System.EventHandler(this.buttonUnitPriceFilt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 125;
            this.label4.Text = "~";
            // 
            // textBoxPriceMax
            // 
            this.textBoxPriceMax.Location = new System.Drawing.Point(342, 46);
            this.textBoxPriceMax.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.textBoxPriceMax.Name = "textBoxPriceMax";
            this.textBoxPriceMax.Size = new System.Drawing.Size(104, 22);
            this.textBoxPriceMax.TabIndex = 124;
            // 
            // textBoxPriceMin
            // 
            this.textBoxPriceMin.Location = new System.Drawing.Point(170, 47);
            this.textBoxPriceMin.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.textBoxPriceMin.Name = "textBoxPriceMin";
            this.textBoxPriceMin.Size = new System.Drawing.Size(104, 22);
            this.textBoxPriceMin.TabIndex = 123;
            // 
            // dataSetNW1
            // 
            this.dataSetNW1.DataSetName = "DataSetNW";
            this.dataSetNW1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmHW02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 658);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.buttonProdNameFilt);
            this.Controls.Add(this.dataGridViewNW);
            this.Controls.Add(this.textBoxProdName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonUnitPriceFilt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPriceMax);
            this.Controls.Add(this.textBoxPriceMin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHW02";
            this.Text = "FrmHW02";
            this.Load += new System.EventHandler(this.FrmHW02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button buttonProdNameFilt;
        private System.Windows.Forms.DataGridView dataGridViewNW;
        private System.Windows.Forms.TextBox textBoxProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUnitPriceFilt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPriceMax;
        private System.Windows.Forms.TextBox textBoxPriceMin;
        private DataSetNW dataSetNW1;
        private DataSetNWTableAdapters.ProductsTableAdapter productsTableAdapter1;
    }
}