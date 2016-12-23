﻿using System;
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
        decimal donGia;
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
            
        }

        private void Init()
        {
            cbbMaNV.Text = "Chọn mã nhân viên";
            cbbMaKH.Text = "Chọn mã khách hàng";
            txtTenKH.Text = "";
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
        //private void donGia()
        //{
        //    txtDonGia.Text = "GiaPhong";
            
        //}
        private void AutoValue()
        {
            DataTable dt = BUS.GetDataDP_fromMaKH(cbbMaKH.Text);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtMaPhong.Text = row["MaPhong"].ToString();
                DataTable dtKH = BUS.GetDataKH();
                if (dtKH.Rows.Count > 0)
                {
                    txtTenKH.Text = dtKH.Rows[cbbMaKH.SelectedIndex]["Ho"].ToString() + " " + dtKH.Rows[0]["Ten"].ToString();
                }
                else
                {
                    txtTenKH.Text = "";
                }
                txtTraTruoc.Text = row["TraTruoc"].ToString().Substring(0, row["TraTruoc"].ToString().Length - 5);
                txtNhanPhong.Text = Convert.ToDateTime(row["NgayNhan"]).ToString("dd/MM/yyyy");
                if (((DateTime)(row["NgayTra"])).ToString("yyyy-MM-dd").Equals(DateTime.Now.ToString("yyyy-MM-dd")) == true)
                {
                    txtDonGia.Text = row["DonGia"].ToString();
                    txtTraPhong.Text = Convert.ToDateTime(row["NgayTra"]).ToString("dd/MM/yyyy");
                    txtSoNgayThue.Text = row["SoNgayThue"].ToString();
                }
                else
                {
                    txtTraPhong.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    TimeSpan duration = (DateTime.Now).Subtract(Convert.ToDateTime(row["NgayNhan"]));
                    int time = Convert.ToInt32(duration.ToString("%d"));
                    txtSoNgayThue.Text = time.ToString();
                    if (time != 0)
                    {
                        donGia *= time;
                    }
                    txtDonGia.Text = donGia.ToString().Substring(0, donGia.ToString().Length - 5);
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
            DataTable dt = BUS.GetDataLP_fromIDPhong(txtMaPhong.Text);
            if (dt.Rows.Count > 0)
            {

                txtLoaiPhong.Text = dt.Rows[0]["TenLP"].ToString();
                donGia = Convert.ToDecimal(dt.Rows[0]["GiaLP"]);
            }
        }

        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
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
            MessageBox.Show("Không tìm thấy máy in!!!", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }
        private void  Sua_sttPhong_fromIDPhong()
        {
            Phong_DTO p = new Phong_DTO();
            BUS.GetDataPhong();
            //string sql = "UPDATE Phong SET TrangThai = p.TrangThai WHERE IDPhong = idPhong";
            //return new ExecuteDB().ExecuteData(sql);
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                Sua_sttPhong_fromIDPhong();
                if (MessageBox.Show("Thanh toán ?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {  
                    MessageBox.Show("Thanh toán thành công!");
                    LoadComBoBox();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void timerP_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss tt");
        }
    } 
}
