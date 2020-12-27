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
using Kafedisyon.UI.Win.Forms.UrunFormları;

namespace Kafedisyon.UI.Win.Forms.GenelFormlar
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnUrunKartlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            UrunKartlari urunKartlari = new UrunKartlari();
            urunKartlari.MdiParent = ActiveForm;
            urunKartlari.Show();
        }
    }
}