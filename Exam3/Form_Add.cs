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
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                personinfo personinfo = new personinfo();           //新建一个personinfo对象，读取textBox中的值
                personinfo.personid = Int32.Parse(textNo.Text);
                personinfo.Name = textName.Text;
                personinfo.Age = Int32.Parse(textAge.Text);
                personinfo.Tel = textTel.Text;
                personinfo.Job = textJob.Text;
                personinfo.Adr = textAdr.Text;
                if (personinfoBLL.Addpersoninfo(personinfo))
                { MessageBox.Show("添加成功！"); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
