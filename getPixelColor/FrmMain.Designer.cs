namespace getPixelColor
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.CKB_Top = new System.Windows.Forms.CheckBox();
            this.TMR_Refresh = new System.Windows.Forms.Timer(this.components);
            this.TBN_StyleHtml = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_StyleRGB_B = new System.Windows.Forms.TextBox();
            this.TBX_StyleRGB_G = new System.Windows.Forms.TextBox();
            this.TBX_StyleRGB_R = new System.Windows.Forms.TextBox();
            this.TBX_StyleHtml = new System.Windows.Forms.TextBox();
            this.RBN_StyleRGB = new System.Windows.Forms.RadioButton();
            this.LBL_Version = new System.Windows.Forms.Label();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.CKB_Lock = new System.Windows.Forms.CheckBox();
            this.LBL_XPosition = new System.Windows.Forms.Label();
            this.LBL_YPosition = new System.Windows.Forms.Label();
            this.LBL_x = new System.Windows.Forms.Label();
            this.LBL_y = new System.Windows.Forms.Label();
            this.BTN_SelectColor = new System.Windows.Forms.Button();
            this.CDG_1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CKB_Top
            // 
            this.CKB_Top.AutoSize = true;
            this.CKB_Top.Location = new System.Drawing.Point(77, 12);
            this.CKB_Top.Name = "CKB_Top";
            this.CKB_Top.Size = new System.Drawing.Size(48, 16);
            this.CKB_Top.TabIndex = 0;
            this.CKB_Top.Text = "置顶";
            this.CKB_Top.UseVisualStyleBackColor = true;
            this.CKB_Top.CheckedChanged += new System.EventHandler(this.CKB_Top_CheckedChanged);
            // 
            // TMR_Refresh
            // 
            this.TMR_Refresh.Tick += new System.EventHandler(this.TMR_Refresh_Tick);
            // 
            // TBN_StyleHtml
            // 
            this.TBN_StyleHtml.AutoSize = true;
            this.TBN_StyleHtml.Checked = true;
            this.TBN_StyleHtml.Location = new System.Drawing.Point(3, 4);
            this.TBN_StyleHtml.Name = "TBN_StyleHtml";
            this.TBN_StyleHtml.Size = new System.Drawing.Size(14, 13);
            this.TBN_StyleHtml.TabIndex = 4;
            this.TBN_StyleHtml.TabStop = true;
            this.TBN_StyleHtml.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBX_StyleRGB_B);
            this.panel1.Controls.Add(this.TBX_StyleRGB_G);
            this.panel1.Controls.Add(this.TBX_StyleRGB_R);
            this.panel1.Controls.Add(this.TBX_StyleHtml);
            this.panel1.Controls.Add(this.RBN_StyleRGB);
            this.panel1.Controls.Add(this.TBN_StyleHtml);
            this.panel1.Location = new System.Drawing.Point(74, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 45);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = ")";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = ",";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "rgb(";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "#";
            // 
            // TBX_StyleRGB_B
            // 
            this.TBX_StyleRGB_B.Location = new System.Drawing.Point(125, 24);
            this.TBX_StyleRGB_B.Name = "TBX_StyleRGB_B";
            this.TBX_StyleRGB_B.Size = new System.Drawing.Size(25, 21);
            this.TBX_StyleRGB_B.TabIndex = 5;
            this.TBX_StyleRGB_B.Text = "255";
            // 
            // TBX_StyleRGB_G
            // 
            this.TBX_StyleRGB_G.Location = new System.Drawing.Point(89, 24);
            this.TBX_StyleRGB_G.Name = "TBX_StyleRGB_G";
            this.TBX_StyleRGB_G.Size = new System.Drawing.Size(25, 21);
            this.TBX_StyleRGB_G.TabIndex = 5;
            this.TBX_StyleRGB_G.Text = "255";
            // 
            // TBX_StyleRGB_R
            // 
            this.TBX_StyleRGB_R.Location = new System.Drawing.Point(53, 24);
            this.TBX_StyleRGB_R.Name = "TBX_StyleRGB_R";
            this.TBX_StyleRGB_R.Size = new System.Drawing.Size(25, 21);
            this.TBX_StyleRGB_R.TabIndex = 5;
            this.TBX_StyleRGB_R.Text = "255";
            // 
            // TBX_StyleHtml
            // 
            this.TBX_StyleHtml.Location = new System.Drawing.Point(39, 0);
            this.TBX_StyleHtml.Name = "TBX_StyleHtml";
            this.TBX_StyleHtml.Size = new System.Drawing.Size(111, 21);
            this.TBX_StyleHtml.TabIndex = 5;
            this.TBX_StyleHtml.Text = "000000";
            // 
            // RBN_StyleRGB
            // 
            this.RBN_StyleRGB.AutoSize = true;
            this.RBN_StyleRGB.Location = new System.Drawing.Point(3, 28);
            this.RBN_StyleRGB.Name = "RBN_StyleRGB";
            this.RBN_StyleRGB.Size = new System.Drawing.Size(14, 13);
            this.RBN_StyleRGB.TabIndex = 4;
            this.RBN_StyleRGB.UseVisualStyleBackColor = true;
            // 
            // LBL_Version
            // 
            this.LBL_Version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_Version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_Version.Location = new System.Drawing.Point(0, 97);
            this.LBL_Version.Name = "LBL_Version";
            this.LBL_Version.Size = new System.Drawing.Size(239, 16);
            this.LBL_Version.TabIndex = 6;
            this.LBL_Version.Text = "[by xxx] [Version]";
            this.LBL_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.Location = new System.Drawing.Point(11, 70);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(56, 23);
            this.BTN_Copy.TabIndex = 7;
            this.BTN_Copy.Text = "复制(&c)";
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // CKB_Lock
            // 
            this.CKB_Lock.AutoSize = true;
            this.CKB_Lock.Location = new System.Drawing.Point(142, 12);
            this.CKB_Lock.Name = "CKB_Lock";
            this.CKB_Lock.Size = new System.Drawing.Size(96, 16);
            this.CKB_Lock.TabIndex = 8;
            this.CKB_Lock.Text = "锁色(Ctrl+D)";
            this.CKB_Lock.UseVisualStyleBackColor = true;
            this.CKB_Lock.CheckedChanged += new System.EventHandler(this.CKB_Lock_CheckedChanged);
            // 
            // LBL_XPosition
            // 
            this.LBL_XPosition.AutoSize = true;
            this.LBL_XPosition.Location = new System.Drawing.Point(74, 82);
            this.LBL_XPosition.Name = "LBL_XPosition";
            this.LBL_XPosition.Size = new System.Drawing.Size(41, 12);
            this.LBL_XPosition.TabIndex = 9;
            this.LBL_XPosition.Text = "xPos：";
            // 
            // LBL_YPosition
            // 
            this.LBL_YPosition.AutoSize = true;
            this.LBL_YPosition.Location = new System.Drawing.Point(138, 82);
            this.LBL_YPosition.Name = "LBL_YPosition";
            this.LBL_YPosition.Size = new System.Drawing.Size(41, 12);
            this.LBL_YPosition.TabIndex = 9;
            this.LBL_YPosition.Text = "yPos：";
            // 
            // LBL_x
            // 
            this.LBL_x.AutoSize = true;
            this.LBL_x.Location = new System.Drawing.Point(111, 82);
            this.LBL_x.Name = "LBL_x";
            this.LBL_x.Size = new System.Drawing.Size(11, 12);
            this.LBL_x.TabIndex = 9;
            this.LBL_x.Text = "x";
            // 
            // LBL_y
            // 
            this.LBL_y.AutoSize = true;
            this.LBL_y.Location = new System.Drawing.Point(175, 82);
            this.LBL_y.Name = "LBL_y";
            this.LBL_y.Size = new System.Drawing.Size(11, 12);
            this.LBL_y.TabIndex = 9;
            this.LBL_y.Text = "y";
            // 
            // BTN_SelectColor
            // 
            this.BTN_SelectColor.BackColor = System.Drawing.Color.Black;
            this.BTN_SelectColor.Location = new System.Drawing.Point(11, 12);
            this.BTN_SelectColor.Name = "BTN_SelectColor";
            this.BTN_SelectColor.Size = new System.Drawing.Size(55, 55);
            this.BTN_SelectColor.TabIndex = 10;
            this.BTN_SelectColor.UseVisualStyleBackColor = false;
            this.BTN_SelectColor.BackColorChanged += new System.EventHandler(this.BTN_SelectColor_BackColorChanged);
            this.BTN_SelectColor.Click += new System.EventHandler(this.BTN_SelectColor_Click);
            // 
            // CDG_1
            // 
            this.CDG_1.FullOpen = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 113);
            this.Controls.Add(this.BTN_SelectColor);
            this.Controls.Add(this.LBL_y);
            this.Controls.Add(this.LBL_x);
            this.Controls.Add(this.LBL_YPosition);
            this.Controls.Add(this.LBL_XPosition);
            this.Controls.Add(this.CKB_Lock);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.LBL_Version);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CKB_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 100);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CKB_Top;
        private System.Windows.Forms.Timer TMR_Refresh;
        private System.Windows.Forms.RadioButton TBN_StyleHtml;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RBN_StyleRGB;
        private System.Windows.Forms.Label LBL_Version;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.CheckBox CKB_Lock;
        private System.Windows.Forms.Label LBL_XPosition;
        private System.Windows.Forms.Label LBL_YPosition;
        private System.Windows.Forms.Label LBL_x;
        private System.Windows.Forms.Label LBL_y;
        private System.Windows.Forms.Button BTN_SelectColor;
        private System.Windows.Forms.ColorDialog CDG_1;
        private System.Windows.Forms.TextBox TBX_StyleRGB_R;
        private System.Windows.Forms.TextBox TBX_StyleHtml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_StyleRGB_B;
        private System.Windows.Forms.TextBox TBX_StyleRGB_G;
    }
}

