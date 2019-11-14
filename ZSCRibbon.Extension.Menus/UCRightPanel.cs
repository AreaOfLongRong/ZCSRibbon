using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ZSCRibbon.Extension.Menus
{
    public partial class UCRightPanel : UserControl, ICSRDock
    {
        public UCRightPanel()
        {
            InitializeComponent();
        }

        private PanelDockContainer m_PanelDockContainer;

        /// <summary>
        /// 获取可停靠面板的标题
        /// </summary>
        public string PanelTitle
        {
            get
            {
                return "属性";
            }
        }

        /// <summary>
        /// 获取默认停靠位置
        /// </summary>
        public DockStyle DefaultDock
        {
            get
            {
                return DockStyle.Right;
            }
        }

        public PanelDockContainer Panel
        {
            get
            {
                if (m_PanelDockContainer == null)
                {
                    m_PanelDockContainer = new PanelDockContainer();
                    m_PanelDockContainer.ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
                    m_PanelDockContainer.Name = "panelDockContainer" + Guid.NewGuid();
                    m_PanelDockContainer.Controls.Add(panelExMain);
                }
                return m_PanelDockContainer;
            }
        }
    }
}
