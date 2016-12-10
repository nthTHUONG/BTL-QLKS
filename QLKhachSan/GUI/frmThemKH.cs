using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace GUI
{
    public partial class frmThemKH : Form
    {
        string cnstr;
        SqlConnection cn;
        DataSet ds;
        public frmThemKH()
        {
            InitializeComponent();
        }
        private void frmThemKH_Load(object sender, EventArgs e)
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnstr);
        }

        private void ThemKH(string idKH, string hoKH, string tenKH, string gioitinhKH, string sdtKH, string emailKH, string diachiKH, string quoctichKH)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                string add = "INSERT INTO KhachHang(IDKhachHang, Ho, Ten, GioiTinh, SDT, Email, DiaChi, QuocTich) VALUES (@idKhachHang, @ho, @ten, @gioitinh, @sdt, @email, @diachi, @quoctich)";
                SqlCommand cmd = new SqlCommand(add, cn);
                cmd.Parameters.AddWithValue("@idKhachHang", idKH);
                cmd.Parameters.AddWithValue("@ho", hoKH);
                cmd.Parameters.AddWithValue("@ten", tenKH);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinhKH);
                cmd.Parameters.AddWithValue("@sdt", sdtKH);
                cmd.Parameters.AddWithValue("@email", emailKH);
                cmd.Parameters.AddWithValue("@diachi", diachiKH);
                cmd.Parameters.AddWithValue("@quoctich", quoctichKH);
                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            ThemKH(txtIDKhachHang.Text, txtHo.Text, txtTen.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text, txtQuocTich.Text);
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }
    }
}
