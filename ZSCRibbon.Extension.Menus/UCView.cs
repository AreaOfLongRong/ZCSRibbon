using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ZSCRibbon.Extension.Menus
{

    /// <summary>
    /// “视图”菜单
    /// </summary>
    [Export(typeof(ICSRMenu))]
    [ExportMetadata("TabIndex", 1)]
    public partial class UCView : UserControl, ICSRMenu
    {
        public UCView()
        {
            InitializeComponent();
            MakeTabItem();
        }

        public bool IsShowAlways
        {
            get
            {
                return true;
            }
        }

        public string Title
        {
            get
            {
                return "视图";
            }
        }

        public RibbonTabItem TabItem
        {
            get;private set;
        }

        public IRibbonManager RibbonManager
        {
            get;
            set;
        }

        public void MakeTabItem()
        {
            TabItem = new RibbonTabItem();
            TabItem.Name = Title;
            TabItem.Text = Title;

            RibbonPanel Panel = new RibbonPanel();
            Panel.ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            Panel.Dock = DockStyle.Fill;
            Panel.Controls.Add(ribbonBar1);
            Panel.Controls.Add(ribbonBar2);
            TabItem.Panel = Panel;
            TabItem.Visible = IsShowAlways;
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            RibbonTabItemGroup group = new RibbonTabItemGroup();
            group.Color = eRibbonTabGroupColor.Green;
            group.GroupTitle = "子菜单实例";

            group.Style.BackColor = Color.Red;
            group.Style.BackColor2 = Color.Green;
            group.Style.BackColorGradientAngle = 45;
            group.Style.BorderBottom = eStyleBorderType.Solid;
            group.Style.BorderBottomWidth = 1;
            group.Style.BorderColor = Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            group.Style.BorderLeft = eStyleBorderType.Solid;
            group.Style.BorderLeftWidth = 1;
            group.Style.BorderRight = eStyleBorderType.Solid;
            group.Style.BorderRightWidth = 1;
            group.Style.BorderTop = eStyleBorderType.Solid;
            group.Style.BorderTopWidth = 1;
            group.Style.CornerType = eCornerType.Square;
            group.Style.TextAlignment = eStyleTextAlignment.Center;
            group.Style.TextColor = Color.White;
            group.Style.TextLineAlignment = eStyleTextAlignment.Near;

            List<RibbonTabItem> tabItems = new List<RibbonTabItem>();
            UCTBGT1 uCTBGT1 = new UCTBGT1(group);
            tabItems.Add(uCTBGT1.TabItem);

            UCTBGT2 uCTBGT2 = new UCTBGT2(group);
            tabItems.Add(uCTBGT2.TabItem);

            RibbonManager.AddRibbonGroup(group, tabItems);
        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            if(RibbonManager != null)
            {
                RibbonManager.AddDockPanel(new UCRightPanel());
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (RibbonManager != null)
            {
                RibbonManager.AddDockPanel(new UCOutputPanel());
            }
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (RibbonManager != null)
            {
                RibbonManager.AddDockPanel(new UCLeftPanel());
            }
        }
    }
}
