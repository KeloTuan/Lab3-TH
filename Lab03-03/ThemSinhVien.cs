using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class ThemSinhVien : Form
    {
        private readonly DataGridView dataGridViewOnForm1;
        public ThemSinhVien(DataGridView dataGridViewOnForm1)
        {
            InitializeComponent();
            this.dataGridViewOnForm1 = dataGridViewOnForm1;
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedIndex = 0;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSoSinhVien.Text;

            // Kiểm tra xem mã sinh viên đã tồn tại trong DataGridView hay chưa
            foreach (DataGridViewRow existingRow in dataGridViewOnForm1.Rows)
            {
                if (existingRow.Cells["dgvMaSoSV"].Value != null &&
                    existingRow.Cells["dgvMaSoSV"].Value.ToString() == maSinhVien)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.");
                    return; // Không thêm dữ liệu nếu mã sinh viên trùng.
                }
            }
            if (string.IsNullOrWhiteSpace(txtTenSinhVien.Text) ||
                string.IsNullOrWhiteSpace(txtMaSoSinhVien.Text) ||
                string.IsNullOrWhiteSpace(txtDiemTB.Text) ||
                cmbKhoa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!double.TryParse(txtDiemTB.Text, out double dgvDiemTB) || dgvDiemTB < 0 || dgvDiemTB > 10)
            {
                MessageBox.Show("Điểm trung bình phải nằm trong khoảng từ 0 đến 10.");
                return;
            }

            string tenSinhVien = txtTenSinhVien.Text;
            string khoa = cmbKhoa.SelectedItem.ToString();

            // Thay vì sử dụng nextSoThuTu, bạn có thể lấy số thứ tự từ số dòng cuối cùng và tăng nó lên 1.
            int soThuTu = dataGridViewOnForm1.Rows.Count + 1;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = soThuTu });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = maSinhVien });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = tenSinhVien });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = khoa });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = dgvDiemTB });

            // Thêm row vào DataGridView trên Form1
            dataGridViewOnForm1.Rows.Add(row);

            MessageBox.Show("Thêm sinh viên thành công!");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
