namespace Exam3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnEid = new System.Windows.Forms.Button();
            this.BtnSel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(197, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(642, 366);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(326, 12);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "删除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnEid
            // 
            this.BtnEid.Location = new System.Drawing.Point(468, 12);
            this.BtnEid.Name = "BtnEid";
            this.BtnEid.Size = new System.Drawing.Size(75, 23);
            this.BtnEid.TabIndex = 4;
            this.BtnEid.Text = "修改";
            this.BtnEid.UseVisualStyleBackColor = true;
            this.BtnEid.Click += new System.EventHandler(this.BtnEid_Click);
            // 
            // BtnSel
            // 
            this.BtnSel.Location = new System.Drawing.Point(588, 12);
            this.BtnSel.Name = "BtnSel";
            this.BtnSel.Size = new System.Drawing.Size(75, 23);
            this.BtnSel.TabIndex = 5;
            this.BtnSel.Text = "查询";
            this.BtnSel.UseVisualStyleBackColor = true;
            this.BtnSel.Click += new System.EventHandler(this.BtnSel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSel);
            this.Controls.Add(this.BtnEid);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnEid;
        private System.Windows.Forms.Button BtnSel;
    }
}

