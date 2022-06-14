using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ColorCheckDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sdaColor.Fill(dsColor1);
            foreach (DataRow r in dsColor1.Tables[0].Rows)
            {
                CheckBox chk = new CheckBox();
                chk.CheckedChanged += new EventHandler(chk_CheckedChanged);
                chk.Text = r["Color"].ToString();
                flpColor.Controls.Add(chk);
            }
        }

        void chk_CheckedChanged(object sender, EventArgs e)
        {
            string ColorCollection = "";
            foreach (Control c in flpColor.Controls)
            {
                if (((CheckBox)c).Checked)
                { 
                    if(ColorCollection.Length==0)
                        ColorCollection=string.Format("'{0}'",c.Text);
                    else
                        ColorCollection+=string.Format(",'{0}'",c.Text);
                }
            }
            if (ColorCollection.Length == 0)
                dbgProduct.DataSource = null;
            else
            {
                SqlCommand cmd = new SqlCommand(string.Format("SELECT ProductID,Name,Color FROM Production.Product WHERE ISNULL(Color,'[No Color]') IN({0})",ColorCollection),sqlConnection1);
                DataTable tbl = new DataTable();
                cmd.Connection.Open();
                tbl.Load(cmd.ExecuteReader());
                cmd.Connection.Close();
                dbgProduct.DataSource = tbl;
            }
        }
    }
}
