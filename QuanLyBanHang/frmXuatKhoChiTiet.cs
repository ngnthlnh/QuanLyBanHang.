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
    public partial class frmXuatKhoChiTiet : Form
    {
        private string connectionString = "Data Source=THUYLINH\\THUYLINH;Initial Catalog=CTPhanPhoi;Integrated Security=True;Encrypt=False";
        private DataTable dataTable;

        public frmXuatKhoChiTiet()
        {
            InitializeComponent();
        }

        private void frmXuatKhoChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
            InitializeComboBox();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM XuatKhoChiTiet";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DSPhieuXKChiTiet.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối hoặc truy vấn dữ liệu: {ex.Message}");
            }
        }

        private void InitializeComboBox()
        {
            cBPXKChiTiet.Items.Clear();
            cBPXKChiTiet.Items.Add("SoPXK");
            cBPXKChiTiet.Items.Add("TheoYC");
            cBPXKChiTiet.Items.Add("ThucXuat");
            cBPXKChiTiet.Items.Add("ThanhTien");
            cBPXKChiTiet.Items.Add("MaHang");
        }


        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void cBPXK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnSearch_Click(object sender, EventArgs e)
        {
            string searchField = cBPXKChiTiet.SelectedItem?.ToString();
            string searchValue = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchField) || string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng chọn trường và nhập giá trị tìm kiếm!");
                return;
            }

            SearchData(searchField, searchValue);
        }

        private void SearchData(string searchField, string searchValue)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = $"SELECT * FROM XuatKhoChiTiet WHERE {searchField} LIKE @SearchValue";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SearchValue", $"%{searchValue}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable searchTable = new DataTable();
                    adapter.Fill(searchTable);
                    DSPhieuXKChiTiet.DataSource = searchTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private void bnClear_Click(object sender, EventArgs e)
        {
            LoadData();
            cBPXKChiTiet.SelectedIndex = -1;
            txtTimKiem.Clear();
        }

        private void bnCreate_Click(object sender, EventArgs e)
        {
            frmThemXKChiTiet frm = new frmThemXKChiTiet();
            this.Hide();
            frm.Show();
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            if (DSPhieuXKChiTiet.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DSPhieuXKChiTiet.SelectedRows[0];
                string soPXK = selectedRow.Cells["SoPXK"].Value.ToString();
                string theoYC = selectedRow.Cells["TheoYC"].Value.ToString();
                decimal thucXuat = Convert.ToDecimal(selectedRow.Cells["ThucXuat"].Value);
                decimal thanhTien = Convert.ToDecimal(selectedRow.Cells["ThanhTien"].Value);
                string maHang = selectedRow.Cells["MaHang"].Value.ToString();

                frmEditXKChiTiet frmEdit = new frmEditXKChiTiet(soPXK, theoYC, thucXuat, thanhTien, maHang);
                this.Hide();
                frmEdit.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết xuất kho để chỉnh sửa.");
            }
        }

        // Cập nhật chi tiết xuất kho
        public void UpdateXKChiTiet(string soPXK, string theoYC, decimal thucXuat, decimal thanhTien, string maHang)
        {
            // Kiểm tra xem form có tồn tại không
            if (this.InvokeRequired)
            {
                // Nếu form chưa sẵn sàng, sử dụng Invoke để gọi phương thức này trong thread UI chính
                this.Invoke(new Action(() => UpdateXKChiTiet(soPXK, theoYC, thucXuat, thanhTien, maHang)));
            }
            else
            {
                // Cập nhật các điều khiển nếu form đang mở
                txtSoPXK.Text = soPXK;
                txtTheoYC.Text = theoYC;
                txtThucXuat.Text = thucXuat.ToString();
                txtThanhTien.Text = thanhTien.ToString();
                txtMaHang.Text = maHang;
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {

        }
        public void AddExportDetail(string soPXK, string theoYC, decimal thucXuat, decimal thanhTien, string maHang)
        {
            if (IsSoPXKExists(soPXK)) return;

            DataRow newRow = dataTable.NewRow();
            newRow["SoPXK"] = soPXK;
            newRow["TheoYC"] = theoYC;
            newRow["ThucXuat"] = thucXuat;
            newRow["ThanhTien"] = thanhTien;
            newRow["MaHang"] = maHang;
            dataTable.Rows.Add(newRow);
        }

        private bool IsSoPXKExists(string soPXK)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["SoPXK"].ToString() == soPXK)
                {
                    MessageBox.Show("SoPXK đã tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
    }
}
