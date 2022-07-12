using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalExamScreen
{
    public partial class PasswordGranter : Form
    {
        //Info flag

        internal bool granted = false;

        public PasswordGranter()
        {
            InitializeComponent();
        }

        private void PasswordGranter_Load(object sender, EventArgs e)
        {
            //Static size

            MinimumSize = Size;
            MaximumSize = Size;

            //Filter exam's file name

            txtFile.Text = txtFile.Text.Substring(txtFile.Text.LastIndexOf("\\") + 1);
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            granted = true;
            Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            btnGrant.Enabled = txtPass.TextLength >= 8;
        }
    }
}
