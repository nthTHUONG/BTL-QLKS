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
    public partial class frmThanhToanPhong : Form
    {
        Business BUS;
        public frmThanhToanPhong()
        {
            InitializeComponent();
        }

        private void frmThanhToanPhong_Load(object sender, EventArgs e)
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
            cbbMaKH.ValueMember = "IDKhachHang";
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
            DataTable dt = BUS.GetDataDP(cbbMaKH.Text);
            
            if (dt.Rows.Count > 0)
            {
                txtMaPhong.Text = dt.Rows[0]["MaPhong"].ToString();                
                DataTable dtKH = BUS.GetDataKH(cbbMaKH.Text);
                if (dtKH.Rows.Count > 0)
                {
                    txtTenKH.Text = dtKH.Rows[0]["Ho"].ToString() + " " + dtKH.Rows[0]["Ten"].ToString();
                }
                else
                {
                    txtTenKH.Text = "";   
                }
                txtTraTruoc.Text = dt.Rows[0]["TraTruoc"].ToString().Substring(0, dt.Rows[0]["TraTruoc"].ToString().Length - 5);
                txtNhanPhong.Text = Convert.ToDateTime(dt.Rows[0]["NgayNhan"]).ToString("dd/MM/yyyy");

                if (((DateTime)(dt.Rows[0]["NgayTra"])).ToString("yyyy-MM-dd").Equals(DateTime.Now.ToString("yyyy-MM-dd")) == true)
                {
                    txtDonGia.Text = dt.Rows[0]["GiaThue"].ToString();
                    txtTraPhong.Text = Convert.ToDateTime(dt.Rows[0]["NgayTra"]).ToString("dd/MM/yyyy");
                    txtSoNgayThue.Text = dt.Rows[0]["SoNgayThue"].ToString();
                }
                else
                {
                    txtTraPhong.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    TimeSpan duration = (DateTime.Now).Subtract(Convert.ToDateTime(dt.Rows[0]["NgayNhan"]));
                    int time = Convert.ToInt32(duration.ToString("%d"));
                    txtSoNgayThue.Text = time.ToString();
                    decimal giaPhong = Convert.ToDecimal(BUS.GetDataLP_fromIDPhong(txtMaPhong.Text).Rows[0]["GiaLP"]);
                    txtDonGia.Text = (giaPhong * time).ToString().Substring(0, (giaPhong * time).ToString().Length - 5);
                }
                lbTongTien.Text = (Convert.ToDecimal(txtDonGia.Text) - Convert.ToDecimal(txtTraTruoc.Text)).ToString();
            }
            else
            {
                Init();
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            DataTable dtLP = BUS.GetDataLP_fromIDPhong(txtMaPhong.Text);
            if (dtLP.Rows.Count > 0)
            {
                txtLoaiPhong.Text = dtLP.Rows[0]["TenLP"].ToString();
            }
        }

        private void cbbMaKh_SelectedIndexChanged(object sender, EventArgs e)
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
