using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kafedisyon.UI.Win.Forms.BaseForms
{
    public partial class BaseKartForm : DevExpress.XtraEditors.XtraForm
    {
        public BaseKartForm()
        {
            InitializeComponent();
        }

        private void BtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnYeni.Enabled = false;
            BtnKaydet.Enabled = true;
            BtnCikis.Enabled = true;

        }

        private void BtnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            BtnYeni.Enabled = true;
            BtnKaydet.Enabled = false;
            BtnCikis.Enabled = false;
        }

        private void BtnIptal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnYeni.Enabled = true;
            BtnKaydet.Enabled = false;
            BtnCikis.Enabled = false;
        }

        private void BaseKartForm_Load(object sender, EventArgs e)
        {

        }
    }
}