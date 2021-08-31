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
    public partial class Admission1 : Form
    {
        public Admission1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtfullname.Text;
                String gender = "";
                bool isChecked = radioButtonmale.Checked;
                if (isChecked)
                {
                    gender = radioButtonmale.Text;

                }
                else
                {
                    gender = radioButtonfemale.Text;
                }
                long mobile = long.Parse(txtmobile.Text);
                String Dept = txtdept.Text;
                String email = txtemail.Text;
                String Category = txtcategory.Text;
                OleDbConnection con = new OleDbConnection(" Provider=Microsoft.Jet.OleDb.4.0;Data Source='F:\\fees.xlsx'; Extended properties= Excel 8.0");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                String sql = "insert into [Sheet2$] (name,gender,mobile,dept,email,category)values('" + name + "','" + gender + "','" + mobile + "','" + Dept + "', '" + email + "','" + Category + "')";
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void Admission1_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main ss = new main();
            this.Hide();
            ss.Show();

        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            txtfullname.Clear();
            radioButtonmale.Checked = false;
            radioButtonmale.Checked = false;
            txtmobile.Clear();
            txtdept.ResetText();
            txtemail.Clear();
            txtcategory.ResetText();
            MessageBox.Show("Done", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }
    }
    }


        
    
