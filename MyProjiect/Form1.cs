using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSystemTime.Text = DateTime.Now.ToString();
            //meau s = new meau();
            //s.ShowDialog();
            this.BackgroundImage = Properties.Resources.background;
            progressBar1.Value = 0;//初始进度条的值
            progressBar1.Minimum = 0;//进度条最小值
            progressBar1.Maximum = 1;//进度条最大值
            txtpsw.PasswordChar = '*';
            
         
        }
 

        private void Form1_Resize(object sender, EventArgs e)
        {
            lblSystemTime.Left = (this.Width - lblSystemTime.Width) / 2;
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void label2_Click(object sender, EventArgs e) //设置点击名字光标进入编辑
        {
            txtName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtpsw.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)   //判断进度
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                App app = new App();
                this.Hide();
                app.ShowDialog();
               
                
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length==0||txtpsw.Text.Length==0)
            {
                MessageBox.Show("账户密码不能为空！");
                return;
            }
            if (txtName.Text=="admin"&&txtpsw.Text=="admin")
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("账户名或密码错误！");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Text = DateTime.Now.ToString();
        }


     
      
    }
}
