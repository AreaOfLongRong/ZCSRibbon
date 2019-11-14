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
using System.ComponentModel.Composition;

namespace ZSCRibbon.Extension.Menus
{
    /// <summary>
    /// “帮助”菜单
    /// </summary>
    [Export(typeof(ICSRMenu))]
    [ExportMetadata("TabIndex", 2)]
    public partial class UCHelp : UserControl, ICSRMenu
    {
        public UCHelp()
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
                return "帮助";
            }
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
            Panel.Controls.Add(ribbonBarHelp);
            Panel.Controls.Add(ribbonBar1);
            Panel.Controls.Add(ribbonBar2);
            TabItem.Panel = Panel;
            TabItem.Visible = IsShowAlways;
        }
    }
}
