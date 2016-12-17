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

namespace GUI
{
    public partial class frmPhong : Form
    {
        Business BUS;
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            MessageBox.Show("xem lại coi có cần các chức năng:thêm sửa xóa hay ko!!!chức năng các nút ko có ngoài gd nhưng trong code vẫn đầy đủ.");
            BUS = new Business();
<<<<<<< HEAD
            dataGV.DataSource = BUS.GetDataPhong();
=======
            dataGV.DataSource = BUS.GetDataPhong("SELECT * FROM Phong");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIDPhong.Text = "";
            txtMaLP.Text = "";
            txtGhiChu.Text = "";
            txtTrangThai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            Phong_DTO P = new Phong_DTO(txtIDPhong.Text, txtMaLP.Text, txtGhiChu.Text, txtTrangThai.Text);
            Boolean status = BUS.ThemPhong(P);
            if (status == true)
            {
                MessageBox.Show("Thêm thành công!");
                dataGV.DataSource = BUS.GetDataPhong("SELECT * FROM Phong");
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Chưa nhập hoặc nhập trùng mã phòng.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            BUS = new Business();
            Phong_DTO P = new Phong_DTO(txtIDPhong.Text, txtMaLP.Text, txtGhiChu.Text, txtTrangThai.Text);
            Boolean status = BUS.ThemPhong(P);
            btnReset_Click(sender, e);
            if (status == true)
            {
                MessageBox.Show("Sửa thành công!");
                dataGV.DataSource = BUS.GetDataPhong("SELECT * FROM Phong");
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            Boolean status = BUS.XoaPhong(txtIDPhong.Text);
            btnReset_Click(sender, e);
            if (status == true)
            {
                MessageBox.Show("Xóa thành công!");
                dataGV.DataSource = BUS.GetDataPhong("SELECT * FROM Phong");
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại! Mã dịch vụ không tồn tại.");
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dataGV.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dataGV.RowCount - 1; i++)
                {
                    dataGV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGV.RowCount - 1; i++)
                {
                    if (dataGV.Rows[i].Cells["IDPhong"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dataGV.Rows[i].Cells["MaLP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dataGV.Rows[i].Cells["TrangThai"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dataGV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGV.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                txtIDPhong.Text = row.Cells[0].Value.ToString();
                txtMaLP.Text = row.Cells[1].Value.ToString();
                txtGhiChu.Text = row.Cells[2].Value.ToString();
                txtTrangThai.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
