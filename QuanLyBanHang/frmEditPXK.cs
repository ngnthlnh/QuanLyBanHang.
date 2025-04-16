using System;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmEditPXK : Form
    {
        private readonly string _soPXK;
        private readonly DateTime _ngayXuat;
        private readonly string _lyDo;
        private readonly decimal _tongTien;
        private readonly string _maKho;

        public frmEditPXK(string soPXK, DateTime ngayXuat, string lyDo, decimal tongTien, string maKho)
        {
            InitializeComponent();

            // Assign values to private variables
            _soPXK = soPXK;
            _ngayXuat = ngayXuat;
            _lyDo = lyDo;
            _tongTien = tongTien;
            _maKho = maKho;
        }

        // Event to load form and populate fields with existing data
        private void frmEditPXK_Load(object sender, EventArgs e)
        {
            txtSoPXK.Text = _soPXK;
            txtSoPXK.ReadOnly = true;
            dtpNgayXuat.Value = _ngayXuat;
            txtLyDo.Text = _lyDo;
            txtTongTien.Text = _tongTien.ToString();
            txtMaKho.Text = _maKho;
        }

        // Cancel button click event to close the form and return to the previous form
        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close(); // Close the current form
            OpenPreviousForm(); // Return to frmXuatKho
        }

        // Submit button click event to save the updated data and update frmXuatKho
        private void bnSubmit_Click(object sender, EventArgs e)
        {
            // Optionally, perform saving or other operations here...

            // Hiển thị hộp thông báo thành công và xử lý sự kiện nhấn nút OK
            DialogResult result = MessageBox.Show("Cập nhật phiếu xuất kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Nếu người dùng nhấn OK, quay lại form frmXuatKho
            if (result == DialogResult.OK)
            {
                // Cập nhật dữ liệu cho frmXuatKho
                UpdateXuatKhoForm();

                // Đóng form hiện tại sau khi hoàn thành
                this.Close();
            }
        }

        // Helper method to return to frmXuatKho form
        // Helper method to return to frmXuatKho form
        private void OpenPreviousForm()
        {
            // Kiểm tra xem form frmXuatKho đã tồn tại trong bộ nhớ chưa
            var frmXK = (frmXuatKho)Application.OpenForms["frmXuatKho"];
            if (frmXK == null) // Nếu chưa có form frmXuatKho, thì mở nó
            {
                frmXK = new frmXuatKho();
                frmXK.Show();
            }
        }


        // Helper method to update frmXuatKho with the new data
        private void UpdateXuatKhoForm()
        {
            var frmXK = (frmXuatKho)Application.OpenForms["frmXuatKho"];
            if (frmXK != null)
            {
                frmXK.UpdatePXK(_soPXK, _ngayXuat, _lyDo, _tongTien, _maKho);
            }
        }
    }
}
