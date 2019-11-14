namespace ZSCRibbon.Extension.Menus
{
    partial class UCRTIFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRTIFile));
            this.ribbonBarFile = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItemOpenFile = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSaveFile = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarApplication = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // ribbonBarFile
            // 
            this.ribbonBarFile.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarFile.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarFile.ContainerControlProcessDialogKey = true;
            this.ribbonBarFile.DragDropSupport = true;
            this.ribbonBarFile.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemOpenFile,
            this.buttonItemSaveFile});
            this.ribbonBarFile.Location = new System.Drawing.Point(3, 3);
            this.ribbonBarFile.Name = "ribbonBarFile";
            this.ribbonBarFile.Size = new System.Drawing.Size(131, 84);
            this.ribbonBarFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarFile.TabIndex = 0;
            this.ribbonBarFile.Text = "操作";
            // 
            // 
            // 
            this.ribbonBarFile.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarFile.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItemOpenFile
            // 
            this.buttonItemOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemOpenFile.Image")));
            this.buttonItemOpenFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemOpenFile.Name = "buttonItemOpenFile";
            this.buttonItemOpenFile.SubItemsExpandWidth = 14;
            this.buttonItemOpenFile.Text = "打开...";
            // 
            // buttonItemSaveFile
            // 
            this.buttonItemSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSaveFile.Image")));
            this.buttonItemSaveFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSaveFile.Name = "buttonItemSaveFile";
            this.buttonItemSaveFile.SubItemsExpandWidth = 14;
            this.buttonItemSaveFile.Text = "保存...";
            // 
            // ribbonBarApplication
            // 
            this.ribbonBarApplication.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarApplication.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarApplication.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarApplication.ContainerControlProcessDialogKey = true;
            this.ribbonBarApplication.DragDropSupport = true;
            this.ribbonBarApplication.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.ribbonBarApplication.Location = new System.Drawing.Point(140, 3);
            this.ribbonBarApplication.Name = "ribbonBarApplication";
            this.ribbonBarApplication.Size = new System.Drawing.Size(90, 84);
            this.ribbonBarApplication.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarApplication.TabIndex = 1;
            this.ribbonBarApplication.Text = "应用程序";
            // 
            // 
            // 
            this.ribbonBarApplication.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarApplication.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "退出";
            // 
            // UCRTIFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonBarApplication);
            this.Controls.Add(this.ribbonBarFile);
            this.Name = "UCRTIFile";
            this.Size = new System.Drawing.Size(548, 98);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBarFile;
        private DevComponents.DotNetBar.ButtonItem buttonItemOpenFile;
        private DevComponents.DotNetBar.ButtonItem buttonItemSaveFile;
        private DevComponents.DotNetBar.RibbonBar ribbonBarApplication;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
    }
}
