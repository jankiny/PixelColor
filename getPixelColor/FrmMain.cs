using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getPixelColor
{
    public partial class FrmMain : Form
    {

        int r, g, b;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TMR_Refresh.Enabled = true;
        }

        private void CKB_Top_Click(object sender, EventArgs e)
        {

            this.TopMost = CKB_Top.Checked;
        }

        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            if (TBN_StyleHtml.Checked)
            {
                Clipboard.SetDataObject($"#{this.TBX_StyleHtml.Text}", true);
                return;
            }
            else if (RBN_StyleRGB.Checked)
            {
                Clipboard.SetDataObject(
                    $"rgb({this.TBX_StyleRGB_R.Text},{this.TBX_StyleRGB_G.Text},{this.TBX_StyleRGB_B.Text})", true);
                return;
            }
        }

        private void TMR_Refresh_Tick(object sender, EventArgs e)
        {
            int msX = MousePosition.X;
            int msY = MousePosition.Y;
            this.LBL_x.Text = msX.ToString();
            this.LBL_y.Text = msY.ToString();

            if (ColorHelper.PixelColor(msX, msY, out r, out g, out b) == true
                && this.CKB_Lock.Checked == false)
            {
                this.BTN_SelectColor.BackColor = Color.FromArgb(r, g, b);
            }
        }

        private void BTN_SelectColor_BackColorChanged(object sender, EventArgs e)
        {
            this.TBX_StyleHtml.Text = $@"{r:X2}{g:X2}{b:X2}";
            this.TBX_StyleRGB_R.Text = r.ToString();
            this.TBX_StyleRGB_G.Text = g.ToString();
            this.TBX_StyleRGB_B.Text = b.ToString();
        }

        private void BTN_SelectColor_Click(object sender, EventArgs e)
        {
            this.CKB_Lock.Checked = true;
            this.CDG_1.Color = this.BTN_SelectColor.BackColor;
            if (this.CDG_1.ShowDialog() == DialogResult.OK)
            {
                r = this.CDG_1.Color.R;
                g = this.CDG_1.Color.G;
                b = this.CDG_1.Color.B;
                this.BTN_SelectColor.BackColor = this.CDG_1.Color;
            }
        }
    }
}
