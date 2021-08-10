using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjiect
{
    
    public partial class MovieFm : Form
    {
        public static App Appfm { get; set; }
        List<string> pathList = new List<string>(); //用于储存路径
        public MovieFm()
        {
            InitializeComponent();
           
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "媒体文件（所有类型）|*.mp3;*.mpeg;*.wma;*.wmv;*.wav;*.avi;*.mov";
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            if (pathList.Contains(ofd.FileName))//判断音乐是否已经加入，如果加入光标定位至该歌曲
            {
                MessageBox.Show("该视频已存在");
                int num = pathList.IndexOf(ofd.FileName);    //获取下标
                listBox1.SetSelected(num, true);
                return;
            }
            pathList.Add(ofd.FileName);
            listBox1.Items.Add(Path.GetFileName(ofd.FileName));
            axWindowsMediaPlayer1.URL = ofd.FileName;
            listBox1.SetSelected(listBox1.Items.Count-1,true);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pathList[listBox1.SelectedIndex];
            listBox1.SetSelected(listBox1.SelectedIndex, true);
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            this.Close();
            Appfm.Visible = true;
            App.mo = this;
        }

    }
}
