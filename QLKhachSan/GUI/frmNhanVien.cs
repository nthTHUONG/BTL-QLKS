﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        string cnStr = @"server = (local); database = QLKhachSan; integrated security = true;";
        SqlConnection cnn;
        List<NhanVien_DTO> lst = new List<NhanVien_DTO>();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cnStr);
            try
            {
                Connection();
                LoadData();
                Disconnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Connection()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Disconnection()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Closed)
                {
                    cnn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            string sql = "SELECT * from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, cnn);  // sql + cnStr de ket noi du lieu
            SqlDataReader dr = cmd.ExecuteReader();
            lst.Clear();
            while (dr.Read() == true)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IDNhanVien = dr["IDNhanVien"].ToString();
                nv.Ho = dr["Ho"].ToString();
                nv.Ten = dr["Ten"].ToString();
                nv.ChucVu = dr["ChucVu"].ToString();
                nv.GioiTinh = dr["GioiTinh"].ToString();
                nv.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
                nv.SDT = dr["SDT"].ToString();
                nv.DiaChi = dr["DiaChi"].ToString();
                lst.Add(nv);
            }
            cmd.Dispose();  // giai phong bien cmd
            dr.Close();
            if (dataGV.DataSource != null)
            {
                dataGV.DataSource = null;
                dataGV.DataSource = lst;
            }
            dataGV.DataSource = lst;
        }

        private void Init()
        {
            txtIDNhanVien.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtChucVu.Text = "";
            txtGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connection();
            try
            {
                string sql = "INSERT INTO NhanVien VALUES('" + txtIDNhanVien.Text + "', N'" + txtHo.Text + "', N'" + txtTen.Text
                    + "', N'" + txtChucVu.Text + "', N'" + txtGioiTinh.Text + "', '" + txtNgaySinh.Text + "', N'" + txtSDT.Text + "', '" + txtDiaChi.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã thêm thành công!");
                Init();
            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm khôg thành công! Trùng mã nhân viên.");
            }
            finally
            {
                Disconnection();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connection();
            try
            {
                string sql = "UPDATE NhanVien SET Ho =  N'" + txtHo.Text + "', Ten = N'" + txtTen.Text
                    + "', ChucVu = N'" + txtChucVu.Text + "', GioiTinh = N'" + txtGioiTinh.Text + "', NgaySinh = N'" + txtNgaySinh.Text
                    + "', SDT = N'" + txtSDT.Text + "', DiaChi = N'" + txtDiaChi.Text + "'WHERE IDNhanVien = N'" + txtIDNhanVien.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã cập nhật thành công!");
                Init();
            }
            catch (SqlException)
            {
                MessageBox.Show("Sửa không thành công! Trùng mã nhân viên.");
            }
            finally
            {
                Disconnection();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connection();
            try
            {
                string sql = "DELETE FROM NhanVien WHERE IDNhanVien = N'" + txtIDNhanVien.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã xóa thành công!");
                Disconnection();
                Init();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnection();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dataGV.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dataGV.RowCount; i++)
                {
                    dataGV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGV.RowCount; i++)
                {
                    if (dataGV.Rows[i].Cells["IDNhanVien"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || (dataGV.Rows[i].Cells["Ho"].Value.ToString() + " " + dataGV.Rows[i].Cells["Ten"].Value.ToString()).ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dataGV.Rows[i].Cells["SDT"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
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
                txtIDNhanVien.Text = row.Cells[0].Value.ToString();
                txtHo.Text = row.Cells[1].Value.ToString();
                txtTen.Text = row.Cells[2].Value.ToString();
                txtChucVu.Text = row.Cells[3].Value.ToString();
                txtGioiTinh.Text = row.Cells[4].Value.ToString();
                txtNgaySinh.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
