namespace HomeworkADONET2026
{
    partial class MainPage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenHW01 = new System.Windows.Forms.Button();
            this.buttonOpenHW02 = new System.Windows.Forms.Button();
            this.buttonOpenHW03 = new System.Windows.Forms.Button();
            this.buttonHW04 = new System.Windows.Forms.Button();
            this.buttonHW05 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenHW01
            // 
            this.buttonOpenHW01.Location = new System.Drawing.Point(40, 24);
            this.buttonOpenHW01.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenHW01.Name = "buttonOpenHW01";
            this.buttonOpenHW01.Size = new System.Drawing.Size(220, 63);
            this.buttonOpenHW01.TabIndex = 0;
            this.buttonOpenHW01.Text = "作業1";
            this.buttonOpenHW01.UseVisualStyleBackColor = true;
            this.buttonOpenHW01.Click += new System.EventHandler(this.buttonOpenHW01_Click);
            // 
            // buttonOpenHW02
            // 
            this.buttonOpenHW02.Location = new System.Drawing.Point(40, 109);
            this.buttonOpenHW02.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenHW02.Name = "buttonOpenHW02";
            this.buttonOpenHW02.Size = new System.Drawing.Size(220, 63);
            this.buttonOpenHW02.TabIndex = 1;
            this.buttonOpenHW02.Text = "作業2";
            this.buttonOpenHW02.UseVisualStyleBackColor = true;
            this.buttonOpenHW02.Click += new System.EventHandler(this.buttonOpenHW02_Click);
            // 
            // buttonOpenHW03
            // 
            this.buttonOpenHW03.Location = new System.Drawing.Point(40, 194);
            this.buttonOpenHW03.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenHW03.Name = "buttonOpenHW03";
            this.buttonOpenHW03.Size = new System.Drawing.Size(220, 63);
            this.buttonOpenHW03.TabIndex = 2;
            this.buttonOpenHW03.Text = "作業3";
            this.buttonOpenHW03.UseVisualStyleBackColor = true;
            this.buttonOpenHW03.Click += new System.EventHandler(this.buttonOpenHW03_Click);
            // 
            // buttonHW04
            // 
            this.buttonHW04.Location = new System.Drawing.Point(40, 282);
            this.buttonHW04.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHW04.Name = "buttonHW04";
            this.buttonHW04.Size = new System.Drawing.Size(220, 63);
            this.buttonHW04.TabIndex = 3;
            this.buttonHW04.Text = "作業4";
            this.buttonHW04.UseVisualStyleBackColor = true;
            this.buttonHW04.Click += new System.EventHandler(this.buttonHW04_Click);
            // 
            // buttonHW05
            // 
            this.buttonHW05.Enabled = false;
            this.buttonHW05.Location = new System.Drawing.Point(40, 367);
            this.buttonHW05.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHW05.Name = "buttonHW05";
            this.buttonHW05.Size = new System.Drawing.Size(220, 63);
            this.buttonHW05.TabIndex = 4;
            this.buttonHW05.Text = "作業5";
            this.buttonHW05.UseVisualStyleBackColor = true;
            this.buttonHW05.Click += new System.EventHandler(this.buttonHW05_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 482);
            this.Controls.Add(this.buttonHW05);
            this.Controls.Add(this.buttonHW04);
            this.Controls.Add(this.buttonOpenHW03);
            this.Controls.Add(this.buttonOpenHW02);
            this.Controls.Add(this.buttonOpenHW01);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenHW01;
        private System.Windows.Forms.Button buttonOpenHW02;
        private System.Windows.Forms.Button buttonOpenHW03;
        private System.Windows.Forms.Button buttonHW04;
        private System.Windows.Forms.Button buttonHW05;
    }
}

