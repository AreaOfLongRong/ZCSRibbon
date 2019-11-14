using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ZSCRibbon.Extension.Menus
{
    public partial class UCOutputPanel : UserControl, ICSRDock
    {
        public UCOutputPanel()
        {
            InitializeComponent();
            
        }

        #region 私有字段

        private PanelDockContainer m_PanelDockContainer;

        /// <summary>
        /// 搜索的起始索引位置
        /// </summary>
        private int m_SearchStartIndex = 0;
        private int m_SearchCount = 0;
        private int count = 0;

        #endregion

        public string PanelTitle
        {
            get
            {
                return "输出";
            }
        }

        public DockStyle DefaultDock
        {
            get
            {
                return DockStyle.Bottom;
            }
        }

        public PanelDockContainer Panel
        {
            get
            {
                if (m_PanelDockContainer == null)
                {
                    m_PanelDockContainer = new PanelDockContainer();
                    m_PanelDockContainer.ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
                    m_PanelDockContainer.Name = "panelDockContainer" + Guid.NewGuid();
                    m_PanelDockContainer.Controls.Add(panelExMain);
                }
                return m_PanelDockContainer;
            }
        }

        /// <summary>
        /// 清空输出文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemClear_Click(object sender, EventArgs e)
        {
            richTextBoxExMain.Clear();
        }

        /// <summary>
        /// 检索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemSearch_Click(object sender, EventArgs e)
        {
            //要搜索的文本
            string searchStr = textBoxItemSearch.Text;
            //切换开关值为false，代表向下搜索；值为true，代表向上搜索。
            if (!switchButtonItemSearchDirection.Value)
            {
                //文本长度
                int textLength = richTextBoxExMain.Text.Length;

                if (m_SearchStartIndex < textLength)
                {
                    //从指定起始位置处搜索指定文本
                    m_SearchStartIndex = richTextBoxExMain.Find(searchStr, m_SearchStartIndex, RichTextBoxFinds.None);
                    //下一次搜索的起始位置
                    int l_NextSearchStartIndex = richTextBoxExMain.SelectionStart + searchStr.Length;
                    
                    if ((m_SearchStartIndex < 0) || (m_SearchStartIndex > textLength))
                    {
                        if (count == 0)
                        {
                            this.seeks(searchStr);
                            m_SearchStartIndex = l_NextSearchStartIndex;
                            m_SearchCount = 0;
                        }
                        else
                        {
                            this.seeks(searchStr);
                            m_SearchStartIndex = l_NextSearchStartIndex;
                            m_SearchCount = 0;
                        }
                    }
                    else if (m_SearchStartIndex == textLength || m_SearchStartIndex < 0)
                    {
                        this.seeks(searchStr);
                        m_SearchStartIndex = l_NextSearchStartIndex;
                        m_SearchCount = 0;
                    }
                    else
                    {
                        m_SearchCount++;
                        m_SearchStartIndex = l_NextSearchStartIndex;
                        richTextBoxExMain.Focus();
                    }
                }
                else if (m_SearchStartIndex == textLength || m_SearchStartIndex < 0)
                {
                    int los = richTextBoxExMain.SelectionStart + searchStr.Length;
                    this.seeks(searchStr);
                    m_SearchStartIndex = los;
                    m_SearchCount = 0;
                }
                else
                {
                    int los = richTextBoxExMain.SelectionStart + searchStr.Length;
                    this.seeks(searchStr);
                    m_SearchStartIndex = los;
                    m_SearchCount = 0;
                }
            }
            else
            {
                int rboxL = richTextBoxExMain.SelectionStart;
                int index = richTextBoxExMain.Find(searchStr, 0, rboxL, RichTextBoxFinds.Reverse);
                if (index > 0)
                {
                    richTextBoxExMain.SelectionStart = index;
                    richTextBoxExMain.SelectionLength = searchStr.Length;
                    m_SearchCount++;
                    richTextBoxExMain.Focus();
                }
                else if (index < 0)
                {
                    seeks(searchStr);
                    m_SearchCount = 0;
                    //如果还想再找一遍,添加下面这句  
                    //rbox.SelectionStart = rbox.Text.Length;  
                }
            }
        }

        /// <summary> 消息提示,提示用户查找结果<para>　<para>  
        /// 参数1(str):用户指定要查找的字符串</para></para> </summary>  
        /// <param name="str">用户指定要查找的字符串</param>  
        private void seeks(string str)
        {
            if (m_SearchCount != 0)
                MessageBox.Show(string.Format("已查找完毕,共〖{0}〗个 \"{1}\"！", m_SearchCount, str), "查找 - 温馨提示");
            else MessageBox.Show(string.Format("没有查找到 \"{0}\"！", str), "查找 - 温馨提示");
        }


        /// <summary>
        /// 文本改变时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxExMain_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxExMain.TextLength >= richTextBoxExMain.MaxLength)
            {
                richTextBoxExMain.Clear();
            }
        }

        /// <summary>
        /// 搜索内容文本改变时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxItemSearch_TextChanged(object sender, EventArgs e)
        {
            if(textBoxItemSearch.Text.Length > 0)
            {
                buttonItemSearch.Enabled = true;
                switchButtonItemSearchDirection.Enabled = true;
            }
            else
            {
                buttonItemSearch.Enabled = false;
                switchButtonItemSearchDirection.Enabled = false;
            }
        }
    }
}
