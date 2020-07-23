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
    public partial class Frm_Main : Form
    {

        int r, g, b;
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TMR_1.Enabled = true;
        }

        private void CKB_Top_Click(object sender, EventArgs e)
        {

            this.TopMost = CKB_Top.Checked;
        }

        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            if (TBN_StyleHtml.Checked)
            {
                Clipboard.SetDataObject(string.Format("#{0}", this.TBX_StyleHtml.Text), true);
                return;
            }
            else if (RBN_StyleRGB.Checked)
            {
                Clipboard.SetDataObject(string.Format("rgb({0},{1},{2})", 
                    this.TBX_StyleRGB_R.Text, this.TBX_StyleRGB_G.Text, this.TBX_StyleRGB_B.Text), true);
                return;
            }
        }

        private void TMR_1_Tick(object sender, EventArgs e)
        {
            int ms_x = MousePosition.X;
            int ms_y = MousePosition.Y;
            this.lbl_x.Text = ms_x.ToString();
            this.lbl_y.Text = ms_y.ToString();

            if (ColorHelper.PixelColor(ms_x, ms_y, out r, out g, out b) == true
                && this.CKB_Lock.Checked == false)
            {
                this.BTN_SelectColor.BackColor = Color.FromArgb(r, g, b);
            }
        }

        private void BTN_SelectColor_BackColorChanged(object sender, EventArgs e)
        {
            this.TBX_StyleHtml.Text = string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
            this.TBX_StyleRGB_R.Text = r.ToString();
            this.TBX_StyleRGB_G.Text = g.ToString();
            this.TBX_StyleRGB_B.Text = b.ToString();
        }

        private void BTN_SelectColor_Click(object sender, EventArgs e)
        {
            this.CKB_Lock.Checked = true;
            this.CRDG_1.Color = this.BTN_SelectColor.BackColor;
            if (this.CRDG_1.ShowDialog() == DialogResult.OK)
            {
                r = this.CRDG_1.Color.R;
                g = this.CRDG_1.Color.G;
                b = this.CRDG_1.Color.B;
                this.BTN_SelectColor.BackColor = this.CRDG_1.Color;
            }
        }
    }
}
