using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MyProjiect
{
    public partial class meau : Form
    {

        public static FoodFm fd { get; set; }  //定义一个属性接受上个窗体
        DataTable dt = new DataTable("meau");
        public meau()
        {


            InitializeComponent();
            //dataCreat();//创建表
            //Load_See();//控件设置



        }

        private void meau_Load(object sender, EventArgs e) //加载表
        {
            DataSet ds = new DataSet();
            using (SqlConnection sql = new SqlConnection())                              //创建打开数据库的链接对象
            {
                sql.ConnectionString = "server=.;database=Stuedent;user=sa;pwd=123";  //打开数据库的  sever=【服务名】;database=数据；user=用户名;pwd=密码;
                sql.Open();                                                              //打开数据库
                using (SqlCommand command = sql.CreateCommand())                        //执行语句的对象
                {

                    // SqlDataAdapter 对象。 用于填充DataSet （数据集）。
                    //SqlDataReader 对象。 从数据库中读取流..后面要做增删改查还需要用到 DataSet 对象。
                    command.CommandText = "select *from menushop";           //执行语句
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    try
                    {
                        da.Fill(ds);  //在添加或刷新行
                        
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            DataTable dt = new DataTable();
            dt = ds.Tables[0].Copy();
            this.dataGridView1.DataSource = dt;





        }
        //dataGridView1.DataSource = dt;
        //private void dataCreat()  //创建表
        //{
        //    // 实例化一张表并定义表结构
        //    dt.Columns.Add("菜单编号");
        //    dt.Columns.Add("菜品名称");
        //    dt.Columns.Add("菜品规格");
        //    dt.Columns.Add("菜品类型");
        //    dt.Columns.Add("菜品价格");
        //    // 该过程为将数据写入表中的第一行      
        //    DataRow dr = dt.NewRow();
        //    dr["菜单编号"] = "001";
        //    dr["菜品名称"] = "冰红茶";
        //    dr["菜品规格"] = "瓶";
        //    dr["菜品类型"] = "饮料";
        //    dr["菜品价格"] = "3";
        //    dt.Rows.Add(dr);
        //    //第二行 

        //    DataRow dr1 = dt.NewRow();
        //    dr1["菜单编号"] = "002";
        //    dr1["菜品名称"] = "雪碧";
        //    dr1["菜品规格"] = "瓶";
        //    dr1["菜品类型"] = "饮料";
        //    dr1["菜品价格"] = "3";
        //    dt.Rows.Add(dr1);
        //    //第三行
        //    DataRow dr2 = dt.NewRow();
        //    dr2["菜单编号"] = "003";
        //    dr2["菜品名称"] = "可乐";
        //    dr2["菜品规格"] = "瓶";
        //    dr2["菜品类型"] = "饮料";
        //    dr2["菜品价格"] = "3";
        //    dt.Rows.Add(dr2);

        //}

        //private void Load_See()  //控件加载设置
        //{
        //    btnadd.Enabled = false;
        //    BtnCancel.Enabled = false;
        //    btnSave.Enabled = false;
        //    BtnFind.Enabled = false;
        //    toolStripComboBox1.Items.Add("瓶");
        //    toolStripComboBox1.Items.Add("份");
        //    toolStripComboBox1.Items.Add("碗");
        //    toolStripComboBox1.Items.Add("全部");

        //    for (int i = 0; i < 10; i++)
        //    {
        //        comboBox1.Items.Add(i);
        //    }

        //}

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            fd.Show();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择桌号");
                return;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnadd.Enabled = true;
            BtnCancel.Enabled = true;
            btnSave.Enabled = true;
            BtnFind.Enabled = true;


        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == string.Empty)
            {
                MessageBox.Show("查询类别不能为空！", "错误提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripComboBox1.Focus();
            }








        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = this.dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品全称
            txtType.Text = this.dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品类型
            txtMoney.Text = this.dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品价格
        }

        double sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxxq.Text += txtName.Text.Trim() + "*1; ";
            //listView1 .Items.Add(textBoxname.Text.Trim()+"*1;");
            sum += Convert.ToDouble(txtMoney.Text.Trim());
            txtSum.Text = sum.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
