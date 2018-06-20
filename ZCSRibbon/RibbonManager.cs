using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;

namespace ZCSRibbon
{
    /// <summary>
    /// Ribbon管理器
    /// </summary>
    public class RibbonManager
    {

        #region 字段

        /// <summary>
        /// Ribbon管理器的唯一实例
        /// </summary>
        private static RibbonManager m_Instance;

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

        #endregion
    }
}
