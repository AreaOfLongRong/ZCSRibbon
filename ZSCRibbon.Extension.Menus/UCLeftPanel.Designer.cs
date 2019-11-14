namespace ZSCRibbon.Extension.Menus
{
    partial class UCLeftPanel
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
            this.barMain = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.advTreeMain = new DevComponents.AdvTree.AdvTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.node2 = new DevComponents.AdvTree.Node();
            this.node3 = new DevComponents.AdvTree.Node();
            this.node4 = new DevComponents.AdvTree.Node();
            this.node5 = new DevComponents.AdvTree.Node();
            this.node6 = new DevComponents.AdvTree.Node();
            this.panelExMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExMain
            // 
            this.panelExMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelExMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelExMain.Controls.Add(this.advTreeMain);
            this.panelExMain.Controls.Add(this.barMain);
            this.panelExMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelExMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExMain.Location = new System.Drawing.Point(0, 0);
            this.panelExMain.Name = "panelExMain";
            this.panelExMain.Size = new System.Drawing.Size(258, 464);
            this.panelExMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelExMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelExMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExMain.Style.GradientAngle = 90;
            this.panelExMain.TabIndex = 0;
            this.panelExMain.Text = "panelEx1";
            // 
            // barMain
            // 
            this.barMain.AntiAlias = true;
            this.barMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.barMain.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.barMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.barMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(258, 27);
            this.barMain.Stretch = true;
            this.barMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barMain.TabIndex = 0;
            this.barMain.TabStop = false;
            this.barMain.Text = "bar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // advTreeMain
            // 
            this.advTreeMain.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTreeMain.AllowDrop = true;
            this.advTreeMain.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTreeMain.BackgroundStyle.Class = "TreeBorderKey";
            this.advTreeMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTreeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTreeMain.Location = new System.Drawing.Point(0, 27);
            this.advTreeMain.Name = "advTreeMain";
            this.advTreeMain.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.advTreeMain.NodesConnector = this.nodeConnector1;
            this.advTreeMain.NodeStyle = this.elementStyle1;
            this.advTreeMain.PathSeparator = ";";
            this.advTreeMain.Size = new System.Drawing.Size(258, 437);
            this.advTreeMain.Styles.Add(this.elementStyle1);
            this.advTreeMain.TabIndex = 1;
            this.advTreeMain.Text = "advTree1";
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node2,
            this.node5,
            this.node6});
            this.node1.Text = "node1";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // node2
            // 
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node3,
            this.node4});
            this.node2.Text = "node2";
            // 
            // node3
            // 
            this.node3.Expanded = true;
            this.node3.Name = "node3";
            this.node3.Text = "node3";
            // 
            // node4
            // 
            this.node4.Expanded = true;
            this.node4.Name = "node4";
            this.node4.Text = "node4";
            // 
            // node5
            // 
            this.node5.Expanded = true;
            this.node5.Name = "node5";
            this.node5.Text = "node5";
            // 
            // node6
            // 
            this.node6.Expanded = true;
            this.node6.Name = "node6";
            this.node6.Text = "node6";
            // 
            // UCLeftPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelExMain);
            this.Name = "UCLeftPanel";
            this.Size = new System.Drawing.Size(258, 464);
            this.panelExMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTreeMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelExMain;
        private DevComponents.DotNetBar.Bar barMain;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.AdvTree.AdvTree advTreeMain;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.Node node4;
        private DevComponents.AdvTree.Node node5;
        private DevComponents.AdvTree.Node node6;
    }
}
