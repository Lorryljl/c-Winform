namespace MyProjiect
{
    partial class MusicFm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.Location = new System.Drawing.Point(203, 43);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 36);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.Color.Transparent;
            this.btnGoback.Location = new System.Drawing.Point(406, 0);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(75, 35);
            this.btnGoback.TabIndex = 2;
            this.btnGoback.Text = "返回";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Location = new System.Drawing.Point(203, 118);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "移除";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnLast
            // 
            this.btnLast.AutoSize = true;
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.Location = new System.Drawing.Point(203, 207);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(90, 36);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "上一首";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnnext
            // 
            this.btnnext.AutoSize = true;
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.Location = new System.Drawing.Point(203, 285);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(90, 36);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = "下一首";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.ForeColor = System.Drawing.Color.Transparent;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 373);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // MusicFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 373);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGoback);
            this.Name = "MusicFm";
            this.Text = "音乐播放器";
            this.Resize += new System.EventHandler(this.MusicFm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.ListBox listBox1;
    }
}