using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace AgilityConfig.Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._tvConfigCatalog.NodeMouseClick += _tvConfigCatalog_NodeMouseClick;
            this._propGrids.PropertyValueChanged += _propGrids_PropertyValueChanged;
            AgilityConfigToolConfig config = new AgilityConfigToolConfig();
            String configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AgilityConfig.Tool.config.json");
            config.Load(configPath, false);

            var items = config.ConfigurableItems;
            if (items != null && items.Length > 0)
            {
                this.BuildConfigurableItemTreeView(items);
            }
        }



        private void _tvConfigCatalog_NodeMouseClick(Object sender, TreeNodeMouseClickEventArgs e)
        {
            this._btnSave.Enabled = false;

            var item = e.Node.Tag as ConfigurableItem;
            Object configObj = AgilityConfig.LoadConfig(item.type, item.Path, item.IsEncrypted);
            TypeInstanceWrapper wrapper = new TypeInstanceWrapper(configObj);
            this._propGrids.SelectedObject = wrapper;
        }

        private void BuildConfigurableItemTreeView(IEnumerable<ConfigurableItem> items)
        {
            foreach (var item in items)
            {
                Type type = null;
                try
                {
                    type = this.GetConfigType(item.Type);
                    if (type == null) continue;
                    item.type = type;
                    TreeNode node = new TreeNode();
                    node.Text = item.Name;
                    node.ToolTipText = item.Path;
                    node.Tag = item;
                    this._tvConfigCatalog.Nodes.Add(node);
                }
                catch { }

            }
        }
        public void ShowTipInfo(String tipInfo, Color? foreColor = null)
        {
            Color color = this.ForeColor;
            this._labelTip.Text = tipInfo;
            if (foreColor.HasValue)
            {
                color = foreColor.Value;
            }
            this._labelTip.ForeColor = color;
        }
        private Type GetConfigType(String typeStr)
        {
            String[] splitInfo = typeStr.Split(',');
            Type type = null;
            if (splitInfo.Length == 2)
            {
                String assemblyFileName = splitInfo[0];
                if (!assemblyFileName.EndsWith(".dll") && !assemblyFileName.EndsWith(".exe"))
                {
                    String temp = assemblyFileName + ".exe";
                    if (File.Exists(temp))
                    {
                        assemblyFileName = temp;
                    }
                    else
                    {
                        assemblyFileName = ".dll";
                    }
                }
                String assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, assemblyFileName);
                String typeName = splitInfo[1];

                var assembly = Assembly.LoadFrom(assemblyPath);
                type = assembly.GetType(typeName);
            }
            return type;
        }

        private void _btnSave_Click(Object sender, EventArgs e)
        {
            this.SaveConfig();
            this._btnSave.Enabled = false;
        }
        private void SaveConfig()
        {
            try
            {
                var wrapper = this._propGrids.SelectedObject as TypeInstanceWrapper;
                ConfigurableItem item = this._tvConfigCatalog.SelectedNode.Tag as ConfigurableItem;
                var config = wrapper.Instance as ConfigBase;
                config.Save(item.Path, item.IsEncrypted);
                this.ShowTipInfo("已保存当前配置");
            }
            catch (Exception exc)
            {
                this.ShowTipInfo("配置保存失败！", Color.Red);
                MessageBox.Show("配置保存失败！" + exc.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void _propGrids_PropertyValueChanged(Object s, PropertyValueChangedEventArgs e)
        {
            this.ShowTipInfo(String.Empty);
            this._btnSave.Enabled = true;
        }
    }
}
