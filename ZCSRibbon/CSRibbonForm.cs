using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ZCSRibbon
{
    public partial class CSRibbonForm : Office2007RibbonForm
    {
        public CSRibbonForm()
        {
            InitializeComponent();
        }

        #region 属性

        /// <summary>
        /// 获取或设置主StyleManager
        /// </summary>
        public StyleManager MainStyleManager
        {
            get { return styleManagerMain; }
            set { styleManagerMain = value; }
        }

        /// <summary>
        /// 获取或设置主RibbonControl
        /// </summary>
        public RibbonControl MainRibbonControl
        {
            get { return ribbonControlMain; }
            set { ribbonControlMain = value; }
        }

        #endregion
    }
}
