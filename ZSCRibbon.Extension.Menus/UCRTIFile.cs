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
    /// “文件”菜单
    /// </summary>
    [Export(typeof(ICSRMenu))]
    [ExportMetadata("TabIndex", 0)]
    public partial class UCRTIFile : UserControl, ICSRMenu
    {
        public UCRTIFile()
        {
            InitializeComponent();
            MakeTabItem();
        }

        /// <summary>
        /// 获取是否一直显示
        /// </summary>
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
                return "文件";
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
            Panel.Controls.Add(ribbonBarFile);
            Panel.Controls.Add(ribbonBarApplication);
            TabItem.Panel = Panel;
            TabItem.Visible = IsShowAlways;
        }
    }
}
