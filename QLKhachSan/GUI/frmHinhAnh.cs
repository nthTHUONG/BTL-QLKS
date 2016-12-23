using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GUI
{
    public partial class frmHinhAnh : Form
    {
        //string path;
        //int imgWidth = 50;
        public frmHinhAnh()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHH.Text = lbHH.Text.Substring(1) + lbHH.Text.Substring(0, 1);
        }
        private void LoadImage(string HinhAnh)
        {
            picV.Image = null;
            string[] arrFiles = Directory.GetFiles(HinhAnh);
           foreach(string file in arrFiles)
                if(file.ToLower().EndsWith("PhongKS6.JPG"))
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = Image.FromFile(file);
                    pic.Height = picV.Height - 10;
                    pic.Width = pic.Height * 5 / 4;
                    pic.Cursor = Cursors.Hand;
                    pic.Click += new EventHandler(btP001_Click);
                }
        }
        private void frmHinhAnh_Load(object sender, EventArgs e)
        {
            //LoadImage();
        }

        private void btP001_Click(object sender, EventArgs e)
        {
            
            //picV.Image = pic.Image;
           // LoadImage();
        }
    }
}
