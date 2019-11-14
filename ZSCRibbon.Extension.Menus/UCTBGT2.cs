using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ZSCRibbon.Extension.Menus
{
    public partial class UCTBGT2 : UserControl, ICSRMenu
    {

        private RibbonTabItemGroup _group;

        public UCTBGT2(RibbonTabItemGroup group)
        {
            InitializeComponent();
            _group = group;
            MakeTabItem();
        }

        public bool IsShowAlways
        {
            get { return false; }
        }

        public string Title
        {
            get { return "子菜单2"; }
        }

        public RibbonTabItem TabItem
        {
            get;
            private set;
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
            TabItem.Panel = Panel;
            TabItem.Group = _group;
            TabItem.Visible = true;
        }
    }
}
