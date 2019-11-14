namespace ZSCRibbon.Extension.Menus
{
    partial class UCTBGT2
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
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.rangeSliderItem1 = new DevComponents.DotNetBar.RangeSliderItem();
            this.ratingItem1 = new DevComponents.DotNetBar.RatingItem();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rangeSliderItem1,
            this.ratingItem1});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 3);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(293, 114);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rangeSliderItem1
            // 
            this.rangeSliderItem1.Name = "rangeSliderItem1";
            this.rangeSliderItem1.RangeTooltipFormat = "Min: {0} - Max: {1}";
            this.rangeSliderItem1.Text = "rangeSliderItem1";
            // 
            // ratingItem1
            // 
            // 
            // 
            // 
            this.ratingItem1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingItem1.Name = "ratingItem1";
            // 
            // UCTBGT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonBar1);
            this.Name = "UCTBGT2";
            this.Size = new System.Drawing.Size(583, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RangeSliderItem rangeSliderItem1;
        private DevComponents.DotNetBar.RatingItem ratingItem1;
    }
}
