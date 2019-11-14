using System.Collections.Generic;
using DevComponents.DotNetBar;

namespace ZSCRibbon.Extension
{
    /// <summary>
    /// Ribbon界面管理器接口。提供如下功能接口描述：
    /// 1、Ribbon风格菜单的添加、移除、隐藏接口；
    /// 2、可停靠的左侧、底部和右侧面板的添加、移除、隐藏、更新等接口；
    /// 3、核心工作区面板的添加、移除、隐藏、更新等接口；
    /// 4、状态栏控件的添加、移除、隐藏、更新等接口；
    /// 5、事件交互注册与监听的接口。
    /// </summary>
    public interface IRibbonManager
    {

        void AddRibbonGroup(RibbonTabItemGroup ribbonTabItemGroup, List<RibbonTabItem> tabItems);

        void AddDockPanel(ICSRDock dockPanel);
    }
}
