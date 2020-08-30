using System;
using System.Drawing;
using System.Windows.Forms;
using getPixelColor.Utils;

namespace getPixelColor
{
    public partial class FrmMain : Form
    {
        private Color _color;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CKB_Top.Checked = true;
            LBL_Version.Text = $@"{Global.By}  {Global.Version}";
            TMR_Refresh.Enabled = true;
        }

        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            if (TBN_StyleHtml.Checked)
            {
                Clipboard.SetDataObject($"#{TBX_StyleHtml.Text}", true);
                return;
            }
            else if (RBN_StyleRGB.Checked)
            {
                Clipboard.SetDataObject(
                    $"rgb({TBX_StyleRGB_R.Text},{TBX_StyleRGB_G.Text},{TBX_StyleRGB_B.Text})", true);
                return;
            }
        }

        private void TMR_Refresh_Tick(object sender, EventArgs e)
        {
            Point ms = MousePosition;
            LBL_x.Text = ms.X.ToString();
            LBL_y.Text = ms.Y.ToString();

            if (ColorHelper.PixelColor(ms, out _color))
            {
                BTN_SelectColor.BackColor = _color;
            }
        }

        private void BTN_SelectColor_BackColorChanged(object sender, EventArgs e)
        {
            TBX_StyleHtml.Text = $@"{_color.R:X2}{_color.G:X2}{_color.B:X2}";
            TBX_StyleRGB_R.Text = _color.R.ToString();
            TBX_StyleRGB_G.Text = _color.G.ToString();
            TBX_StyleRGB_B.Text = _color.B.ToString();
        }

        private void BTN_SelectColor_Click(object sender, EventArgs e)
        {
            CKB_Lock.Checked = true;
            CDG_1.Color = BTN_SelectColor.BackColor;
            if (CDG_1.ShowDialog() == DialogResult.OK)
            {
                _color = CDG_1.Color;
                BTN_SelectColor.BackColor = CDG_1.Color;
            }
        }

        private void CKB_Lock_CheckedChanged(object sender, EventArgs e)
        {
            //TMR_Refresh.Enabled = !(sender as CheckBox).Checked;
            TMR_Refresh.Enabled = !CKB_Lock.Checked;
        }

        private void CKB_Top_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = CKB_Top.Checked;
        }
    }
}
