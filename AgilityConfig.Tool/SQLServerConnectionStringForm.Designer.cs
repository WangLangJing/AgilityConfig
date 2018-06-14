//namespace AgilityConfig.Tool
//{
//    partial class SQLServerConnectionStringForm
//    {
//        /// <summary>  
//        /// 必需的设计器变量。  
//        /// </summary>  
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>  
//        /// 清理所有正在使用的资源。  
//        /// </summary>  
//        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>  
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows 窗体设计器生成的代码  

//        /// <summary>  
//        /// 设计器支持所需的方法 - 不要  
//        /// 使用代码编辑器修改此方法的内容。  
//        /// </summary>  
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.cmbSeverName = new System.Windows.Forms.ComboBox();
//            this.btnReGetServerName = new System.Windows.Forms.Button();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.chkSavePwd = new System.Windows.Forms.CheckBox();
//            this.txtPwd = new System.Windows.Forms.TextBox();
//            this.txtUserName = new System.Windows.Forms.TextBox();
//            this.lblPwd = new System.Windows.Forms.Label();
//            this.lblUserName = new System.Windows.Forms.Label();
//            this.rbQCheck = new System.Windows.Forms.RadioButton();
//            this.rbWCheck = new System.Windows.Forms.RadioButton();
//            this.groupBox2 = new System.Windows.Forms.GroupBox();
//            this.label5 = new System.Windows.Forms.Label();
//            this.cmbDataBase = new System.Windows.Forms.ComboBox();
//            this.label6 = new System.Windows.Forms.Label();
//            this.btnTestConnect = new System.Windows.Forms.Button();
//            this.btnOK = new System.Windows.Forms.Button();
//            this.btnCancel = new System.Windows.Forms.Button();
//            this.groupBox1.SuspendLayout();
//            this.groupBox2.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.label1.Location = new System.Drawing.Point(16, 15);
//            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(205, 20);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "输入信息以连接到选定的数据源";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.label2.Location = new System.Drawing.Point(17, 46);
//            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(97, 20);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "服务器名(&E)：";
//            // 
//            // cmbSeverName
//            // 
//            this.cmbSeverName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.cmbSeverName.FormattingEnabled = true;
//            this.cmbSeverName.Location = new System.Drawing.Point(22, 72);
//            this.cmbSeverName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.cmbSeverName.Name = "cmbSeverName";
//            this.cmbSeverName.Size = new System.Drawing.Size(343, 28);
//            this.cmbSeverName.TabIndex = 2;
//            this.cmbSeverName.DropDown += new System.EventHandler(this.cmbSeverName_DropDown);
//            this.cmbSeverName.SelectedValueChanged += new System.EventHandler(this.cmbSeverName_SelectedValueChanged);
//            this.cmbSeverName.Click += new System.EventHandler(this.cmbSeverName_Click);
//            // 
//            // btnReGetServerName
//            // 
//            this.btnReGetServerName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.btnReGetServerName.Location = new System.Drawing.Point(374, 72);
//            this.btnReGetServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btnReGetServerName.Name = "btnReGetServerName";
//            this.btnReGetServerName.Size = new System.Drawing.Size(109, 28);
//            this.btnReGetServerName.TabIndex = 3;
//            this.btnReGetServerName.Text = "刷新(&R)";
//            this.btnReGetServerName.UseVisualStyleBackColor = true;
//            this.btnReGetServerName.Visible = false;
//            this.btnReGetServerName.Click += new System.EventHandler(this.btnReGetServerName_Click);
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.chkSavePwd);
//            this.groupBox1.Controls.Add(this.txtPwd);
//            this.groupBox1.Controls.Add(this.txtUserName);
//            this.groupBox1.Controls.Add(this.lblPwd);
//            this.groupBox1.Controls.Add(this.lblUserName);
//            this.groupBox1.Controls.Add(this.rbQCheck);
//            this.groupBox1.Controls.Add(this.rbWCheck);
//            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.groupBox1.Location = new System.Drawing.Point(23, 110);
//            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.groupBox1.Size = new System.Drawing.Size(460, 224);
//            this.groupBox1.TabIndex = 4;
//            this.groupBox1.TabStop = false;
//            this.groupBox1.Text = "登陆到服务器";
//            // 
//            // chkSavePwd
//            // 
//            this.chkSavePwd.AutoSize = true;
//            this.chkSavePwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.chkSavePwd.Location = new System.Drawing.Point(121, 190);
//            this.chkSavePwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.chkSavePwd.Name = "chkSavePwd";
//            this.chkSavePwd.Size = new System.Drawing.Size(84, 24);
//            this.chkSavePwd.TabIndex = 5;
//            this.chkSavePwd.Text = "保存密码";
//            this.chkSavePwd.UseVisualStyleBackColor = true;
//            this.chkSavePwd.Visible = false;
//            // 
//            // txtPwd
//            // 
//            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.txtPwd.Location = new System.Drawing.Point(121, 154);
//            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.txtPwd.Name = "txtPwd";
//            this.txtPwd.Size = new System.Drawing.Size(329, 26);
//            this.txtPwd.TabIndex = 4;
//            this.txtPwd.UseSystemPasswordChar = true;
//            // 
//            // txtUserName
//            // 
//            this.txtUserName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.txtUserName.Location = new System.Drawing.Point(121, 118);
//            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.txtUserName.Name = "txtUserName";
//            this.txtUserName.Size = new System.Drawing.Size(329, 26);
//            this.txtUserName.TabIndex = 3;
//            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
//            this.txtUserName.Validated += new System.EventHandler(this.txtUserName_Validated);
//            // 
//            // lblPwd
//            // 
//            this.lblPwd.AutoSize = true;
//            this.lblPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.lblPwd.Location = new System.Drawing.Point(43, 157);
//            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblPwd.Name = "lblPwd";
//            this.lblPwd.Size = new System.Drawing.Size(70, 20);
//            this.lblPwd.TabIndex = 2;
//            this.lblPwd.Text = "密码(&P)：";
//            // 
//            // lblUserName
//            // 
//            this.lblUserName.AutoSize = true;
//            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.lblUserName.Location = new System.Drawing.Point(28, 121);
//            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblUserName.Name = "lblUserName";
//            this.lblUserName.Size = new System.Drawing.Size(85, 20);
//            this.lblUserName.TabIndex = 2;
//            this.lblUserName.Text = "用户名(&U)：";
//            // 
//            // rbQCheck
//            // 
//            this.rbQCheck.AutoSize = true;
//            this.rbQCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.rbQCheck.Location = new System.Drawing.Point(14, 78);
//            this.rbQCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.rbQCheck.Name = "rbQCheck";
//            this.rbQCheck.Size = new System.Drawing.Size(203, 24);
//            this.rbQCheck.TabIndex = 1;
//            this.rbQCheck.Text = "使用SQL Server身份验证(&Q)";
//            this.rbQCheck.UseVisualStyleBackColor = true;
//            this.rbQCheck.CheckedChanged += new System.EventHandler(this.rbQCheck_CheckedChanged);
//            // 
//            // rbWCheck
//            // 
//            this.rbWCheck.AutoSize = true;
//            this.rbWCheck.Checked = true;
//            this.rbWCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.rbWCheck.Location = new System.Drawing.Point(14, 44);
//            this.rbWCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.rbWCheck.Name = "rbWCheck";
//            this.rbWCheck.Size = new System.Drawing.Size(197, 24);
//            this.rbWCheck.TabIndex = 0;
//            this.rbWCheck.TabStop = true;
//            this.rbWCheck.Text = "使用Windows身份验证(&W)";
//            this.rbWCheck.UseVisualStyleBackColor = true;
//            this.rbWCheck.CheckedChanged += new System.EventHandler(this.rbw_CheckedChanged);
//            // 
//            // groupBox2
//            // 
//            this.groupBox2.Controls.Add(this.label5);
//            this.groupBox2.Controls.Add(this.cmbDataBase);
//            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.groupBox2.Location = new System.Drawing.Point(26, 344);
//            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.groupBox2.Name = "groupBox2";
//            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.groupBox2.Size = new System.Drawing.Size(460, 106);
//            this.groupBox2.TabIndex = 5;
//            this.groupBox2.TabStop = false;
//            this.groupBox2.Text = "连接到一个数据库";
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.label5.Location = new System.Drawing.Point(28, 33);
//            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(201, 20);
//            this.label5.TabIndex = 0;
//            this.label5.Text = "选择或输入一个数据库名称(&D):";
//            // 
//            // cmbDataBase
//            // 
//            this.cmbDataBase.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.cmbDataBase.FormattingEnabled = true;
//            this.cmbDataBase.Location = new System.Drawing.Point(29, 58);
//            this.cmbDataBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.cmbDataBase.Name = "cmbDataBase";
//            this.cmbDataBase.Size = new System.Drawing.Size(418, 28);
//            this.cmbDataBase.TabIndex = 2;
//            this.cmbDataBase.DropDown += new System.EventHandler(this.cmbDataBase_DropDown);
//            // 
//            // label6
//            // 
//            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
//            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.label6.Location = new System.Drawing.Point(26, 470);
//            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(463, 3);
//            this.label6.TabIndex = 6;
//            // 
//            // btnTestConnect
//            // 
//            this.btnTestConnect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.btnTestConnect.Location = new System.Drawing.Point(27, 493);
//            this.btnTestConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btnTestConnect.Name = "btnTestConnect";
//            this.btnTestConnect.Size = new System.Drawing.Size(149, 32);
//            this.btnTestConnect.TabIndex = 7;
//            this.btnTestConnect.Text = "测试连接";
//            this.btnTestConnect.UseVisualStyleBackColor = true;
//            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
//            // 
//            // btnOK
//            // 
//            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.btnOK.Location = new System.Drawing.Point(281, 493);
//            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btnOK.Name = "btnOK";
//            this.btnOK.Size = new System.Drawing.Size(98, 32);
//            this.btnOK.TabIndex = 8;
//            this.btnOK.Text = "确定";
//            this.btnOK.UseVisualStyleBackColor = true;
//            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
//            // 
//            // btnCancel
//            // 
//            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.btnCancel.Location = new System.Drawing.Point(387, 493);
//            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btnCancel.Name = "btnCancel";
//            this.btnCancel.Size = new System.Drawing.Size(100, 32);
//            this.btnCancel.TabIndex = 9;
//            this.btnCancel.Text = "取消";
//            this.btnCancel.UseVisualStyleBackColor = true;
//            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
//            // 
//            // SQLServerConnectionStringForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(496, 544);
//            this.Controls.Add(this.btnCancel);
//            this.Controls.Add(this.btnOK);
//            this.Controls.Add(this.btnTestConnect);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.groupBox2);
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.btnReGetServerName);
//            this.Controls.Add(this.cmbSeverName);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
//            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.Name = "SQLServerConnectionStringForm";
//            this.Text = "设置连接";
//            this.Load += new System.EventHandler(this.frmDataBaseConnect_Load);
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            this.groupBox2.ResumeLayout(false);
//            this.groupBox2.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.ComboBox cmbSeverName;
//        private System.Windows.Forms.Button btnReGetServerName;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.RadioButton rbQCheck;
//        private System.Windows.Forms.RadioButton rbWCheck;
//        private System.Windows.Forms.Label lblPwd;
//        private System.Windows.Forms.Label lblUserName;
//        private System.Windows.Forms.TextBox txtPwd;
//        private System.Windows.Forms.TextBox txtUserName;
//        private System.Windows.Forms.CheckBox chkSavePwd;
//        private System.Windows.Forms.GroupBox groupBox2;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.ComboBox cmbDataBase;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Button btnTestConnect;
//        private System.Windows.Forms.Button btnOK;
//        private System.Windows.Forms.Button btnCancel;
    
    
//}
//}