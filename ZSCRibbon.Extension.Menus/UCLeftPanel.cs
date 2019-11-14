using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ZSCRibbon.Extension.Menus
{
    public partial class UCLeftPanel : UserControl, ICSRDock
    {
        public UCLeftPanel()
        {
            InitializeComponent();
        }

        private PanelDockContainer m_PanelDockContainer;

        public string PanelTitle
        {
            get
            {
                return "管理器";
            }
        }

        public DockStyle DefaultDock
        {
            get
            {
                return DockStyle.Left;
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
