using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using System.Drawing;
using System.ComponentModel;

namespace Kafedisyon.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyToggleSwitch:ToggleSwitch
    {
        public MyToggleSwitch()
        {
            Name = "TglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment =HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;

        }
        public override bool EnterMoveNextControl { get; set; }=true;
    }
}
