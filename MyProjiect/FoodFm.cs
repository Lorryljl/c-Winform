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
    public partial class FoodFm : Form
    {
        public static App Appfm { get; set; } //创建APP窗体属性，用于跳转
        meau cdmeau = new meau();   //创建meau窗体 用于跳转
        //public static   Dictionary<string, string> yh = new Dictionary<string, string>(); //创建静态键值对，用于存储用户注册的账号密码
        FoodZcfm fdzc = new FoodZcfm();   //创建注册窗体
        public FoodFm()
        {
            InitializeComponent();
            txtpsw.PasswordChar = '*';
            this.BackgroundImage = Properties.Resources.foodback;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FoodFm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 0 || txtpsw.Text.Length == 0)
            {
                MessageBox.Show("账号密码不能为空！请重新输入");
                return;
            }
            #region 方法一
            //if (yh.ContainsKey(txtPhone.Text))
            //{
            //    if (txtpsw.Text == yh[txtPhone.Text])
            //    {
            //        this.Hide();
            //        meau.fd = this;
            //        cdmeau.ShowDialog();

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("没有该用户请先注册！");
            //    return;
            //} 
            #endregion
            string sql = "server=.;Database=Stuedent;user=sa;pwd=123";
            using (SqlConnection con = new SqlConnection(sql))
            {
                con.Open();
                string select = string.Format("select 手机号码,密码 from food where 手机号码={0} and 密码={1}", txtPhone.Text, txtpsw.Text);//sql命令行

                using (SqlCommand cmd = new SqlCommand(select, con))  //存储过程
                {
                
                    int result = Convert.ToInt32(cmd.ExecuteScalar()); 
                    if (result == 0)//如果不存在
                    {
                        MessageBox.Show("此用户不存在，请先注册！");
                        return;
                    }
                    else//如果存在
                    {
                        MessageBox.Show("登录成功！");

                        this.Hide();
                        meau.fd = this;
                        cdmeau.ShowDialog();


                    }
                }
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FoodZcfm.fd = this;
            fdzc.ShowDialog();

        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            this.Close();
            Appfm.Visible = true;
            App.fd = this;
        }

    }
}
