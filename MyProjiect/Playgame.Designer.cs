namespace MyProjiect
{
    partial class Playgame
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
            this.btnGoback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoback
            // 
            this.btnGoback.Location = new System.Drawing.Point(575, 523);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(75, 23);
            this.btnGoback.TabIndex = 0;
            this.btnGoback.Text = "返回";
            this.btnGoback.UseVisualStyleBackColor = true;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // Playgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 417);
            this.Controls.Add(this.btnGoback);
            this.Name = "Playgame";
            this.Text = "游戏";
            this.Load += new System.EventHandler(this.Playgame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoback;

    }
}