using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;

namespace GUI
{
    public partial class frmHH : Form
    {
        Business BUS;
        public frmHH()
        {
            InitializeComponent();
        }
        public SqlConnection sqlcon;
        string cnstr;
        Size sizeImage;
        void ThemHinhVaoDatabase(string tenHinhAnh, byte[] HinhAnh, string MaPhong)
        {
            string sql = "INSERT INTO HinhAnh Values (N'" + tenHinhAnh + "', @HinhAnh, '" + MaPhong + "')";
            SqlParameter prm = new SqlParameter("@HinhAnh", SqlDbType.VarBinary, HinhAnh.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, HinhAnh);
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            sqlcom.Parameters.Add(prm);
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            sqlcon.Close();
        }
        List<Image> getListImage(string maPhong)
        {
            List<Image> lst_image = new List<Image>();
            string sql = @"SELECT HinhAnh FROM HinhAnh WHERE MaPhong = '"+ maPhong +"'";
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            

            while(dr.Read())
            {
                byte[] Mybyte = (byte[])dr["HinhAnh"];
                lst_image.Add(ArrayByteToImage(Mybyte));
            }

            sqlcom.Dispose();
            sqlcon.Close();
            return lst_image;
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            sizeImage = new Size(panel1.Size.Width - 18, panel1.Size.Width / 2);
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            sqlcon = new SqlConnection(cnstr);
            BUS = new Business();
            dataGV.DataSource = BUS.GetDataPhong();
            
        }

        void LoadImage(string MaPhong)
        {
            List<Image> lst_image = getListImage(MaPhong);
            Point p = new Point(0, 0);
            panel1.Controls.Clear();
            foreach (Image img in lst_image)
            {
                
                PictureBox newPtb = new PictureBox();
                panel1.Controls.Add(newPtb);
                newPtb.Size = sizeImage;
                newPtb.Image = img;
                newPtb.SizeMode = PictureBoxSizeMode.StretchImage;
                panel1.Controls.Add(newPtb);
                newPtb.Show();
                newPtb.Location = new Point(p.X, p.Y);
                p.Y += sizeImage.Height;
            }
            
        }
        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                LoadImage(row.Cells["IdPhong"].Value.ToString());
            }
        }
        byte[] ImageToArrayByte(Image img)
        {
            MemoryStream MmStr = new MemoryStream();
            byte[] Mpic = new byte[0];
            try
            {
                img.Save(MmStr, ImageFormat.Png);
                return Mpic = MmStr.ToArray();
            }
            catch
            {
                MessageBox.Show("Hình Ảnh Không Hợp Lệ", "Thông Báo");
                return null;
            }
        }

        Image ArrayByteToImage(byte[] Mybyte)
        {
            MemoryStream Mstr = new MemoryStream(Mybyte);
            return Image.FromStream(Mstr);
        }
        private void bt_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn phòng cần thêm");
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image image;
                string str = openFileDialog1.FileName;
                try
                {
                    image = Image.FromFile(str);
                    
                    byte[] Mpic = ImageToArrayByte(image);
                    if (Mpic == null)
                    {
                        MessageBox.Show("Hình ảnh không hợp lệ");
                        return;
                    }
                    string TenFile = str.Substring(str.LastIndexOf("\\"));
                    ThemHinhVaoDatabase(TenFile, Mpic, dataGV.SelectedRows[0].Cells["IDPhong"].Value.ToString());
                    MessageBox.Show("Thêm thành công");
                    LoadImage(dataGV.SelectedRows[0].Cells["IdPhong"].Value.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông Báo");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
