using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmXuatKho : Form
    {
        private string connectionString = "Data Source=THUYLINH\\THUYLINH;Initial Catalog=CTPhanPhoi;Integrated Security=True;Encrypt=False";
        private DataTable dataTable;

        public frmXuatKho()
        {
            InitializeComponent();
        }

        // Sự kiện khi form được tải
        private void frmXuatKho_Load(object sender, EventArgs e)
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
                    string query = "SELECT * FROM XuatKho";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DSPhieuXK.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối hoặc truy vấn dữ liệu: {ex.Message}");
            }
        }

        private void InitializeComboBox()
        {
            cBPXK.Items.Clear();
            cBPXK.Items.Add("SoPXK");
            cBPXK.Items.Add("NgayXuat");
            cBPXK.Items.Add("LyDo");
            cBPXK.Items.Add("TongTien");
            cBPXK.Items.Add("MaKho");
        }

        // Sự kiện khi nhấn nút tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchField = cBPXK.SelectedItem?.ToString();
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
                    string query = $"SELECT * FROM XuatKho WHERE {searchField} LIKE @SearchValue";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SearchValue", $"%{searchValue}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable searchTable = new DataTable();
                    adapter.Fill(searchTable);
                    DSPhieuXK.DataSource = searchTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        // Sự kiện khi nhấn nút Thêm phiếu xuất kho
        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            frmThemPXK frm = new frmThemPXK();
            this.Hide();
            frm.Show();
        }

        // Sự kiện khi nhấn nút Xóa tìm kiếm
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            LoadData();
            cBPXK.SelectedIndex = -1;
            txtTimKiem.Clear();
        }

        // Phương thức để thêm dữ liệu vào DataGridView
        public void AddExportReceipt(string soPXK, DateTime ngayXuat, string lyDo, decimal tongTien, string maKho)
        {
            if (IsSoPXKExists(soPXK)) return;

            DataRow newRow = dataTable.NewRow();
            newRow["SoPXK"] = soPXK;
            newRow["NgayXuat"] = ngayXuat;
            newRow["LyDo"] = lyDo;
            newRow["TongTien"] = tongTien;
            newRow["MaKho"] = maKho;
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

        // Sự kiện khi chọn phiếu xuất kho để chỉnh sửa
        private void btnEditReceipt_Click(object sender, EventArgs e)
        {
            if (DSPhieuXK.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DSPhieuXK.SelectedRows[0];
                string soPXK = selectedRow.Cells["SoPXK"].Value.ToString();
                DateTime ngayXuat = Convert.ToDateTime(selectedRow.Cells["NgayXuat"].Value);
                string lyDo = selectedRow.Cells["LyDo"].Value.ToString();
                decimal tongTien = Convert.ToDecimal(selectedRow.Cells["TongTien"].Value);
                string maKho = selectedRow.Cells["MaKho"].Value.ToString();

                frmEditPXK frmEdit = new frmEditPXK(soPXK, ngayXuat, lyDo, tongTien, maKho);
                this.Hide();
                frmEdit.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất kho để chỉnh sửa.");
            }
        }

        // Cập nhật phiếu xuất kho
        public void UpdatePXK(string soPXK, DateTime ngayXuat, string lyDo, decimal tongTien, string maKho)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdatePXK(soPXK, ngayXuat, lyDo, tongTien, maKho)));
            }
            else
            {
                txtSoPXK.Text = soPXK;
                dtpNgayXuat.Value = ngayXuat;
                txtLyDo.Text = lyDo;
                txtTongTien.Text = tongTien.ToString();
                txtMaKho.Text = maKho;
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            frmXuatKhoChiTiet frm = new frmXuatKhoChiTiet();
            frm.ShowDialog();
        }

        private void btnDeleteReceipt_Click(object sender, EventArgs e)
        {
            if (DSPhieuXK.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DSPhieuXK.SelectedRows[0];
                string soPXK = selectedRow.Cells["SoPXK"].Value.ToString();

                frmDeletePXK frmDelete = new frmDeletePXK(soPXK);
                this.Hide();
                frmDelete.ShowDialog();  //

                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất kho để xóa.");
            }
        }
    }
}
