//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using System.Data.SqlClient;
//using Microsoft.SqlServer.Management.Smo;
//namespace AgilityConfig.Tool
//{
//    public partial class SQLServerConnectionStringForm : Form
//    {
//        private string strCheckType = "";                       //验证方式，Windows验证还是SQL验证  
//        private string strUserName = ";User ID=";               //用户名  
//        private string strPwd = ";Password=";                   //密码  
//        private string strDataBaseName = ";Initial Catalog=";   //数据库名称  
//        private string strDataSource = "Data Source=";          //服务器名称  

//        private string _strConnetionString = "";                //连接字符串  
//        public string ConnetionString
//        {
//            get
//            {
//                return _strConnetionString;
//            }
//            set { _strConnetionString = value; }
//        }

//        public SQLServerConnectionStringForm()
//        {
//            InitializeComponent();
//        }

//        private void rbQCheck_CheckedChanged(object sender, EventArgs e)
//        {

//        }

//        private void rbw_CheckedChanged(object sender, EventArgs e)
//        {
//            if (rbWCheck.Checked)
//            {
//                SetEnable(false);
//                strCheckType = ";Integrated Security=True";
//            }
//            else
//            {
//                SetEnable(true);
//                strCheckType = ";Persist Security Info=True";
//            }
//        }

//        //设置连接方式后控件的现实效果    
//        private void SetEnable(bool bEnable)
//        {
//            //rbQCheck.Enabled = bEnable;  
//            txtPwd.Enabled = bEnable;
//            txtUserName.Enabled = bEnable;
//            chkSavePwd.Enabled = bEnable;
//            lblPwd.Enabled = bEnable;
//            lblUserName.Enabled = bEnable;
//            txtUserNameChange();
//        }

//        //获取服务器名称的按钮事件  
//        private void btnReGetServerName_Click(object sender, EventArgs e)
//        {
//            btnReGetServerName.Enabled = false;
//           // GetDataBaseSeverName();
//            btnReGetServerName.Enabled = true;
//        }

//        /// <summary>  
//        /// 获取服务器名称  
//        /// </summary>  
//        private void GetDataBaseSeverName()
//        {
//            this.Cursor = Cursors.WaitCursor;

//            cmbSeverName.Items.Clear();
//            DataTable table = SmoApplication.EnumAvailableSqlServers();     //<----  
//            foreach (DataRow row in table.Rows)
//            {
//                string s = "";
//                foreach (DataColumn c in table.Columns)
//                {
//                    s += c.Caption + ": " + row[c] + "/n";
//                    if (c.Caption == "Server")
//                    {
//                        this.cmbSeverName.Items.Add(row[c]);
//                    }
//                }

//            }
//            this.cmbSeverName.SelectedIndex = 0;
//            this.Cursor = Cursors.Default;
//        }

//        /// <summary>  
//        /// 获取服务器对应的数据库名称  
//        /// </summary>  
//        /// <param name="strServerName">服务器名称</param>  
//        /// <param name="strUserName">用户名</param>  
//        /// <param name="strPwd">密码</param>  
//        /// <param name="bIsWindowObscured">是否为Windows验证</param>  
//        /// <returns></returns>  
//        public string[] GetDataBaseList(string strServerName, string strUserName, string strPwd, bool bIsWindowObscured)
//        {
//            string[] aTables = null;

//            Server svr = new Server();
//            svr.ConnectionContext.ServerInstance = strServerName;
//            svr.ConnectionContext.LoginSecure = bIsWindowObscured;
//            if (!bIsWindowObscured)
//            {
//                svr.ConnectionContext.Login = strUserName;
//                svr.ConnectionContext.Password = strPwd;
//            }
//            try
//            {
//                svr.ConnectionContext.Connect();
//                aTables = new string[svr.Databases.Count];
//                int i = 0;
//                foreach (Database db in svr.Databases)
//                {
//                    aTables[i] = db.Name;
//                    i++;
//                }
//            }
//            catch (System.Exception ex)
//            {
//                MessageBox.Show(ex.Message.ToString());

//            }


//            return aTables;
//        }

//        private void cmbSeverName_Click(object sender, EventArgs e)
//        {
//        }

//        private void frmDataBaseConnect_Load(object sender, EventArgs e)
//        {
//            SetEnable(false);
//            cmbDataBase.Enabled = false;
//        }

//        private void txtUserName_Validated(object sender, EventArgs e)
//        {

//        }

//        /// <summary>  
//        /// 用户名不为空时允许“确定”按钮弹出  
//        /// </summary>  
//        private void txtUserNameChange()
//        {
//            if (txtUserName.Text.Trim().Length != 0 || rbWCheck.Checked)
//            {
//                btnOK.Enabled = true;
//            }
//            else
//            {
//                btnOK.Enabled = false;
//            }
//        }

//        private void txtUserName_TextChanged(object sender, EventArgs e)
//        {
//            txtUserNameChange();
//        }

//        private void cmbSeverName_DropDown(object sender, EventArgs e)
//        {
//            if (cmbSeverName.Items.Count == 0)
//            {
//                btnReGetServerName.Enabled = false;
//          //      GetDataBaseSeverName();
//                btnReGetServerName.Enabled = true;
//            }

//            if (cmbSeverName.Items.Count != 0)
//            {
//                cmbDataBase.Enabled = true;
//            }
//        }

//        /// <summary>  
//        /// 数据库名称下拉框点击时间，获取数据库列表  
//        /// </summary>  
//        /// <param name="sender"></param>  
//        /// <param name="e"></param>  
//        private void cmbDataBase_DropDown(object sender, EventArgs e)
//        {
//            this.Cursor = Cursors.WaitCursor;

//            cmbDataBase.Items.Clear();

//            if (cmbSeverName.Text.Trim().Length != 0)
//            {

//                try
//                {
//                    string[] aDataBaseNames = GetDataBaseList(cmbSeverName.Text.Trim().ToString(), txtUserName.Text.Trim().ToString(), txtUserName.Text.Trim().ToString(), rbWCheck.Checked);

//                    if (aDataBaseNames != null)
//                    {

//                        for (int i = 0; i < aDataBaseNames.Length; i++)
//                        {
//                            cmbDataBase.Items.Add(aDataBaseNames[i]);
//                        }
//                        if (cmbDataBase.Items.Count != 0)
//                        {
//                            cmbDataBase.SelectedIndex = 0;
//                        }
//                    }
//                }
//                catch (System.Exception ex)
//                {
//                    MessageBox.Show(ex.Message.ToString(), "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }

//            }
//            this.Cursor = Cursors.Default;

//        }

//        private void btnCancel_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void btnTestConnect_Click(object sender, EventArgs e)
//        {
//            if (CheckConnect())
//            {
//                MessageBox.Show("连接成功！", "连接成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                this.cmbDataBase.Enabled = true;
//                this.chkSavePwd.Visible = true;
//            }
//            else
//            {
//                MessageBox.Show("连接不成功！", "连接不成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

//            }
//        }

//        private void cmbSeverName_SelectedValueChanged(object sender, EventArgs e)
//        {
//        }

//        private void btnOK_Click(object sender, EventArgs e)
//        {
//            if (!CheckConnect())
//            {
//                DialogResult d = MessageBox.Show("连接不成功，是否继续配置？", "连接不成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                if (d == DialogResult.No)
//                {
//                    _strConnetionString = "";
//                    this.Close();
//                }
//            }
//            else
//            {
//                if (rbWCheck.Checked)
//                {
//                    //拼写Windows验证的链接字符串  
//                    _strConnetionString = strDataSource + cmbSeverName.Text.Trim().ToString() + strDataBaseName + cmbDataBase.Text.Trim().ToString() + ";Integrated Security=True";
//                }
//                else
//                {
//                    //拼写SQL验证的连接字符串  
//                    _strConnetionString = strDataSource + cmbSeverName.Text.Trim().ToString()
//                        + strDataBaseName + cmbDataBase.Text.Trim().ToString() + strCheckType + strUserName
//                        + txtUserName.Text.Trim().ToString() + strPwd + txtPwd.Text.Trim().ToString();
//                }
//                this.Close();
//            }
//        }

//        private bool CheckConnect()
//        {
//            bool bResult = false;
//            //确定按钮点击后，检查是否成功连接，如果成连接，置标志位True,否则为false  
//            //false时，在获取程序连接字符串时提示没有配置成功  

//            string strConnectString;// = ConnetionString;  

//            if (rbWCheck.Checked)
//            {
//                //拼写Windows验证的链接字符串  
//                strConnectString = strDataSource + cmbSeverName.Text.Trim().ToString() + strDataBaseName + cmbDataBase.Text.Trim().ToString() + ";Integrated Security=True";
//            }
//            else
//            {
//                //拼写SQL验证的连接字符串  
//                strConnectString = strDataSource + cmbSeverName.Text.Trim().ToString()
//                    + strDataBaseName + cmbDataBase.Text.Trim().ToString() + strCheckType + strUserName
//                    + txtUserName.Text.Trim().ToString() + strPwd + txtPwd.Text.Trim().ToString();
//            }
//            SqlConnection myConnection = new SqlConnection(strConnectString);
//            try
//            {
//                myConnection.Open();
//                //MessageBox.Show("测试连接成功！", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Information);  
//                bResult = true;
//            }
//            catch //(System.Exception ex)  
//            {
//                //MessageBox.Show("连接不成功，是否继续配置？", "连接不成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
//                bResult = false;
//            }
//            finally
//            {
//                myConnection.Close();
//            }

//            return bResult;
//        }
    
//}
//}
