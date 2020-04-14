using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam3
{
    public partial class Form_Search : Form
    {
        public Form_Search()
        {
            InitializeComponent();
        }

        void initheadtitle()        //dataGridView1初始化头部标签
        {
            dataGridView1.Columns[0].HeaderText = "编号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "年龄";
            dataGridView1.Columns[3].HeaderText = "联系方式";
            dataGridView1.Columns[4].HeaderText = "工作";
            dataGridView1.Columns[5].HeaderText = "住址";
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty)      //若未选择查询方式，则打印所有人员信息
            {
                dataGridView1.DataSource = personinfoBLL.getallpersoninfo();
                initheadtitle();
            }
            else
            {
                if (textBox1.Text != string.Empty)
                {
                    personinfo studentsearch = new personinfo();
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: studentsearch.personid = Int32.Parse(textBox1.Text); break;
                        case 1: studentsearch.Name = textBox1.Text; break;
                    }
                    dataGridView1.DataSource = personinfoBLL.getpersoninfolist(studentsearch);
                    initheadtitle();
                }
                else MessageBox.Show("请输入要查询的" + comboBox1.Text);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
