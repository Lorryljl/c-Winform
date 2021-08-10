namespace MyProjiect
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFood = new System.Windows.Forms.Button();
            this.btngame = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.btngame);
            this.panel1.Controls.Add(this.btnVideo);
            this.panel1.Controls.Add(this.btnMusic);
            this.panel1.Location = new System.Drawing.Point(44, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 383);
            this.panel1.TabIndex = 3;
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(261, 196);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(143, 125);
            this.btnFood.TabIndex = 3;
            this.btnFood.Text = "外卖";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btngame
            // 
            this.btngame.Location = new System.Drawing.Point(61, 196);
            this.btngame.Name = "btngame";
            this.btngame.Size = new System.Drawing.Size(143, 125);
            this.btngame.TabIndex = 2;
            this.btngame.Text = "游戏";
            this.btngame.UseVisualStyleBackColor = true;
            this.btngame.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(261, 32);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(143, 125);
            this.btnVideo.TabIndex = 1;
            this.btnVideo.Text = "视频";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(61, 32);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(143, 125);
            this.btnMusic.TabIndex = 0;
            this.btnMusic.Text = "音乐";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 444);
            this.Controls.Add(this.panel1);
            this.Name = "App";
            this.Text = "App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_FormClosing);
            this.Resize += new System.EventHandler(this.App_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btngame;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnMusic;
    }
}