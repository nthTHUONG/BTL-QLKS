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

        DataSet ds;
        string cnstr;
        SqlConnection cn;
        public frmThemKH()
        {
            InitializeComponent();
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnstr);
        }
       
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            cn.Open();
            string s = "INSERT INTO KhachHang(IDKhachHang, Ho, Ten, GioiTinh, DiaChi, SDT, Email, QuocTich) VALUES (@id, @ho, @ten, @gioitinh, @diachi, @sdt, @email, @quoctich)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.Add("@id", SqlDbType.NChar, 10, "IDKhachHang");
            cmd.Parameters.Add("@ho", SqlDbType.NVarChar, 50, "Ho");
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50, "Ten");
            cmd.Parameters.Add("@gioitinh", SqlDbType.NChar, 10, "GioiTinh");
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50, "DiaChi");
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 50, "SDT");
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50, "Email");
            cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar, 50, "QuocTich");
            //da.InsertCommand = cmd;

            //da.Update(ds);
           //set prameter
            cmd.Parameters["@id"].Value = txtIDKhachHang.Text;
            cmd.Parameters["@ho"].Value = txtTen.Text;
            cmd.Parameters["@ten"].Value = txtTen.Text;
            cmd.Parameters["@gioitinh"].Value = txtGioiTinh.Text;
            cmd.Parameters["@diachi"].Value = txtDiaChi.Text;
            cmd.Parameters["@sdt"].Value = txtSDT.Text;
            cmd.Parameters["@email"].Value = txtEmail.Text;
            cmd.Parameters["@quoctich"].Value = txtQuocTich.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("thành công!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: "+ ex.Message,"thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            cn.Close();
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }
    }
}
