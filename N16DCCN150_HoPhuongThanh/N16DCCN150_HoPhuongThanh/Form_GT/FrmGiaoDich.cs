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

namespace N16DCCN150_HoPhuongThanh.Form_GT
{
    public partial class FrmGiaoDich : Form
    {
        public FrmGiaoDich()
        {
            InitializeComponent();
        }

        private void FrmGiaoDich_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'n16DCCN150_HoPhuongThanhDataSet.LENHDAT' table. You can move, or remove it, as needed.
            this.lENHDATTableAdapter.Fill(this.n16DCCN150_HoPhuongThanhDataSet.LENHDAT);
            DateTime ngay = DateTime.Now;
            lbNgay.Text = ngay.ToString("dd/MM/yyyy");
            cbbLoaiLenh.SelectedIndex = 0;
            rbtMua.Checked = true;
        }

        private void btnGD_Click(object sender, EventArgs e)
        {
            String ma, loailenh, loaiGD = "";
            int sl;
            float gia;
            ma = txtMA.Text;
            loailenh = cbbLoaiLenh.SelectedIndex.ToString();
            sl = int.Parse(txtSoLuong.Text.ToString());
            gia = float.Parse(txtGia.Text.ToString());
            if (ma.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã cố phiếu!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loailenh.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại lệnh!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sl <= 0 || txtSoLuong.Text.ToString().Length == 0)
            {
                MessageBox.Show("Số lượng cần lớn hơn 0!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gia <= 0 || txtGia.Text.ToString().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // xử lí radioButton
            if (!(rbtBan.Checked) && !(rbtMua.Checked))
            {
                MessageBox.Show("Bạn chưa chọn loại giao dịch là mua hay bán!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (rbtBan.Checked)
            {
                loaiGD = "B";
            }
            else if (rbtMua.Checked)
            {
                loaiGD = "M";
            }
            Program.KetNoi();
            string strLenh1 = "EXEC SP_KHOPLENH_LO  N'" + ma + "' ,N'" + loaiGD + "'," + sl + ", " + gia;
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            if (Program.myReader == null)
            {
                Reset();
                return;
            }
            Program.myReader.Read();

            //lấy trang thái lệnh cho người dùng biết
            int kq = (Program.myReader.GetInt32(0));
            if (kq == sl)
            {
                Reset();
                MessageBox.Show("Trạng thái bạn đã giao dịch là khớp hết!!" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (kq < sl && kq !=0)
            {
                Reset();
                int choKhop = sl - kq;
                MessageBox.Show("Trạng thái bạn đã giao dịch là khớp 1 phần!!\n Còn lại chờ khớp là "+choKhop, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (kq ==0)
            {
                Reset();
                MessageBox.Show("Trạng thái bạn đã giao dịch là chờ khớp !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            Program.myReader.Close();
        }
       
        private void txtMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }

       private void Reset()
        {
            txtMA.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
        }

        private void lENHDATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lENHDATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.n16DCCN150_HoPhuongThanhDataSet);

        }

 }
}
