using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ZSCRibbon.Extension
{
    /// <summary>
    /// 可停靠面板接口
    /// </summary>
    public interface ICSRDock
    {
        /// <summary>
        /// 获取面板标题
        /// </summary>
        string PanelTitle { get; }

        /// <summary>
        /// 获取默认停靠位置
        /// </summary>
        DockStyle DefaultDock { get; }

        /// <summary>
        /// 获取停靠面板
        /// </summary>
        PanelDockContainer Panel { get; }

    }
}
