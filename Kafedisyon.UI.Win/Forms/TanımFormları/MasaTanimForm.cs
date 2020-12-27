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

namespace Kafedisyon.UI.Win.Forms
{
    public partial class MasaTanimForm : BaseKartForm
    {
        public MasaTanimForm()
        {
            InitializeComponent();
        }

        private void MasaTanimForm_Load(object sender, EventArgs e)
        {
            groupControl1.Enabled = true;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBolumEkle_Click(object sender, EventArgs e)
        {
            BolumTanimForm bolumtanimform = new BolumTanimForm();
            bolumtanimform.ShowDialog();
        }
    }
}