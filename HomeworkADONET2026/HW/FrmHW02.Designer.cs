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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUnitPriceFilt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.label3.Location = new System.Drawing.Point(47, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
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
            this.lblResult.Location = new System.Drawing.Point(40, 172);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(288, 42);
            this.lblResult.TabIndex = 132;
            this.lblResult.Text = "結果 ( 100 筆)";
            // 
            // buttonProdNameFilt
            // 
            this.buttonProdNameFilt.Location = new System.Drawing.Point(649, 98);
            this.buttonProdNameFilt.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonProdNameFilt.Name = "buttonProdNameFilt";
            this.buttonProdNameFilt.Size = new System.Drawing.Size(172, 38);
            this.buttonProdNameFilt.TabIndex = 131;
            this.buttonProdNameFilt.Text = "Search";
            this.buttonProdNameFilt.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNW
            // 
            this.dataGridViewNW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNW.Location = new System.Drawing.Point(40, 227);
            this.dataGridViewNW.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dataGridViewNW.Name = "dataGridViewNW";
            this.dataGridViewNW.RowHeadersWidth = 62;
            this.dataGridViewNW.RowTemplate.Height = 31;
            this.dataGridViewNW.Size = new System.Drawing.Size(1060, 559);
            this.dataGridViewNW.TabIndex = 130;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(226, 103);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(367, 25);
            this.textBox3.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 128;
            this.label1.Text = "ProductName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 127;
            this.label5.Text = "UnitPrice:";
            // 
            // buttonUnitPriceFilt
            // 
            this.buttonUnitPriceFilt.Location = new System.Drawing.Point(649, 52);
            this.buttonUnitPriceFilt.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonUnitPriceFilt.Name = "buttonUnitPriceFilt";
            this.buttonUnitPriceFilt.Size = new System.Drawing.Size(172, 38);
            this.buttonUnitPriceFilt.TabIndex = 126;
            this.buttonUnitPriceFilt.Text = "Search";
            this.buttonUnitPriceFilt.UseVisualStyleBackColor = true;
            this.buttonUnitPriceFilt.Click += new System.EventHandler(this.buttonUnitPriceFilt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 125;
            this.label4.Text = "~";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(456, 57);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 25);
            this.textBox2.TabIndex = 124;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 25);
            this.textBox1.TabIndex = 123;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 823);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.buttonProdNameFilt);
            this.Controls.Add(this.dataGridViewNW);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonUnitPriceFilt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUnitPriceFilt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private DataSetNW dataSetNW1;
        private DataSetNWTableAdapters.ProductsTableAdapter productsTableAdapter1;
    }
}