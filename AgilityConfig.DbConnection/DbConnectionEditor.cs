using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing;
using System.Reflection;
using Microsoft.Data.ConnectionUI;
namespace AgilityConfig.DbConnection
{
    public class DbConnectionEditor : UITypeEditor
    {

        public override Object EditValue(ITypeDescriptorContext context, IServiceProvider provider, Object value)
        {

            String connectionString = value as String;
     


            //DataConnectionDialog editDialog = new DataConnectionDialog();
            //DataSource.AddStandardDataSources(editDialog);
            //editDialog.DataSources.Add(DataSource.SqlDataSource);
            //editDialog.DataSources.Add(DataSource.SqlFileDataSource);
            ////   editDialog.ConnectionString = connectionString;
            //DialogResult userChoice = DataConnectionDialog.Show(editDialog);

            using (var dialog = new DataConnectionDialog())
            {
              //  MessageBox.Show("dd");
                // If you want the user to select from any of the available data sources, do this:
                DataSource.AddStandardDataSources(dialog);

                // OR, if you want only certain data sources to be available
                // (e.g. only SQL Server), do something like this instead: 
                dialog.DataSources.Add(DataSource.SqlDataSource);
                dialog.DataSources.Add(DataSource.SqlFileDataSource);

                // The way how you show the dialog is somewhat unorthodox; `dialog.ShowDialog()`
                // would throw a `NotSupportedException`. Do it this way instead:
                DialogResult userChoice = DataConnectionDialog.Show(dialog);

                // Return the resulting connection string if a connection was selected:
                if (userChoice == DialogResult.OK)
                {
                    connectionString = dialog.ConnectionString;

                }
                else
                {
                    connectionString = null;

                }
            }
            // connectionString = editDialog.ConnectionString;



            return connectionString;
        }
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        
        //public override void PaintValue(PaintValueEventArgs e)
        //{
        //    Font font = new Font("微软雅黑", 9F);
        //    Brush brush = new SolidBrush(Color.Black);
        //    String text = e.Value as String;
        //    if (text == null)
        //    {
        //        text = "【未填写】";
        //    }

        //    RectangleF rect = new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
        //    e.Graphics.DrawString(text, font, brush, rect, new StringFormat
        //    {
        //        Alignment = StringAlignment.Center,
        //        LineAlignment = StringAlignment.Center
        //    });
        //    brush.Dispose();
        //    base.PaintValue(e);
        //}

      
    }

}
