using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZCSRibbon.Test.Properties;

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
