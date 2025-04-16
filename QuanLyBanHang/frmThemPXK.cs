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

namespace QuanLyBanHang
{
    public partial class frmThemPXK : Form
    {
        private string connectionString;

        public frmThemPXK()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSoPXK_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bnSubmit_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox và DateTimePicker
            string soPXK = txtSoPXK.Text;
            DateTime ngayXuat = dateTimePicker1.Value;
            string lyDo = txtLyDo.Text;
            decimal tongTien;
            decimal.TryParse(txtTongTien.Text, out tongTien); // Đảm bảo giá trị là số
            string maKho = txtMaKho.Text;

            // Kiểm tra xem các trường dữ liệu có đầy đủ không
            if (string.IsNullOrEmpty(soPXK) || string.IsNullOrEmpty(lyDo) || string.IsNullOrEmpty(maKho) || tongTien <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert vào cơ sở dữ liệu
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO XuatKho (SoPXK, NgayXuat, LyDo, TongTien, MaKho) VALUES (@SoPXK, @NgayXuat, @LyDo, @TongTien, @MaKho)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SoPXK", soPXK);
                    cmd.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                    cmd.Parameters.AddWithValue("@LyDo", lyDo);
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);
                    cmd.Parameters.AddWithValue("@MaKho", maKho);
                    cmd.ExecuteNonQuery();  // Thực thi truy vấn
                }

                // Thêm phiếu xuất kho vào DataGridView trong frmXuatKho
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmXuatKho)
                    {
                        frmXuatKho xuatKhoForm = (frmXuatKho)frm;

                        xuatKhoForm.AddExportReceipt(soPXK, ngayXuat, lyDo, tongTien, maKho);
                        break;
                    }
                }

                // Thông báo thành công
                MessageBox.Show("Phiếu xuất kho đã được thêm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form hiện tại (frmThemPXK)
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            frmXuatKho xuatKhoForm = new frmXuatKho();
            this.Close();

            // Hiển thị form frmXuatKho
            xuatKhoForm.Show();
        }
    }
}
