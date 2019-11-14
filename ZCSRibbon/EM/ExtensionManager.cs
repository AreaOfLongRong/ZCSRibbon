using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using ZSCRibbon.Extension;

namespace ZCSRibbon.EM
{
    /// <summary>
    /// 扩展管理器
    /// </summary>
    public class ExtensionManager
    {
        #region 字段

        /// <summary>
        /// 撰写容器
        /// </summary>
        private CompositionContainer _container;

        /// <summary>
        /// Ribbon菜单项
        /// </summary>
        [ImportMany]
        private IEnumerable<Lazy<ICSRMenu, ICSRMenuData>> _ribbonMenus;

        #endregion

        #region 属性



        #endregion

        #region 构造函数

        /// <summary>
        /// 初始化一个扩展管理器实例
        /// </summary>
        public ExtensionManager()
        {
            //合并 ComposablePartCatalog 对象元素的目录。
            var catalog = new AggregateCatalog();
            //添加所有本程序集中的Parts
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            //添加“Extensions”子目录中的Parts
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Extensions")));

            //用Catalog中的Parts创建一个新的CompositionContainer撰写容器对象
            _container = new CompositionContainer(catalog);

            //填充
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        #endregion


        #region 公共方法

        /// <summary>
        /// 获取Ribbon菜单项列表
        /// </summary>
        /// <returns></returns>
        public SortedList<int, RibbonTabItem> GetRibbonTabItems()
        {
            SortedList<int, RibbonTabItem> results = new SortedList<int, RibbonTabItem>();
            foreach (Lazy<ICSRMenu, ICSRMenuData> menu in _ribbonMenus)
            {
                menu.Value.RibbonManager = RibbonManager.Instance;
                results.Add(menu.Metadata.TabIndex, menu.Value.TabItem);
            }
            return results;
        }

        #endregion


        #region 私有方法



        #endregion

    }
}
