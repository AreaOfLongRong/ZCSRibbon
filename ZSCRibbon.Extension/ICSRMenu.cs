using DevComponents.DotNetBar;

namespace ZSCRibbon.Extension
{
    /// <summary>
    /// Ribbon风格菜单接口
    /// </summary>
    public interface ICSRMenu
    {

        /// <summary>
        /// 获取是否一直显示
        /// </summary>
        bool IsShowAlways { get; }

        /// <summary>
        /// 获取Ribbon风格菜单文字标题
        /// </summary>
        string Title { get; }

        /// <summary>
        /// 获取Ribbon标签菜单对象
        /// </summary>
        RibbonTabItem TabItem { get; }

        /// <summary>
        /// 获取或设置Ribbon管理器
        /// </summary>
        IRibbonManager RibbonManager { get; set; }
        
        /// <summary>
        /// 生成RibbonTabItem标签
        /// </summary>
        void MakeTabItem();

    }
}
