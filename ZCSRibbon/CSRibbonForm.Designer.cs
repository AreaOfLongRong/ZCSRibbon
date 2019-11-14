namespace ZCSRibbon
{
    partial class CSRibbonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSRibbonForm));
            this.ribbonControlMain = new DevComponents.DotNetBar.RibbonControl();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManagerMain = new DevComponents.DotNetBar.StyleManager(this.components);
            this.barStatus = new DevComponents.DotNetBar.Bar();
            this.dotNetBarManagerMain = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSiteBottom = new DevComponents.DotNetBar.DockSite();
            this.barDockBottom = new DevComponents.DotNetBar.Bar();
            this.dockSiteFill = new DevComponents.DotNetBar.DockSite();
            this.barDockCenter = new DevComponents.DotNetBar.Bar();
            this.dockSiteLeft = new DevComponents.DotNetBar.DockSite();
            this.barDockLeft = new DevComponents.DotNetBar.Bar();
            this.dockSiteRight = new DevComponents.DotNetBar.DockSite();
            this.barDockRight = new DevComponents.DotNetBar.Bar();
            this.dockSiteTBBottom = new DevComponents.DotNetBar.DockSite();
            this.dockSiteTBLeft = new DevComponents.DotNetBar.DockSite();
            this.dockSiteTBRight = new DevComponents.DotNetBar.DockSite();
            this.dockSiteTBTop = new DevComponents.DotNetBar.DockSite();
            this.dockSiteTop = new DevComponents.DotNetBar.DockSite();
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).BeginInit();
            this.dockSiteBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDockBottom)).BeginInit();
            this.dockSiteFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDockCenter)).BeginInit();
            this.dockSiteLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDockLeft)).BeginInit();
            this.dockSiteRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDockRight)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonControlMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControlMain.CaptionVisible = true;
            this.ribbonControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControlMain.ForeColor = System.Drawing.Color.Black;
            this.ribbonControlMain.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControlMain.Location = new System.Drawing.Point(5, 1);
            this.ribbonControlMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.ribbonControlMain.Size = new System.Drawing.Size(1330, 308);
            this.ribbonControlMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControlMain.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControlMain.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControlMain.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControlMain.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControlMain.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControlMain.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControlMain.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControlMain.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControlMain.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControlMain.SystemText.QatDialogOkButton = "OK";
            this.ribbonControlMain.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControlMain.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControlMain.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControlMain.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControlMain.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControlMain.TabGroupHeight = 14;
            this.ribbonControlMain.TabIndex = 0;
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManagerMain
            // 
            this.styleManagerMain.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManagerMain.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // barStatus
            // 
            this.barStatus.AntiAlias = true;
            this.barStatus.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.barStatus.CanDockBottom = false;
            this.barStatus.CanDockLeft = false;
            this.barStatus.CanDockRight = false;
            this.barStatus.CanDockTab = false;
            this.barStatus.CanDockTop = false;
            this.barStatus.CanMove = false;
            this.barStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.barStatus.Location = new System.Drawing.Point(5, 632);
            this.barStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(1330, 26);
            this.barStatus.Stretch = true;
            this.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barStatus.TabIndex = 1;
            this.barStatus.TabStop = false;
            this.barStatus.Text = "bar1";
            // 
            // dotNetBarManagerMain
            // 
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManagerMain.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManagerMain.BottomDockSite = this.dockSiteBottom;
            this.dotNetBarManagerMain.FillDockSite = this.dockSiteFill;
            this.dotNetBarManagerMain.LeftDockSite = this.dockSiteLeft;
            this.dotNetBarManagerMain.ParentForm = this;
            this.dotNetBarManagerMain.RightDockSite = this.dockSiteRight;
            this.dotNetBarManagerMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dotNetBarManagerMain.ToolbarBottomDockSite = this.dockSiteTBBottom;
            this.dotNetBarManagerMain.ToolbarLeftDockSite = this.dockSiteTBLeft;
            this.dotNetBarManagerMain.ToolbarRightDockSite = this.dockSiteTBRight;
            this.dotNetBarManagerMain.ToolbarTopDockSite = this.dockSiteTBTop;
            this.dotNetBarManagerMain.TopDockSite = this.dockSiteTop;
            // 
            // dockSiteBottom
            // 
            this.dockSiteBottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteBottom.Controls.Add(this.barDockBottom);
            this.dockSiteBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSiteBottom.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.barDockBottom, 1330, 193)))}, DevComponents.DotNetBar.eOrientation.Vertical);
            this.dockSiteBottom.Location = new System.Drawing.Point(5, 436);
            this.dockSiteBottom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteBottom.Name = "dockSiteBottom";
            this.dockSiteBottom.Size = new System.Drawing.Size(1330, 196);
            this.dockSiteBottom.TabIndex = 5;
            this.dockSiteBottom.TabStop = false;
            // 
            // barDockBottom
            // 
            this.barDockBottom.AccessibleDescription = "DotNetBar Bar (barDockBottom)";
            this.barDockBottom.AccessibleName = "DotNetBar Bar";
            this.barDockBottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.barDockBottom.AutoSyncBarCaption = true;
            this.barDockBottom.CloseSingleTab = true;
            this.barDockBottom.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barDockBottom.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.barDockBottom.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.barDockBottom.Location = new System.Drawing.Point(0, 3);
            this.barDockBottom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barDockBottom.Name = "barDockBottom";
            this.barDockBottom.Size = new System.Drawing.Size(1330, 193);
            this.barDockBottom.Stretch = true;
            this.barDockBottom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barDockBottom.TabIndex = 0;
            this.barDockBottom.TabStop = false;
            this.barDockBottom.Text = "barDockBottom";
            this.barDockBottom.Visible = false;
            // 
            // dockSiteFill
            // 
            this.dockSiteFill.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteFill.Controls.Add(this.barDockCenter);
            this.dockSiteFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockSiteFill.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.barDockCenter, 560, 127)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSiteFill.Location = new System.Drawing.Point(463, 309);
            this.dockSiteFill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteFill.Name = "dockSiteFill";
            this.dockSiteFill.Size = new System.Drawing.Size(560, 127);
            this.dockSiteFill.TabIndex = 10;
            this.dockSiteFill.TabStop = false;
            // 
            // barDockCenter
            // 
            this.barDockCenter.AccessibleDescription = "DotNetBar Bar (barDockCenter)";
            this.barDockCenter.AccessibleName = "DotNetBar Bar";
            this.barDockCenter.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.barDockCenter.AlwaysDisplayDockTab = true;
            this.barDockCenter.CanDockBottom = false;
            this.barDockCenter.CanDockDocument = true;
            this.barDockCenter.CanDockLeft = false;
            this.barDockCenter.CanDockRight = false;
            this.barDockCenter.CanDockTop = false;
            this.barDockCenter.CanHide = true;
            this.barDockCenter.CanUndock = false;
            this.barDockCenter.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.barDockCenter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barDockCenter.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.barDockCenter.Location = new System.Drawing.Point(0, 0);
            this.barDockCenter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barDockCenter.Name = "barDockCenter";
            this.barDockCenter.Stretch = true;
            this.barDockCenter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barDockCenter.TabIndex = 0;
            this.barDockCenter.TabNavigation = true;
            this.barDockCenter.TabStop = false;
            // 
            // dockSiteLeft
            // 
            this.dockSiteLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteLeft.Controls.Add(this.barDockLeft);
            this.dockSiteLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSiteLeft.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.barDockLeft, 455, 127)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSiteLeft.Location = new System.Drawing.Point(5, 309);
            this.dockSiteLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteLeft.Name = "dockSiteLeft";
            this.dockSiteLeft.Size = new System.Drawing.Size(458, 127);
            this.dockSiteLeft.TabIndex = 2;
            this.dockSiteLeft.TabStop = false;
            // 
            // barDockLeft
            // 
            this.barDockLeft.AccessibleDescription = "DotNetBar Bar (barDockLeft)";
            this.barDockLeft.AccessibleName = "DotNetBar Bar";
            this.barDockLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.barDockLeft.AutoSyncBarCaption = true;
            this.barDockLeft.CloseSingleTab = true;
            this.barDockLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barDockLeft.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.barDockLeft.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.barDockLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barDockLeft.Name = "barDockLeft";
            this.barDockLeft.Size = new System.Drawing.Size(455, 127);
            this.barDockLeft.Stretch = true;
            this.barDockLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barDockLeft.TabIndex = 0;
            this.barDockLeft.TabStop = false;
            this.barDockLeft.Text = "barDockLeft";
            this.barDockLeft.Visible = false;
            // 
            // dockSiteRight
            // 
            this.dockSiteRight.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteRight.Controls.Add(this.barDockRight);
            this.dockSiteRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSiteRight.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.barDockRight, 309, 127)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSiteRight.Location = new System.Drawing.Point(1023, 309);
            this.dockSiteRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteRight.Name = "dockSiteRight";
            this.dockSiteRight.Size = new System.Drawing.Size(312, 127);
            this.dockSiteRight.TabIndex = 3;
            this.dockSiteRight.TabStop = false;
            // 
            // barDockRight
            // 
            this.barDockRight.AccessibleDescription = "DotNetBar Bar (barDockRight)";
            this.barDockRight.AccessibleName = "DotNetBar Bar";
            this.barDockRight.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.barDockRight.AutoSyncBarCaption = true;
            this.barDockRight.CloseSingleTab = true;
            this.barDockRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barDockRight.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.barDockRight.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.barDockRight.Location = new System.Drawing.Point(3, 0);
            this.barDockRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barDockRight.Name = "barDockRight";
            this.barDockRight.Size = new System.Drawing.Size(309, 127);
            this.barDockRight.Stretch = true;
            this.barDockRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barDockRight.TabIndex = 0;
            this.barDockRight.TabStop = false;
            this.barDockRight.Text = "barDockRight";
            this.barDockRight.Visible = false;
            // 
            // dockSiteTBBottom
            // 
            this.dockSiteTBBottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteTBBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSiteTBBottom.Location = new System.Drawing.Point(5, 632);
            this.dockSiteTBBottom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteTBBottom.Name = "dockSiteTBBottom";
            this.dockSiteTBBottom.Size = new System.Drawing.Size(1330, 0);
            this.dockSiteTBBottom.TabIndex = 9;
            this.dockSiteTBBottom.TabStop = false;
            // 
            // dockSiteTBLeft
            // 
            this.dockSiteTBLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteTBLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSiteTBLeft.Location = new System.Drawing.Point(5, 1);
            this.dockSiteTBLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteTBLeft.Name = "dockSiteTBLeft";
            this.dockSiteTBLeft.Size = new System.Drawing.Size(0, 631);
            this.dockSiteTBLeft.TabIndex = 6;
            this.dockSiteTBLeft.TabStop = false;
            // 
            // dockSiteTBRight
            // 
            this.dockSiteTBRight.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteTBRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSiteTBRight.Location = new System.Drawing.Point(1335, 1);
            this.dockSiteTBRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteTBRight.Name = "dockSiteTBRight";
            this.dockSiteTBRight.Size = new System.Drawing.Size(0, 631);
            this.dockSiteTBRight.TabIndex = 7;
            this.dockSiteTBRight.TabStop = false;
            // 
            // dockSiteTBTop
            // 
            this.dockSiteTBTop.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteTBTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSiteTBTop.Location = new System.Drawing.Point(5, 1);
            this.dockSiteTBTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteTBTop.Name = "dockSiteTBTop";
            this.dockSiteTBTop.Size = new System.Drawing.Size(1330, 0);
            this.dockSiteTBTop.TabIndex = 8;
            this.dockSiteTBTop.TabStop = false;
            // 
            // dockSiteTop
            // 
            this.dockSiteTop.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSiteTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSiteTop.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSiteTop.Location = new System.Drawing.Point(5, 1);
            this.dockSiteTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dockSiteTop.Name = "dockSiteTop";
            this.dockSiteTop.Size = new System.Drawing.Size(1330, 0);
            this.dockSiteTop.TabIndex = 4;
            this.dockSiteTop.TabStop = false;
            // 
            // CSRibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 660);
            this.Controls.Add(this.dockSiteFill);
            this.Controls.Add(this.dockSiteRight);
            this.Controls.Add(this.dockSiteLeft);
            this.Controls.Add(this.ribbonControlMain);
            this.Controls.Add(this.dockSiteTop);
            this.Controls.Add(this.dockSiteBottom);
            this.Controls.Add(this.dockSiteTBLeft);
            this.Controls.Add(this.dockSiteTBRight);
            this.Controls.Add(this.dockSiteTBTop);
            this.Controls.Add(this.dockSiteTBBottom);
            this.Controls.Add(this.barStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CSRibbonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSRibbonForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CSRibbonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barStatus)).EndInit();
            this.dockSiteBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barDockBottom)).EndInit();
            this.dockSiteFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barDockCenter)).EndInit();
            this.dockSiteLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barDockLeft)).EndInit();
            this.dockSiteRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barDockRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControlMain;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManagerMain;
        private DevComponents.DotNetBar.Bar barStatus;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManagerMain;
        private DevComponents.DotNetBar.DockSite dockSiteBottom;
        private DevComponents.DotNetBar.DockSite dockSiteLeft;
        private DevComponents.DotNetBar.DockSite dockSiteTop;
        private DevComponents.DotNetBar.DockSite dockSiteTBLeft;
        private DevComponents.DotNetBar.DockSite dockSiteTBRight;
        private DevComponents.DotNetBar.DockSite dockSiteTBTop;
        private DevComponents.DotNetBar.DockSite dockSiteTBBottom;
        private DevComponents.DotNetBar.DockSite dockSiteFill;
        private DevComponents.DotNetBar.DockSite dockSiteRight;
        private DevComponents.DotNetBar.Bar barDockRight;
        private DevComponents.DotNetBar.Bar barDockLeft;
        private DevComponents.DotNetBar.Bar barDockBottom;
        private DevComponents.DotNetBar.Bar barDockCenter;
    }
}