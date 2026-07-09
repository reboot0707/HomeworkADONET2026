namespace HomeworkADONET2026.HW
{
    partial class FrmHW03
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
            this.lblResult = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelectDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dataSetNW1 = new HomeworkADONET2026.DataSetNW();
            this.productPhotoTableAdapter1 = new HomeworkADONET2026.DataSetAWTableAdapters.ProductPhotoTableAdapter();
            this.productProductPhotoTableAdapter1 = new HomeworkADONET2026.DataSetAWTableAdapters.ProductProductPhotoTableAdapter();
            this.productTableAdapter1 = new HomeworkADONET2026.DataSetAWTableAdapters.ProductTableAdapter();
            this.prodPhotoDateTableAdapter1 = new HomeworkADONET2026.DataSetAWTableAdapters.ProdPhotoDateTableAdapter();
            this.dataSetAW1 = new HomeworkADONET2026.DataSetAW();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAW1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(40, 176);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(250, 42);
            this.lblResult.TabIndex = 132;
            this.lblResult.Text = "結果 ( ? 筆)";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(40, 245);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersWidth = 62;
            this.dataGridViewResult.RowTemplate.Height = 31;
            this.dataGridViewResult.Size = new System.Drawing.Size(1413, 699);
            this.dataGridViewResult.TabIndex = 131;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(693, 74);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(165, 52);
            this.buttonSort.TabIndex = 130;
            this.buttonSort.Text = "排序";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(51, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 17);
            this.label3.TabIndex = 129;
            this.label3.Text = "AWDataSetModel - ProductPhoto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1089, 89);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 23);
            this.comboBox1.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1008, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 127;
            this.label2.Text = "Year:";
            // 
            // buttonSelectDate
            // 
            this.buttonSelectDate.Location = new System.Drawing.Point(56, 106);
            this.buttonSelectDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSelectDate.Name = "buttonSelectDate";
            this.buttonSelectDate.Size = new System.Drawing.Size(305, 52);
            this.buttonSelectDate.TabIndex = 125;
            this.buttonSelectDate.Text = " 某日期區間的產品 ??";
            this.buttonSelectDate.UseVisualStyleBackColor = true;
            this.buttonSelectDate.Click += new System.EventHandler(this.buttonSelectDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 126;
            this.label1.Text = "~";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(328, 66);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(235, 25);
            this.dateTimePickerEnd.TabIndex = 124;
            this.dateTimePickerEnd.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(56, 65);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(235, 25);
            this.dateTimePickerStart.TabIndex = 123;
            this.dateTimePickerStart.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // dataSetNW1
            // 
            this.dataSetNW1.DataSetName = "DataSetNW";
            this.dataSetNW1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productPhotoTableAdapter1
            // 
            this.productPhotoTableAdapter1.ClearBeforeFill = true;
            // 
            // productProductPhotoTableAdapter1
            // 
            this.productProductPhotoTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // prodPhotoDateTableAdapter1
            // 
            this.prodPhotoDateTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetAW1
            // 
            this.dataSetAW1.DataSetName = "DataSetAW";
            this.dataSetAW1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmHW03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 974);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSelectDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHW03";
            this.Text = "FrmHW03";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private DataSetNW dataSetNW1;
        private DataSetAWTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter1;
        private DataSetAWTableAdapters.ProductProductPhotoTableAdapter productProductPhotoTableAdapter1;
        private DataSetAWTableAdapters.ProductTableAdapter productTableAdapter1;
        private DataSetAWTableAdapters.ProdPhotoDateTableAdapter prodPhotoDateTableAdapter1;
        private DataSetAW dataSetAW1;
    }
}