namespace AgilityConfig.Tool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._propGrids = new System.Windows.Forms.PropertyGrid();
            this._tvConfigCatalog = new System.Windows.Forms.TreeView();
            this._btnSave = new System.Windows.Forms.Button();
            this._labelTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _propGrids
            // 
            this._propGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._propGrids.Location = new System.Drawing.Point(307, 12);
            this._propGrids.Name = "_propGrids";
            this._propGrids.Size = new System.Drawing.Size(463, 593);
            this._propGrids.TabIndex = 0;
            // 
            // _tvConfigCatalog
            // 
            this._tvConfigCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._tvConfigCatalog.Location = new System.Drawing.Point(12, 13);
            this._tvConfigCatalog.Name = "_tvConfigCatalog";
            this._tvConfigCatalog.Size = new System.Drawing.Size(278, 630);
            this._tvConfigCatalog.TabIndex = 1;
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.Location = new System.Drawing.Point(674, 616);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(96, 31);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "保存";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _labelTip
            // 
            this._labelTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._labelTip.AutoSize = true;
            this._labelTip.Location = new System.Drawing.Point(304, 626);
            this._labelTip.Name = "_labelTip";
            this._labelTip.Size = new System.Drawing.Size(0, 17);
            this._labelTip.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 654);
            this.Controls.Add(this._labelTip);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._tvConfigCatalog);
            this.Controls.Add(this._propGrids);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "管理现有配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid _propGrids;
        private System.Windows.Forms.TreeView _tvConfigCatalog;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label _labelTip;
    }
}

