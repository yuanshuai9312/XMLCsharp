namespace Exam3
{
    partial class Form_Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNo = new System.Windows.Forms.TextBox();
            this.textJob = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAdr = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "年龄：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系方式：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "工作：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "住址：";
            // 
            // textNo
            // 
            this.textNo.Location = new System.Drawing.Point(162, 60);
            this.textNo.Name = "textNo";
            this.textNo.Size = new System.Drawing.Size(100, 21);
            this.textNo.TabIndex = 6;
            // 
            // textJob
            // 
            this.textJob.Location = new System.Drawing.Point(162, 276);
            this.textJob.Name = "textJob";
            this.textJob.Size = new System.Drawing.Size(100, 21);
            this.textJob.TabIndex = 8;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(162, 215);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(100, 21);
            this.textTel.TabIndex = 9;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(162, 165);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 21);
            this.textAge.TabIndex = 10;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(162, 111);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 11;
            // 
            // textAdr
            // 
            this.textAdr.Location = new System.Drawing.Point(162, 335);
            this.textAdr.Name = "textAdr";
            this.textAdr.Size = new System.Drawing.Size(100, 21);
            this.textAdr.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(403, 157);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "添加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(533, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textAdr);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textJob);
            this.Controls.Add(this.textNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Add";
            this.Text = "Form_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNo;
        private System.Windows.Forms.TextBox textJob;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAdr;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}