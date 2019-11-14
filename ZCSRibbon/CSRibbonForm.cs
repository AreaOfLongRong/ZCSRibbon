using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ZCSRibbon.EM;

namespace ZCSRibbon
{
    public partial class CSRibbonForm : Office2007RibbonForm
    {

        public CSRibbonForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSRibbonForm_Load(object sender, EventArgs e)
        {
            ExtensionManager em = new ExtensionManager();
            foreach (var menu in em.GetRibbonTabItems())
            {
                if (true)
                {
                    ribbonControlMain.Controls.Add(menu.Value.Panel);
                    ribbonControlMain.Items.Add(menu.Value);
                }
            }
            ribbonControlMain.SelectFirstVisibleRibbonTab();
        }

        #region 字段



        #endregion

        #region 属性

        /// <summary>
        /// 获取或设置主Style样式
        /// </summary>
        public eStyle MainStyle
        {
            get { return styleManagerMain.ManagerStyle; }
            set { styleManagerMain.ManagerStyle = value; }
        }

        /// <summary>
        /// 获取或设置主RibbonControl
        /// </summary>
        public RibbonControl MainRibbonControl
        {
            get { return ribbonControlMain; }
            set { ribbonControlMain = value; }
        }

        /// <summary>
        /// 获取或设置DotNetbar管理器
        /// </summary>
        public DotNetBarManager MainDotNetBarManager
        {
            get { return dotNetBarManagerMain; }
            set { dotNetBarManagerMain = value; }
        }

        #endregion
        
    }
}
