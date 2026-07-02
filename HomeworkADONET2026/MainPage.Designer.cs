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
            this.SuspendLayout();
            // 
            // buttonOpenHW01
            // 
            this.buttonOpenHW01.Location = new System.Drawing.Point(53, 27);
            this.buttonOpenHW01.Name = "buttonOpenHW01";
            this.buttonOpenHW01.Size = new System.Drawing.Size(293, 73);
            this.buttonOpenHW01.TabIndex = 0;
            this.buttonOpenHW01.Text = "作業1";
            this.buttonOpenHW01.UseVisualStyleBackColor = true;
            this.buttonOpenHW01.Click += new System.EventHandler(this.buttonOpenHW01_Click);
            // 
            // buttonOpenHW02
            // 
            this.buttonOpenHW02.Location = new System.Drawing.Point(53, 126);
            this.buttonOpenHW02.Name = "buttonOpenHW02";
            this.buttonOpenHW02.Size = new System.Drawing.Size(293, 73);
            this.buttonOpenHW02.TabIndex = 1;
            this.buttonOpenHW02.Text = "作業2";
            this.buttonOpenHW02.UseVisualStyleBackColor = true;
            this.buttonOpenHW02.Click += new System.EventHandler(this.buttonOpenHW02_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenHW02);
            this.Controls.Add(this.buttonOpenHW01);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenHW01;
        private System.Windows.Forms.Button buttonOpenHW02;
    }
}

