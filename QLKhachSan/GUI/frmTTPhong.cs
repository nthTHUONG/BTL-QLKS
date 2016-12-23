using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmTTPhong : Form
    {
        Business BUS;
<<<<<<< HEAD:QLKhachSan/GUI/frmTTPhong.cs
        decimal donGia;
        public frmTTPhong()
=======
        public frmThanhToanPhong()
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a:QLKhachSan/GUI/frmThanhToanPhong.cs
        {
            InitializeComponent();
        }

        private void frmTTPhong_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            LoadComBoBox();
            Init();
        }

        private void LoadComBoBox()
        {
            cbbMaNV.DataSource = BUS.GetDataNV();
            cbbMaNV.DisplayMember = "IDNhanVien";
            cbbMaKH.DataSource = BUS.GetDataKH();
            cbbMaKH.DisplayMember = "IDKhachHang";
<<<<<<< HEAD:QLKhachSan/GUI/frmTTPhong.cs
=======
            cbbMaKH.ValueMember = "IDKhachHang";
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a:QLKhachSan/GUI/frmThanhToanPhong.cs
        }

        private void Init()
        {
            cbbMaNV.Text = "Chọn mã nhân viên";
            cbbMaKH.Text = "Chọn mã khách hàng";
            txtMaPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtDonGia.Text = "";
            txtTraTruoc.Text = "";
            txtNhanPhong.Text = "";
            txtTraPhong.Text = "";
            txtSoNgayThue.Text = "";
            txtGhiChu.Text = "";
            lbTongTien.Text = "";
        }

        private void AutoValue()
        {
<<<<<<< HEAD:QLKhachSan/GUI/frmTTPhong.cs
            DataTable dt = BUS.GetDataDP_fromMaKH(cbbMaKH.Text);
            
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtMaPhong.Text = row["MaPhong"].ToString();                
                DataTable dtKH = BUS.GetDataKH();
=======
            DataTable dt = BUS.GetDataDP(cbbMaKH.Text);
            
            if (dt.Rows.Count > 0)
            {
                txtMaPhong.Text = dt.Rows[0]["MaPhong"].ToString();                
                DataTable dtKH = BUS.GetDataKH(cbbMaKH.Text);
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a:QLKhachSan/GUI/frmThanhToanPhong.cs
                if (dtKH.Rows.Count > 0)
                {
                    txtTenKH.Text = dtKH.Rows[0]["Ho"].ToString() + " " + dtKH.Rows[0]["Ten"].ToString();
                }
                else
                {
                    txtTenKH.Text = "";   
                }
<<<<<<< HEAD:QLKhachSan/GUI/frmTTPhong.cs
                txtTraTruoc.Text = row["TraTruoc"].ToString().Substring(0, row["TraTruoc"].ToString().Length - 5);
                txtNhanPhong.Text = Convert.ToDateTime(row["NgayNhan"]).ToString("dd/MM/yyyy");
                if (((DateTime)(row["NgayTra"])).ToString("yyyy-MM-dd").Equals(DateTime.Now.ToString("yyyy-MM-dd")) == true)
                {
                    txtDonGia.Text = row["GiaThue"].ToString();
                    txtTraPhong.Text = Convert.ToDateTime(row["NgayTra"]).ToString("dd/MM/yyyy");
                    txtSoNgayThue.Text = row["SoNgayThue"].ToString();
=======
                txtTraTruoc.Text = dt.Rows[0]["TraTruoc"].ToString().Substring(0, dt.Rows[0]["TraTruoc"].ToString().Length - 5);
                txtNhanPhong.Text = Convert.ToDateTime(dt.Rows[0]["NgayNhan"]).ToString("dd/MM/yyyy");

                if (((DateTime)(dt.Rows[0]["NgayTra"])).ToString("yyyy-MM-dd").Equals(DateTime.Now.ToString("yyyy-MM-dd")) == true)
                {
                    txtDonGia.Text = dt.Rows[0]["GiaThue"].ToString();
                    txtTraPhong.Text = Convert.ToDateTime(dt.Rows[0]["NgayTra"]).ToString("dd/MM/yyyy");
                    txtSoNgayThue.Text = dt.Rows[0]["SoNgayThue"].ToString();
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a:QLKhachSan/GUI/frmThanhToanPhong.cs
                }
                else
                {
                    txtTraPhong.Text = DateTime.Now.ToString("dd/MM/yyyy");
<<<<<<< HEAD:QLKhachSan/GUI/frmTTPhong.cs
                    TimeSpan duration = (DateTime.Now).Subtract(Convert.ToDateTime(row["NgayNhan"]));
                    int time = Convert.ToInt32(duration.ToString("%d"));
                    txtSoNgayThue.Text = time.ToString();
                    if (time != 0)
                    {
                        donGia *= time;
                    }
                    txtDonGia.Text = donGia.ToString().Substring(0, donGia.ToString().Length - 5);
=======
                    TimeSpan duration = (DateTime.Now).Subtract(Convert.ToDateTime(dt.Rows[0]["NgayNhan"]));
                    int time = Convert.ToInt32(duration.ToString("%d"));
                    txtSoNgayThue.Text = time.ToString();
                    decimal giaPhong = Convert.ToDecimal(BUS.GetDataLP_fromIDPhong(txtMaPhong.Text).Rows[0]["GiaLP"]);
                    txtDonGia.Text = (giaPhong * time).ToString().Substring(0, (giaPhong * time).ToString().Length - 5);
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a:QLKhachSan/GUI/frmThanhToanPhong.cs
                }
                lbTongTien.Text = (donGia - Convert.ToDecimal(txtTraTruoc.Text)).ToString();
            }
            else
            {
                Init();
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD:QLKhachSan/GUI/frmTTPhong.cs
            DataTable dt = BUS.GetDataLP_fromIDPhong(txtMaPhong.Text);
            if (dt.Rows.Count > 0)
            {
                txtLoaiPhong.Text = dt.Rows[0]["TenLP"].ToString();
                donGia = Convert.ToDecimal(dt.Rows[0]["GiaLP"]);
            }
        }

        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
=======
            DataTable dtLP = BUS.GetDataLP_fromIDPhong(txtMaPhong.Text);
            if (dtLP.Rows.Count > 0)
            {
                txtLoaiPhong.Text = dtLP.Rows[0]["TenLP"].ToString();
            }
        }

        private void cbbMaKh_SelectedIndexChanged(object sender, EventArgs e)
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a:QLKhachSan/GUI/frmThanhToanPhong.cs
        {
            // Tự động điền dữ liệu
            AutoValue();

            // Phòng trả về trạng thái True

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không tìm thấy máy in!!!");   
        }

        private void btOK_Click(object sender, EventArgs e)
        {

        }
    }
}
