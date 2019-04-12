namespace WindowsFormsApp1
{
    partial class Form1
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
            this.taoData = new System.Windows.Forms.Button();
            this.chuoiketNoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taoData
            // 
            this.taoData.Location = new System.Drawing.Point(98, 39);
            this.taoData.Name = "taoData";
            this.taoData.Size = new System.Drawing.Size(143, 23);
            this.taoData.TabIndex = 0;
            this.taoData.Text = "Tạo database";
            this.taoData.UseVisualStyleBackColor = true;
            this.taoData.Click += new System.EventHandler(this.taoData_Click);
            // 
            // chuoiketNoi
            // 
            this.chuoiketNoi.Location = new System.Drawing.Point(87, 97);
            this.chuoiketNoi.Name = "chuoiketNoi";
            this.chuoiketNoi.Size = new System.Drawing.Size(371, 20);
            this.chuoiketNoi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chuỗi kết nối";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chuoiketNoi);
            this.Controls.Add(this.taoData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button taoData;
        private System.Windows.Forms.TextBox chuoiketNoi;
        private System.Windows.Forms.Label label1;
    }
}

