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
    public partial class Form_Edit : Form
    {
        public int personid_edit = 0;       //选中的行号，初始值为0
        public Form_Edit()
        {
            InitializeComponent();
        }
        public void initcontrol()       //将需要修改的行中的数据读取到输入框中
        {
            personinfo personinfo = personinfoBLL.getpersoninfo(personid_edit);
            if (personinfo != null)
            {
                textNo.Text = personinfo.personid.ToString();
                textName.Text = personinfo.Name;
                textAge.Text = personinfo.Age.ToString();
                textTel.Text = personinfo.Tel;
                textJob.Text = personinfo.Job;
                textAdr.Text = personinfo.Adr;
            }
        }

        private void Form_Edit_Load(object sender, EventArgs e)
        {
            initcontrol();
        }
        //更新按钮
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            personinfo personinfo = personinfoBLL.getpersoninfo(personid_edit);
            personinfo.personid = Int32.Parse(textNo.Text);
            personinfo.Name = textName.Text;
            personinfo.Age = Int32.Parse(textAge.Text);
            personinfo.Tel = textTel.Text;
            personinfo.Job = textJob.Text;
            personinfo.Adr = textAdr.Text;
            if (personinfoBLL.UpdatePersoninfo(personinfo))
                MessageBox.Show("修改成功！");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
