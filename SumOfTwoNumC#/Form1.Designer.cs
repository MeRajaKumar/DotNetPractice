namespace SumOfTwoNum
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
            this.sumBtn = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumLbl = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sumBtn
            // 
            this.sumBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.sumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumBtn.Location = new System.Drawing.Point(481, 132);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(156, 85);
            this.sumBtn.TabIndex = 0;
            this.sumBtn.Text = "Click to Sum";
            this.sumBtn.UseVisualStyleBackColor = false;
            this.sumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.txt1.Location = new System.Drawing.Point(256, 122);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(122, 43);
            this.txt1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "1st number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "2nd number";
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLbl.ForeColor = System.Drawing.Color.White;
            this.sumLbl.Location = new System.Drawing.Point(250, 316);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(45, 33);
            this.sumLbl.TabIndex = 4;
            this.sumLbl.Text = ".....";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.txt2.Location = new System.Drawing.Point(256, 195);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(122, 43);
            this.txt2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.sumBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.TextBox txt2;
    }
}

