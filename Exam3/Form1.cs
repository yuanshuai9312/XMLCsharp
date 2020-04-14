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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initcontracts();
        }

        void initcontracts()        //读取文件到dataGridVied，为其创建头部标签
        {
            if (System.IO.File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"\xml\persons.xml"))
            {
                dataGridView1.DataSource = personinfoBLL.getallpersoninfo();
            }
            else
            {
                personinfoBLL.CreatePersonXml();
                dataGridView1.DataSource = personinfoBLL.getallpersoninfo();
            }
            dataGridView1.Columns[0].HeaderText = "编号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "年龄";
            dataGridView1.Columns[3].HeaderText = "联系方式";
            dataGridView1.Columns[4].HeaderText = "工作";
            dataGridView1.Columns[5].HeaderText = "住址";
        }

        //新增按钮
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form_Add formadd = new Form_Add();
            formadd.ShowDialog();
            initcontracts();
        }
        //查询按钮
        private void BtnSel_Click(object sender, EventArgs e)
        {
            Form_Search formsearch = new Form_Search();
            formsearch.ShowDialog();
        }

        //删除按钮
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)      //选中datagridVied第一列中的某一项
            {
                if (MessageBox.Show("确定要删除此人员的信息？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {   
                    int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0]
                        .Value.ToString());                 //获取选中的行
                    if (personinfoBLL.DeletePersoninfo(selectrow))
                        MessageBox.Show("删除成功！");
                    else
                        MessageBox.Show("删除失败，请检查是否选中人员信息！");
                    initcontracts();
                }
            }
            else
                MessageBox.Show("请选中后再点击删除按钮");
        }

        //修改按钮
        private void BtnEid_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex]
                    .Cells[0].Value.ToString());
                Form_Edit formedit = new Form_Edit();
                formedit.personid_edit = selectrow;             //把选中的行号传递给formedit
                formedit.ShowDialog();
                initcontracts();
            }
            else
                MessageBox.Show("请选中一行后再点击编辑按钮！");
        }
    }
}
