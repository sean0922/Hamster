namespace 加分打地鼠
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打維尼遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暫停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.排行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.難易度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.難ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.易ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打維尼遊戲ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打維尼遊戲ToolStripMenuItem
            // 
            this.打維尼遊戲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開始ToolStripMenuItem,
            this.暫停ToolStripMenuItem,
            this.結束ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.排行ToolStripMenuItem,
            this.難易度ToolStripMenuItem});
            this.打維尼遊戲ToolStripMenuItem.Name = "打維尼遊戲ToolStripMenuItem";
            this.打維尼遊戲ToolStripMenuItem.Size = new System.Drawing.Size(112, 28);
            this.打維尼遊戲ToolStripMenuItem.Text = "打維尼遊戲";
            // 
            // 開始ToolStripMenuItem
            // 
            this.開始ToolStripMenuItem.Name = "開始ToolStripMenuItem";
            this.開始ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.開始ToolStripMenuItem.Text = "開始";
            this.開始ToolStripMenuItem.Click += new System.EventHandler(this.開始ToolStripMenuItem_Click);
            // 
            // 暫停ToolStripMenuItem
            // 
            this.暫停ToolStripMenuItem.Name = "暫停ToolStripMenuItem";
            this.暫停ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.暫停ToolStripMenuItem.Text = "暫停";
            this.暫停ToolStripMenuItem.Click += new System.EventHandler(this.暫停ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // 排行ToolStripMenuItem
            // 
            this.排行ToolStripMenuItem.Name = "排行ToolStripMenuItem";
            this.排行ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.排行ToolStripMenuItem.Text = "排行";
            this.排行ToolStripMenuItem.Click += new System.EventHandler(this.排行ToolStripMenuItem_Click);
            // 
            // 難易度ToolStripMenuItem
            // 
            this.難易度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.難ToolStripMenuItem,
            this.中ToolStripMenuItem,
            this.易ToolStripMenuItem});
            this.難易度ToolStripMenuItem.Name = "難易度ToolStripMenuItem";
            this.難易度ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.難易度ToolStripMenuItem.Text = "難易度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(463, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "分數:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(566, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(687, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "時間:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(790, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::加分打地鼠.Properties.Resources.出現;
            this.pictureBox1.Location = new System.Drawing.Point(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::加分打地鼠.Properties.Resources.出現;
            this.pictureBox2.Location = new System.Drawing.Point(700, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // 難ToolStripMenuItem
            // 
            this.難ToolStripMenuItem.Name = "難ToolStripMenuItem";
            this.難ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.難ToolStripMenuItem.Text = "難";
            this.難ToolStripMenuItem.Click += new System.EventHandler(this.難ToolStripMenuItem_Click);
            // 
            // 中ToolStripMenuItem
            // 
            this.中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            this.中ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.中ToolStripMenuItem.Text = "中";
            this.中ToolStripMenuItem.Click += new System.EventHandler(this.中ToolStripMenuItem_Click);
            // 
            // 易ToolStripMenuItem
            // 
            this.易ToolStripMenuItem.Name = "易ToolStripMenuItem";
            this.易ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.易ToolStripMenuItem.Text = "易";
            this.易ToolStripMenuItem.Click += new System.EventHandler(this.易ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::加分打地鼠.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(908, 429);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打維尼遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暫停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 排行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 難易度ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem 難ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 易ToolStripMenuItem;
    }
}

