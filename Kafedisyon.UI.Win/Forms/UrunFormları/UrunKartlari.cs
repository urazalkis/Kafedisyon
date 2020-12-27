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
using Kafedisyon.UI.Win.Forms.BaseForms;
using Kafedisyon.Bll.General;

namespace Kafedisyon.UI.Win.Forms.UrunFormları
{
    public partial class UrunKartlari : BaseKartlarForm
    {
        public UrunKartlari()
        {
            InitializeComponent();
            UrunBll urunBll = new UrunBll();
            grid.DataSource=urunBll.List(null);
        }

        private void UrunKartlari_Load(object sender, EventArgs e)
        {

        }
    }
}