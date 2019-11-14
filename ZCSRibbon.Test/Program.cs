using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ZCSRibbon.Test.Properties;
using ZCSRibbon.Test.Views;

namespace ZCSRibbon.Test
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            RibbonManager rm = RibbonManager.Instance;
            try
            {
                rm.FormIcon = Resources.TestIcon;
                rm.FormTitle = "测试窗体";
                rm.FormStyle = eStyle.Office2010Blue;
                
                Application.Run(rm.MainRibbonForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                rm.Dispose();
            }
        }
    }
}
