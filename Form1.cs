using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void picture1_show(Bitmap Image_in)
        {
            // Bitmap Image_in;
            pictureBox1.Image = Image_in;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\School1.png"));
            picture1_show(bmp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\School2.png"));
            picture1_show(bmp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\School3.png"));
            picture1_show(bmp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Social1.png"));
            picture1_show(bmp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Social2.png"));
            picture1_show(bmp);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Social3.png"));
            picture1_show(bmp);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Health1.png"));
            picture1_show(bmp);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Health2.png"));
            picture1_show(bmp);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Health3.png"));
            picture1_show(bmp);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Shopping1.png"));
            picture1_show(bmp);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Shopping2.png"));
            picture1_show(bmp);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Shopping3.png"));
            picture1_show(bmp);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Cooking1.png"));
            picture1_show(bmp);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Cooking2.png"));
            picture1_show(bmp);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Cooking3.png"));
            picture1_show(bmp);
        }

        private void nhóm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Bank1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Bank2.png"));
            picture1_show(bmp);
        }

        private void nhóm1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Personality1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Personality2.png"));
            picture1_show(bmp);
        }

        private void nhóm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Personality3.png"));
            picture1_show(bmp);
        }

        private void nhóm4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Personality4.png"));
            picture1_show(bmp);
        }

        private void nhóm1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Mistake1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Mistake2.png"));
            picture1_show(bmp);
        }

        private void nhóm3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Mistake3.png"));
            picture1_show(bmp);
        }

        private void nhóm4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\Mistake4.png"));
            picture1_show(bmp);
        }

        private void nhóm1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai9_1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai9_2.png"));
            picture1_show(bmp);
        }

        private void nhóm3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai9_3.png"));
            picture1_show(bmp);
        }

        private void nhóm1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai10_1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai10_2.png"));
            picture1_show(bmp);
        }

        private void nhóm3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai10_3.png"));
            picture1_show(bmp);
        }

        private void nhóm1ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai11_1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai11_2.png"));
            picture1_show(bmp);
        }

        private void nhóm3ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai11_3.png"));
            picture1_show(bmp);
        }

        private void nhóm4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai11_4.png"));
            picture1_show(bmp);
        }

        private void nhóm1ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai12_1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai12_2.png"));
            picture1_show(bmp);
        }

        private void nhóm3ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai12_3.png"));
            picture1_show(bmp);
        }

        private void bài13ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhóm1ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai13_1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai13_2.png"));
            picture1_show(bmp);
        }

        private void nhóm3ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai13_3.png"));
            picture1_show(bmp);
        }

        private void nhóm4ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai13_4.png"));
            picture1_show(bmp);
        }

        private void nhóm1ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai14_1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai14_2.png"));
            picture1_show(bmp);
        }

        private void nhóm3ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai14_3.png"));
            picture1_show(bmp);
        }

        private void bài15ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhóm1ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai15_1.png"));
            picture1_show(bmp);
        }

        private void nhóm2ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Image.FromFile(@"Images\bai15_2.png"));
            picture1_show(bmp);
        }
    }
    }
    
    

