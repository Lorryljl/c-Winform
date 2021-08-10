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
    public partial class App : Form
    {
        public static MusicFm mu { get; set; }
        public static MovieFm  mo { get; set; }
        public static Playgame Play { get; set; }
        public static FoodFm fd { get; set; }
        MusicFm music = new MusicFm(); //创建一个音乐实例窗体    
        MovieFm video = new MovieFm();//创建一个视频实例窗体
        Playgame Playfm = new Playgame(); //创建一个游戏实例窗体
        FoodFm food = new FoodFm();//创建一个外卖实例窗体
        public App()
        {
            InitializeComponent();
            //窗体的背景
            this.BackgroundImage = Properties.Resources.壁纸;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //外卖的背景
            btnFood.Image = Properties.Resources.外卖;
            btnFood.BackgroundImageLayout = ImageLayout.None ;
            //音乐的背景
            btnMusic.Image = Properties.Resources.music;
            btnMusic.BackgroundImageLayout = ImageLayout.Zoom;
           
            //备注忘的背景
            btngame.Image = Properties.Resources.备注忘;
            btngame.BackgroundImageLayout = ImageLayout.Zoom;
            //视频的背景
            btnVideo.Image = Properties.Resources.视频;
            btnVideo.BackgroundImageLayout = ImageLayout.Zoom;
            
           
        }

      

        private void btnMusic_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MusicFm.Appfm = this;           
            music.ShowDialog();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MovieFm.Appfm = this;
            video.ShowDialog();
        }

        private void btntxt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Playgame.Appfm = this;
            Playfm.ShowDialog();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FoodFm.Appfm = this;
            food.ShowDialog();
        }

        private void App_Resize(object sender, EventArgs e)
        {
            panel1.Left=(this.Width-panel1.Width)/2;
            panel1.Top = (this.Top - panel1.Top) / 2;
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e) //用户关闭App窗体随之程序关闭
        {
            Application.Exit();
        }
    }
}
