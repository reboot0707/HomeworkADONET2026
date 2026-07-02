namespace HomeworkADONET2026.HW
{
    partial class FrmHW01
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxProductsCat = new System.Windows.Forms.ListBox();
            this.comboQueryCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(114, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Products:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(60, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "CategoryName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Connected NW DB";
            // 
            // listBoxProductsCat
            // 
            this.listBoxProductsCat.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxProductsCat.FormattingEnabled = true;
            this.listBoxProductsCat.ItemHeight = 15;
            this.listBoxProductsCat.Location = new System.Drawing.Point(237, 135);
            this.listBoxProductsCat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxProductsCat.Name = "listBoxProductsCat";
            this.listBoxProductsCat.Size = new System.Drawing.Size(665, 394);
            this.listBoxProductsCat.TabIndex = 22;
            // 
            // comboQueryCategory
            // 
            this.comboQueryCategory.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboQueryCategory.FormattingEnabled = true;
            this.comboQueryCategory.Location = new System.Drawing.Point(237, 68);
            this.comboQueryCategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboQueryCategory.Name = "comboQueryCategory";
            this.comboQueryCategory.Size = new System.Drawing.Size(394, 31);
            this.comboQueryCategory.TabIndex = 21;
            this.comboQueryCategory.DropDown += new System.EventHandler(this.comboQueryCategory_DropDown);
            this.comboQueryCategory.SelectedIndexChanged += new System.EventHandler(this.comboQueryCategory_SelectedIndexChanged);
            // 
            // FrmHW01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProductsCat);
            this.Controls.Add(this.comboQueryCategory);
            this.Name = "FrmHW01";
            this.Text = "FrmHW01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxProductsCat;
        private System.Windows.Forms.ComboBox comboQueryCategory;
    }
}