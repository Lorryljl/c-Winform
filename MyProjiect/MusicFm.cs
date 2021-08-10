using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MyProjiect
{
    public partial class MusicFm : Form
    {
        public static App Appfm { get; set; }

        
        public MusicFm()
        {
            InitializeComponent();
            btnGoback.Left = this.Width - btnGoback.Width;
            this.BackgroundImage = Properties.Resources.musicbackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            
        }
        List<string> pathList = new List<string>(); //用于储存路径
        SoundPlayer sound = new SoundPlayer();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"音乐文件|*.wav|所有文件|*.*";
            if (ofd.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            if (pathList.Contains(ofd.FileName))//判断音乐是否已经加入，如果加入光标定位至该歌曲
            {
                MessageBox.Show("该歌曲以存在！");
                int  num=  pathList.IndexOf(ofd.FileName);    //获取下标
                listBox1.SetSelected(num,true);
                return;
            }
            pathList.Add(ofd.FileName);
            listBox1.Items.Add(Path.GetFileName(ofd.FileName));
            sound.SoundLocation = ofd.FileName;
            sound.Play();
        }

      
        //实现双击播放音乐
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            sound.SoundLocation = pathList[listBox1.SelectedIndex];
            sound.Play();
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            this.Close();
            Appfm.Visible = true;
            App.mu = this;
        }

        private void MusicFm_Resize(object sender, EventArgs e)
        {
            btnGoback.Left = this.Width - btnGoback.Width;
            btnOpen.Left =  listBox1.Width+(this.Width - listBox1.Width) / 2;
            btnLast.Left = listBox1.Width + (this.Width - listBox1.Width) / 2;
            btnRemove.Left = listBox1.Width + (this.Width - listBox1.Width) / 2;
            btnnext.Left = listBox1.Width + (this.Width - listBox1.Width) / 2;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem==null)
            {
                MessageBox.Show("请先选择你要删除的歌曲!");
                return;
            }
            int num = listBox1.SelectedIndex;
            pathList.Remove(pathList[num]);
            listBox1.Items.Remove(listBox1.Items[num]);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count==0)
            {
                MessageBox.Show("请先添加歌曲！");
                return;
            }
            int index = listBox1.SelectedIndex; //获得当前选中歌曲的索引
            index--;

            if (index <0)
            {
                index = listBox1.Items.Count-1;
            }
            listBox1.SelectedIndex = index; //将改变后的索引重新赋值给我当前选中项的索引
            sound.SoundLocation = pathList[index];
            sound.Play();

            
          
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请先添加歌曲！");
                return;
            }
            int index = listBox1.SelectedIndex; //获得当前选中歌曲的索引
            index++;

            if (index ==listBox1.Items.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index; //将改变后的索引重新赋值给我当前选中项的索引
            sound.SoundLocation = pathList[index];
            sound.Play();
        }
        }

       
 
}
