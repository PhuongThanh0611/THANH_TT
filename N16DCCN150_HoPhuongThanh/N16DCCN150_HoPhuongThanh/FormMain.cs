using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using N16DCCN150_HoPhuongThanh.Form_GT;

namespace N16DCCN150_HoPhuongThanh
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLenhDat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmGiaoDich));
            if (frm != null) frm.Activate();
            else
            {
                FrmGiaoDich f = new FrmGiaoDich();
                f.MdiParent = this;
                f.Show();
            }
        }

      

        private void btnNhapLenh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
    }
}