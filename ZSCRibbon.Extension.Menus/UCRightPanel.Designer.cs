namespace ZSCRibbon.Extension.Menus
{
    partial class UCRightPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelExMain = new DevComponents.DotNetBar.PanelEx();
            this.advPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.panelExMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExMain
            // 
            this.panelExMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelExMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelExMain.Controls.Add(this.advPropertyGrid1);
            this.panelExMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelExMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExMain.Location = new System.Drawing.Point(0, 0);
            this.panelExMain.Name = "panelExMain";
            this.panelExMain.Size = new System.Drawing.Size(389, 407);
            this.panelExMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelExMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelExMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExMain.Style.GradientAngle = 90;
            this.panelExMain.TabIndex = 0;
            this.panelExMain.Text = "panelEx1";
            // 
            // advPropertyGrid1
            // 
            this.advPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.advPropertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.advPropertyGrid1.Name = "advPropertyGrid1";
            this.advPropertyGrid1.Size = new System.Drawing.Size(389, 407);
            this.advPropertyGrid1.TabIndex = 0;
            this.advPropertyGrid1.Text = "advPropertyGrid1";
            // 
            // UCRightPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelExMain);
            this.Name = "UCRightPanel";
            this.Size = new System.Drawing.Size(389, 407);
            this.panelExMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelExMain;
        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGrid1;
    }
}
