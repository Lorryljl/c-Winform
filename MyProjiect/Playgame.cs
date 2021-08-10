using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjiect
{
    
    public partial class Playgame : Form
    {
        public static App Appfm;
        public Playgame()
        {
            InitializeComponent();
        }
        Panel bg = new Panel();
        //创建管子
        Timer greatguan = new Timer();
        //创建鸟
        PictureBox bird = new PictureBox();
        //创建鸟飞计时器
        Timer fly = new Timer();
        //创建鸟移动动画
        Timer birdfly = new Timer();
        //记录鸟的图片
        int tu = 0;
        //管子的移动
        Timer gd = new Timer();
        //释放的管子装到这里
        List<PictureBox> gbox = new List<PictureBox>();
        //创建得分板
        Label defen = new Label();
        //记录分数
        int count = 0;
        Random r = new Random();
       
       
     

        //创建管子的计时器
        private void Greatguan_Tick(object sender, EventArgs e)
        {
            PictureBox tguan = new PictureBox();
            tguan.Image = Properties.Resources.柱子上;
            tguan.Size = new Size(50, r.Next(150, 180));
            tguan.SizeMode = PictureBoxSizeMode.StretchImage;
            tguan.BackColor = Color.Transparent;
            tguan.Left = 420;
            tguan.Top = 0;
            tguan.Tag = "guan";
            bg.Controls.Add(tguan);
            gbox.Add(tguan);
            PictureBox bguan = Guan(); //同时创建上下的柱子
        }
        //创建下边管子
        private PictureBox Guan()
        {
            PictureBox bguan = new PictureBox();
            bguan.Image = Properties.Resources.柱子下;
            bguan.Size = new Size(50, r.Next(100, 150));
            bguan.SizeMode = PictureBoxSizeMode.StretchImage;
            bguan.BackColor = Color.Transparent;
            bguan.Left = 420;
            bguan.Top = bg.Height - bguan.Height;
            bguan.Tag = "guan1";
            bg.Controls.Add(bguan);
            gbox.Add(bguan);
            return bguan;
        }
        //管子移动的计时器
        private void Gd_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox item in bg.Controls)
            {
                if (item.Tag.ToString() == "guan" || item.Tag.ToString() == "jiafen" || item.Tag.ToString() == "guan1")
                {
                    item.Left -= 3;
                    if (item.Left + item.Width <= 0)
                    {
                        item.Dispose();
                    }
                    else if (item.Left <= item.Width / 2)
                    {
                        if (item.Tag.ToString() == "guan")
                        {
                            
                            count += 1;
                            defen.Text = count + "分";
                        }
                        item.Tag = "jiafen";
                    }
                    //判断小鸟是碰撞转图片框
                    if (bird.Left + bird.Width >= item.Left && bird.Top + bird.Height >= item.Top && bird.Left <= item.Left + item.Width && bird.Top <= item.Top + item.Height) 
                    {
                        bird.Visible = false;
                        clearguan();
                        greatguan.Stop();
                        gd.Stop();
                        fly.Stop();
                        if (MessageBox.Show("游戏结束", "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                        {
                            bird.Visible = true;
                            bird.Location = new Point(0, bg.Height / 2 - bird.Height / 2);
                            greatguan.Start();
                            gd.Start();
                            fly.Start();
                        }
                        else
                        {
                            App.Play = this;
                            this.Close();
                            Appfm.Show();
                        }
                    }
                }
                if (item.Tag.ToString() == "bird")
                {
                    birdfly.Start();
                    if (item.Top >= bg.Height)
                    {
                        item.Visible = false;
                        clearguan();
                        greatguan.Stop();
                        gd.Stop();
                        fly.Stop();
                        //如果点击重试，重新创建开始开始
                        if (MessageBox.Show("游戏结束", "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                        {
                            item.Visible = true;
                            bird.Location = new Point(0, bg.Height / 2 - bird.Height / 2);
                            greatguan.Start();
                            gd.Start();
                            fly.Start();
                        }
                        else
                        {
                            App.Play = this;
                            this.Close();
                            Appfm.Show();
                        }
                    }
                }
            }
        }
        //鸟飞动画
        private void Fly_Tick(object sender, EventArgs e)
        {
            tu++;
            if (tu > 2)
            {
                tu = 0;
            }
            bird.Image = Properties.Resources.小鸟1;
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.BackColor = Color.Transparent;
        }
        //创建鸟移动动画
        private void Birdfly_Tick(object sender, EventArgs e)
        {
            bird.Top += 8;     //小鸟的高度逐渐向下
        }
        //清除管子
        private void clearguan()
        {
            foreach (PictureBox guan in gbox)
            {
                guan.Dispose();
            }
        }
        //窗口键盘按下事件
        private void Playgame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                bird.Top -= 15;
            }
            if (e.KeyCode == Keys.Down)
            {
                bird.Top += 15;
            }
        }

       

        private void Playgame_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 500);
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
            //创建游戏区
            bg.Size = new Size(400, 400);
            bg.Location = new Point(20, 10);
            bg.BackgroundImage = Properties.Resources.background;
            bg.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(bg);

            //创建管子
            greatguan.Interval = 1500;
            greatguan.Tick += Greatguan_Tick;
            greatguan.Start();

            //管子的移动
            gd.Interval = 30;
            gd.Tick += Gd_Tick;
            gd.Start();

            //创建鸟
            bird.Size = new Size(35, 35);
            bird.Location = new Point(0, bg.Height / 2 - bird.Height / 2);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.BackColor = Color.Transparent;
            bird.Tag = "bird";
            bg.Controls.Add(bird);

            //创建鸟飞计时器
            fly.Interval = 40;
            fly.Tick += Fly_Tick;
            fly.Start();

            //创建鸟移动动画
            birdfly.Interval = 500;
            birdfly.Tick += Birdfly_Tick;
            birdfly.Start();

            //创建得分板
            defen.Text = 0 + "分";
            defen.AutoSize = true;
            defen.Location = new Point(430, 20);
            defen.BorderStyle = BorderStyle.FixedSingle;
            defen.Font = new Font("", 20);
            this.Controls.Add(defen);

            this.KeyDown += Playgame_KeyDown;

            
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            App.Play = this;       
            clearguan();
            greatguan.Stop();
            gd.Stop();
            fly.Stop();
           
            this.Close();
            Appfm.Visible = true;
           
        }
    }
}

 
