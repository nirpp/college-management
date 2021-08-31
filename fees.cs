using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace CollegeMgmtSys1
{
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source='F:\\fees.xlsx'; Extended properties= Excel 8.0");
            con.Open();
                String QRY = "Select *from [sheet1$]";
                OleDbDataAdapter ad = new OleDbDataAdapter(QRY,con);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main ss = new main();
            this.Hide();
            ss.Show();
        }
    }
}
