using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ZSCRibbon.Extension;

namespace ZCSRibbon
{
    /// <summary>
    /// Ribbon管理器
    /// </summary>
    public class RibbonManager : IRibbonManager
    {

        #region 字段

        /// <summary>
        /// Ribbon管理器的唯一实例
        /// </summary>
        private static RibbonManager m_Instance;

        /// <summary>
        /// 可停靠容器项索引编号
        /// </summary>
        private static int m_DockContainerItemIndex;
        
        #endregion

        #region 属性

        /// <summary>
        /// 获取Ribbon管理器的唯一实例
        /// </summary>
        public static RibbonManager Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new RibbonManager();
                return m_Instance;
            }
        }

        /// <summary>
        /// 获取或设置主Ribbon窗体
        /// </summary>
        public CSRibbonForm MainRibbonForm
        {
            get; set;
        }

        /// <summary>
        /// 获取或设置窗体图标
        /// </summary>
        public Icon FormIcon
        {
            get { return MainRibbonForm.Icon; }
            set { MainRibbonForm.Icon = value; }
        }

        /// <summary>
        /// 获取或设置窗体标题
        /// </summary>
        public string FormTitle
        {
            get { return MainRibbonForm.Text; }
            set { MainRibbonForm.Text = value; }
        }

        /// <summary>
        /// 获取或设置样式管理器
        /// </summary>
        public eStyle FormStyle
        {
            get { return MainRibbonForm.MainStyle; }
            set { MainRibbonForm.MainStyle = value; }
        }

        #endregion

        #region 事件



        #endregion


        #region 构造函数

        /// <summary>
        /// 使用
        /// </summary>
        private RibbonManager()
        {
            init();
        }

        #endregion

        #region 公共方法


        #region 快速访问工具条管理

        #endregion

        #region 菜单栏管理

        /// <summary>
        /// 添加Ribbon菜单项
        /// </summary>
        /// <param name="ribbonTabItem">Ribbon菜单项</param>
        public void AddRibbonTabItem(RibbonTabItem ribbonTabItem)
        {
            MainRibbonForm.MainRibbonControl.Items.Add(ribbonTabItem);
        }

        /// <summary>
        /// 移除Ribbon菜单项
        /// </summary>
        /// <param name="ribbonTabItem">Ribbon菜单项</param>
        public void RemoveRibbonTabItem(RibbonTabItem ribbonTabItem)
        {
            MainRibbonForm.MainRibbonControl.Items.Remove(ribbonTabItem);
        }

        /// <summary>
        /// 添加一个Ribbon菜单组
        /// </summary>
        /// <param name="ribbonTabItemGroup">Ribbon菜单组</param>
        public void AddRibbonGroup(RibbonTabItemGroup ribbonTabItemGroup, List<RibbonTabItem> tabItems)
        {
            foreach (var tab in tabItems)
            {
                MainRibbonForm.MainRibbonControl.Items.Add(tab);
                MainRibbonForm.MainRibbonControl.Controls.Add(tab.Panel);
            }
            MainRibbonForm.MainRibbonControl.TabGroups.Add(ribbonTabItemGroup);
            MainRibbonForm.MainRibbonControl.TabGroupsVisible = true;
            MainRibbonForm.MainRibbonControl.PerformLayout();
        }

        #endregion

        #region 可停靠面板管理

        /// <summary>
        /// 添加一个可停靠面板
        /// </summary>
        /// <param name="dockPanel">可停靠面板</param>
        public void AddDockPanel(ICSRDock dockPanel)
        {
            DockContainerItem dockContainerItem = new DockContainerItem(
                generatNewDockContainerItemName(), dockPanel.PanelTitle);
            dockContainerItem.Control = dockPanel.Panel;
            dockContainerItem.CanClose = eDockContainerClose.Yes;
            switch (dockPanel.DefaultDock)
            {
                case DockStyle.Left:
                    //停靠左侧面板
                    MainRibbonForm.barDockLeft.Controls.Add(dockPanel.Panel);
                    MainRibbonForm.barDockLeft.Items.Add(dockContainerItem);
                    MainRibbonForm.barDockLeft.Text = dockPanel.PanelTitle;
                    MainRibbonForm.barDockLeft.SelectedDockContainerItem = dockContainerItem;
                    MainRibbonForm.barDockLeft.DockTabClosed += BarDockLeft_DockTabClosed;
                    if (!MainRibbonForm.barDockLeft.Visible)
                        MainRibbonForm.barDockLeft.Visible = true;
                    else
                        MainRibbonForm.barDockLeft.RecalcLayout();
                    break;
                case DockStyle.Right:
                    //停靠右侧面板
                    MainRibbonForm.barDockRight.Controls.Add(dockPanel.Panel);
                    MainRibbonForm.barDockRight.Items.Add(dockContainerItem);
                    MainRibbonForm.barDockRight.Text = dockPanel.PanelTitle;
                    MainRibbonForm.barDockRight.SelectedDockContainerItem = dockContainerItem;
                    MainRibbonForm.barDockRight.DockTabClosed += BarDockRight_DockTabClosed;
                    if (!MainRibbonForm.barDockRight.Visible)
                        MainRibbonForm.barDockRight.Visible = true;
                    else
                        MainRibbonForm.barDockRight.RecalcLayout();
                    break;
                case DockStyle.Bottom:
                    //停靠底部面板
                    MainRibbonForm.barDockBottom.Controls.Add(dockPanel.Panel);
                    MainRibbonForm.barDockBottom.Items.Add(dockContainerItem);
                    MainRibbonForm.barDockBottom.Text = dockPanel.PanelTitle;
                    MainRibbonForm.barDockBottom.SelectedDockContainerItem = dockContainerItem;
                    MainRibbonForm.barDockBottom.DockTabClosed += BarDockBottom_DockTabClosed;
                    if (!MainRibbonForm.barDockBottom.Visible)
                        MainRibbonForm.barDockBottom.Visible = true;
                    else
                        MainRibbonForm.barDockBottom.RecalcLayout();
                    break;
                case DockStyle.Fill:
                    //停靠中间面板
                    MainRibbonForm.barDockCenter.Controls.Add(dockPanel.Panel);
                    MainRibbonForm.barDockCenter.Items.Add(dockContainerItem);
                    MainRibbonForm.barDockCenter.Text = dockPanel.PanelTitle;
                    MainRibbonForm.barDockCenter.SelectedDockContainerItem = dockContainerItem;
                    MainRibbonForm.barDockCenter.DockTabClosed += BarDockCenter_DockTabClosed;
                    if (!MainRibbonForm.barDockCenter.Visible)
                        MainRibbonForm.barDockCenter.Visible = true;
                    else
                        MainRibbonForm.barDockCenter.RecalcLayout();
                    break;
            }
        }

        /// <summary>
        /// 左侧面板可停靠标签关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarDockLeft_DockTabClosed(object sender, DockTabClosingEventArgs e)
        {
            
        }

        /// <summary>
        /// 右侧面板可停靠标签关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarDockRight_DockTabClosed(object sender, DockTabClosingEventArgs e)
        {
            
        }

        /// <summary>
        /// 底部面板可停靠标签关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarDockBottom_DockTabClosed(object sender, DockTabClosingEventArgs e)
        {
            
        }

        /// <summary>
        /// 核心面板可停靠标签关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarDockCenter_DockTabClosed(object sender, DockTabClosingEventArgs e)
        {
            
        }

        #endregion

        #region 核心区面板管理

        #endregion

        #region 状态栏管理

        #endregion


        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {

        }

        #endregion


        #region 私有方法

        /// <summary>
        /// 初始化操作
        /// </summary>
        private void init()
        {
            MainRibbonForm = new CSRibbonForm();
            ribbonChinesization();
        }

        /// <summary>
        /// 汉化Ribbon工具栏中的英文标注
        /// </summary>
        private void ribbonChinesization()
        {
            #region Ribbon汉化代码
            RibbonLocalization ribbonTexts = MainRibbonForm.MainRibbonControl.SystemText;
            ribbonTexts.MaximizeRibbonText = "功能区最大化 (&M)";
            ribbonTexts.MinimizeRibbonText = "功能区最小化 (&N)";
            ribbonTexts.QatAddItemText = "添加到快速访问工具栏 (&A)";
            ribbonTexts.QatCustomizeMenuLabel = "<b>自定义快速访问工具栏</b>";
            ribbonTexts.QatCustomizeText = "自定义快速访问工具栏 (&C)...";
            ribbonTexts.QatDialogAddButton = "添加(&A)>>";
            ribbonTexts.QatDialogCancelButton = "取消";
            ribbonTexts.QatDialogCaption = "自定义快速访问工具栏";
            ribbonTexts.QatDialogCategoriesLabel = "选择命令(&C):";
            ribbonTexts.QatDialogOkButton = "确定";
            ribbonTexts.QatDialogPlacementCheckbox = "在功能区下方显示快速访问工具栏 (&P)";
            ribbonTexts.QatDialogRemoveButton = "<<删除(&R)";
            ribbonTexts.QatPlaceAboveRibbonText = "在功能区上方显示快速访问工具栏 (&P)";
            ribbonTexts.QatPlaceBelowRibbonText = "在功能区下方显示快速访问工具栏 (&P)";
            ribbonTexts.QatRemoveItemText = "从快速访问工具栏删除 (&R)";
            #endregion
        }
        
        /// <summary>
        /// 生成一个新的可停靠容器项名称
        /// </summary>
        /// <returns>新的可停靠容器项名称</returns>
        private string generatNewDockContainerItemName()
        {
            return "DockContainerItem" + (m_DockContainerItemIndex++);
        }

        #endregion
    }
}
