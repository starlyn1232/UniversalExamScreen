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
    public partial class ResultViewer : Form
    {
        //CQuestion variable to process the selected row from the main app

        internal CQuestion question = new CQuestion();

        public ResultViewer()
        {
            InitializeComponent();
        }

        private void ResultViewer_Load(object sender, EventArgs e)
        {
            //Static Size

            MinimumSize = Size;
            MaximumSize = Size;

            //Let's charge the info to the UI

            rbInfo.Text = question.Information;
            txtSelected.Text = (question.Selected == -1) ? "Skipped." : question.Options[question.Selected];
            txtCoorrect.Text = question.Options[question.Correct];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
