using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMgmtSys1
{
    public partial class notice : Form
    {
        public notice()
        {
            InitializeComponent();
        }

        private void notice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main ss = new main();
            this.Hide();
            ss.Show();

        }
    }
}
