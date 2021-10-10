using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace 加分打地鼠
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        int score = 0;
        int time = 30;
        int pic1=0, pic2=0;
        int[] posx = { 100, 300, 500 };
        int[] posy = { 100, 200 };
        string[] name = new string[5];
        int[] point = new int[5];
        int index=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void 開始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name[index] = Interaction.InputBox("輸入姓名","輸入","名子",-1,-1);
            timer1.Enabled = true;
            timer2.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
        }

        private void 暫停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time = 1;
            timer2.Enabled = true;
        }

        private void 排行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tmp=index;
            if(index<4)
            {
                tmp -= 1;
            }
            string str="";
            for(int i =0;i<=tmp;i++)
            {
                str += name[i] + "的成績" + point[i] + "分"+"\r\n";
            }
            MessageBox.Show(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = score.ToString();
            int p1 = rd.Next(3), p2 = rd.Next(3) ;
            int pp1 = rd.Next(2),pp2 = rd.Next(2);
            while(p1==p2&&pp1==pp2)
            {
                p1 = rd.Next(3);
                pp1 = rd.Next(2);
            }
            if (pic1==0)
            {
                pictureBox1.Top = posy[pp1];
                pictureBox1.Left = posx[p1];
                pictureBox1.Image = Image.FromFile("出現.png");
            }
            else
            {
                pic1 = 0;
            }
            if (pic2==0)
            {
                pictureBox2.Top = posy[pp2];
                pictureBox2.Left = posx[p2];
                pictureBox2.Image = Image.FromFile("出現.png");
            }
            else
            {
                pic2 = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(time==0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                point[index] = score;
                MessageBox.Show(name[index] + "的成績" + point[index].ToString() + "分");
                setplace();
                time = 31;
                score = 0;
                pic1 = 0;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                if (index < 4)
                {
                    index += 1;
                }
            }
            time -= 1;
            label4.Text = time.ToString();
            label2.Text = score.ToString();   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score += 5;
            pic1 = 1;
            pictureBox1.Image = Image.FromFile("打.jpg");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            score += 5;
            pic2 = 1;
            pictureBox2.Image = Image.FromFile("打.jpg");
        }
        private void 難ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 750;
        }

        private void 易ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        void setplace()
        {
            int tmp;
            string tmpname = "";
            for (int i = index; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (point[i] > point[j])
                    {
                        tmp = point[i];
                        point[i] = point[j];
                        point[j] = tmp;
                        tmpname = name[i];
                        name[i] = name[j];
                        name[j] = tmpname;
                    }
                }
            }
        }
    }
}
