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
    public partial class FoodZcfm : Form
    {
        public static FoodFm fd { get; set; }
        public FoodZcfm()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.foodZcbackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            txtpsw1.PasswordChar = '*';
            txtpsw2.PasswordChar = '*';
        }

        private void btnZc_Click(object sender, EventArgs e)
        {


            if (txtName.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtpsw1.Text.Trim() == "" || txtpsw2.Text.Trim() == "")
            {
                MessageBox.Show("文本框不能为空，请重新输入！");
                return;

            }
            if (txtPhone.Text.Length != 11)
            {
                MessageBox.Show("手机号错误，请规范填写");
                return;
            }

            else if (txtpsw1.Text.Trim() == "" || txtpsw1.Text.Length < 6 || txtpsw1.Text.Length > 12)
            {
                MessageBox.Show("密码错误，请规范填写6-12位！");
                return;
            }
            else if (txtpsw2.Text.Trim() == "")
            {
                MessageBox.Show("密码错误，请规范填写6-12位!");
                return;
            }
            else if (txtpsw1.Text.Trim() != txtpsw2.Text.Trim())
            {
                MessageBox.Show("两次输入密码必须一致!");
                return;
            }
            #region 方法一
            //else
            //{
            //    FoodFm.yh.Add(txtPhone.Text.Trim(), txtpsw1.Text.Trim());
            //    MessageBox.Show("注册成功！");
            //} 
            #endregion
            string select = string.Format("select 手机号码 from food where 手机号码={0}", txtPhone.Text);//创建查找命令语句
            using (SqlCommand com = new SqlCommand(select, sql)) // 
            {
                int result = Convert.ToInt32(com.ExecuteScalar());
                if (result == 0)//如果不存在
                {
                    //创建插入语句
                    string insert = string.Format("insert into food(手机号码,用户名,密码)values({0},{1},{2})", txtPhone.Text, txtName.Text, txtpsw1.Text);
                    SqlCommand cominsert = new SqlCommand(insert, sql);//
                    cominsert.ExecuteNonQuery();//执行语句影响
                    MessageBox.Show("注册成功");


                }
                else//存在
                {
                    MessageBox.Show("该用户以被注册,请重新输入！");
                    return;

                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            fd.Show();

        }
        SqlConnection sql = new SqlConnection();  //数据库链接
        private void FoodZcfm_Load(object sender, EventArgs e)
        {

            sql.ConnectionString = "server=.;database=Stuedent;user=sa;pwd=123";
            sql.Open();


        }
    }
}
