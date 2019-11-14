namespace ZSCRibbon.Extension.Menus
{
    partial class UCOutputPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOutputPanel));
            this.barMain = new DevComponents.DotNetBar.Bar();
            this.buttonItemClear = new DevComponents.DotNetBar.ButtonItem();
            this.textBoxItemSearch = new DevComponents.DotNetBar.TextBoxItem();
            this.buttonItemSearch = new DevComponents.DotNetBar.ButtonItem();
            this.switchButtonItemSearchDirection = new DevComponents.DotNetBar.SwitchButtonItem();
            this.panelExMain = new DevComponents.DotNetBar.PanelEx();
            this.richTextBoxExMain = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).BeginInit();
            this.panelExMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // barMain
            // 
            this.barMain.AntiAlias = true;
            this.barMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.barMain.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.barMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.barMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemClear,
            this.textBoxItemSearch,
            this.buttonItemSearch,
            this.switchButtonItemSearchDirection});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(608, 33);
            this.barMain.Stretch = true;
            this.barMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barMain.TabIndex = 0;
            this.barMain.TabStop = false;
            this.barMain.Text = "bar1";
            // 
            // buttonItemClear
            // 
            this.buttonItemClear.Image = global::ZSCRibbon.Extension.Menus.Properties.Resources._20150105040817551_easyicon_net_16;
            this.buttonItemClear.Name = "buttonItemClear";
            this.buttonItemClear.Text = "全部清除";
            this.buttonItemClear.Tooltip = "全部清除";
            this.buttonItemClear.Click += new System.EventHandler(this.buttonItemClear_Click);
            // 
            // textBoxItemSearch
            // 
            this.textBoxItemSearch.BeginGroup = true;
            this.textBoxItemSearch.Name = "textBoxItemSearch";
            this.textBoxItemSearch.TextBoxWidth = 128;
            this.textBoxItemSearch.Tooltip = "搜索内容";
            this.textBoxItemSearch.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.textBoxItemSearch.TextChanged += new System.EventHandler(this.textBoxItemSearch_TextChanged);
            // 
            // buttonItemSearch
            // 
            this.buttonItemSearch.Enabled = false;
            this.buttonItemSearch.Image = global::ZSCRibbon.Extension.Menus.Properties.Resources._526296;
            this.buttonItemSearch.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.buttonItemSearch.Name = "buttonItemSearch";
            this.buttonItemSearch.Text = "检索";
            this.buttonItemSearch.Tooltip = "检索";
            this.buttonItemSearch.Click += new System.EventHandler(this.buttonItemSearch_Click);
            // 
            // switchButtonItemSearchDirection
            // 
            this.switchButtonItemSearchDirection.ButtonWidth = 80;
            this.switchButtonItemSearchDirection.Enabled = false;
            this.switchButtonItemSearchDirection.Name = "switchButtonItemSearchDirection";
            this.switchButtonItemSearchDirection.OffText = "向下";
            this.switchButtonItemSearchDirection.OnText = "向上";
            this.switchButtonItemSearchDirection.SwitchWidth = 40;
            this.switchButtonItemSearchDirection.Tooltip = "设置搜索方向";
            // 
            // panelExMain
            // 
            this.panelExMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelExMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelExMain.Controls.Add(this.richTextBoxExMain);
            this.panelExMain.Controls.Add(this.barMain);
            this.panelExMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelExMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExMain.Location = new System.Drawing.Point(0, 0);
            this.panelExMain.Name = "panelExMain";
            this.panelExMain.Size = new System.Drawing.Size(608, 325);
            this.panelExMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelExMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelExMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExMain.Style.GradientAngle = 90;
            this.panelExMain.TabIndex = 1;
            this.panelExMain.Text = "panelEx1";
            // 
            // richTextBoxExMain
            // 
            // 
            // 
            // 
            this.richTextBoxExMain.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxExMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxExMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxExMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxExMain.Location = new System.Drawing.Point(0, 33);
            this.richTextBoxExMain.MaxLength = 65535;
            this.richTextBoxExMain.Name = "richTextBoxExMain";
            this.richTextBoxExMain.ReadOnly = true;
            this.richTextBoxExMain.Rtf = resources.GetString("richTextBoxExMain.Rtf");
            this.richTextBoxExMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxExMain.Size = new System.Drawing.Size(608, 292);
            this.richTextBoxExMain.TabIndex = 1;
            this.richTextBoxExMain.Text = resources.GetString("richTextBoxExMain.Text");
            this.richTextBoxExMain.TextChanged += new System.EventHandler(this.richTextBoxExMain_TextChanged);
            // 
            // UCOutputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelExMain);
            this.Name = "UCOutputPanel";
            this.Size = new System.Drawing.Size(608, 325);
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).EndInit();
            this.panelExMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar barMain;
        private DevComponents.DotNetBar.PanelEx panelExMain;
        private DevComponents.DotNetBar.ButtonItem buttonItemClear;
        private DevComponents.DotNetBar.TextBoxItem textBoxItemSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSearch;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxExMain;
        private DevComponents.DotNetBar.SwitchButtonItem switchButtonItemSearchDirection;
    }
}
