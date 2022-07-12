using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace UniversalExamScreen
{
    public partial class Exam : Form
    {
        //Disable Serialization warning :)

#pragma warning disable SYSLIB0011 // Type or member is obsolete

        //Local value for the exam information

        internal CExam exam = new CExam("exam");

        //Counter

        private int currentQuestion = 0;

        //App Path

        private string appPath = Directory.GetCurrentDirectory();

        //Exit confirmation variable

        private bool ExitAsk = true;

        //Change the tab only if we granted it

        private bool tabChange = false;

        //Entry Event

        public Exam()
        {
            InitializeComponent();
        }

        //Path creator

        private bool PathCreator(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                return true;
            }

            catch
            {
                return false;
            }
        }

        //Exit Event (For fatal errors)

        private void ErrorAndExit(string txt)
        {
            ExitAsk = false;
            MessageBox.Show(txt,"Universal Exam Screen - Fatal Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        //Load Event

        private void Exam_Load(object sender, EventArgs e)
        {
            //Check working path

            if (!PathCreator(String.Format("{0}\\Exams\\", appPath)))
                ErrorAndExit("Exam folder couldn't be found!");

            //Static Size

            MinimumSize = new Size(700,500);
            MaximumSize = Size;

            //Let's prepare some exam information

            //Charge Exam info to UI

            ChargeExam(ref exam);

            //Charge questions

            ChargeQuestion(false, false);

            //Title

            Text = String.Format("{0} By Starlyn1232 (v{1}) - Current Teacher: {2} - Current Exam: {3}", 
                Text, ProductVersion,exam.TeacherName,exam.ExamType);
        }

        //Closing Question

        private void Exam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitAsk && MessageBox.Show("Are you sure?", "Universal Exam Screen Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                e.Cancel = true;
        }

        //Exit Button

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Charge Exam Info

        private void ChargeExam(ref CExam exam)
        {
            //TextBoxes info

            txtExamTeacher.Text = exam.TeacherName;
            txtExamType.Text = exam.ExamType;
            txtExamCreation.Text = exam.CreationDate;
            txtExamQ.Text = exam.Questions.Count.ToString();

            //Set entry value

            currentQuestion = 0;

            //Question and options

            rbExamInfo.Text = exam.Questions[0].Information;
        }

        //Charge Question Event

        private void ChargeQuestion(bool Skip, bool increase)
        {
            bool finalMsg = false;

            //We charge info only if there is some question to charge

            if (!Skip)
            {
                //Save selected option

                int selected = (radiBut1.Checked) ? 0 : (radiBut2.Checked) ? 1 :
                     (radiBut3.Checked) ? 2 : 3;

                exam.Questions[currentQuestion].Selected = selected;
            }

            else
                exam.Questions[currentQuestion].Selected = -1;

            //MessageBox.Show(String.Format("Current question: {0}" +
            //    "\n\nCorrect: {1}\nSelected: {2}", exam.Questions[currentQuestion].Information,
            //    exam.Questions[currentQuestion].Correct,
            //    exam.Questions[currentQuestion].Selected));

            //Set new current question

            if (increase)
            {
                if (currentQuestion + 1 < exam.Questions.Count)
                    ++currentQuestion;

                else
                    finalMsg = true;
            }

            //Prepare information

            rbExamInfo.Text = exam.Questions[currentQuestion].Information;

            //Prepare options

            radiBut1.Text = exam.Questions[currentQuestion].Options[0];
            radiBut2.Text = exam.Questions[currentQuestion].Options[1];
            radiBut3.Text = exam.Questions[currentQuestion].Options[2];
            radiBut4.Text = exam.Questions[currentQuestion].Options[3];

            //Default option

            radiBut1.Checked = true;

            //Question index

            txtExamQ.Text = String.Format("Question: {0}/{1}", currentQuestion + 1, exam.Questions.Count);

            //Verify if it was the last question/exercise

            if (finalMsg)
            {
                MessageBox.Show("It was the last question/exercise!\n\nNow go to result to process your exam.",
                    "Universal Exam Screen", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Disable UI

                UIManager(UIMode.disabled);
            }
        }

        //Prepare options

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radiBut1.Checked)
            {
                radiBut2.Checked = false;
                radiBut3.Checked = false;
                radiBut4.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radiBut4.Checked)
            {
                radiBut2.Checked = false;
                radiBut3.Checked = false;
                radiBut1.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radiBut3.Checked)
            {
                radiBut2.Checked = false;
                radiBut1.Checked = false;
                radiBut4.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radiBut2.Checked)
            {
                radiBut1.Checked = false;
                radiBut3.Checked = false;
                radiBut4.Checked = false;
            }
        }

        //Skip question

        private void button4_Click(object sender, EventArgs e)
        {
            //exam function for now

            ChargeQuestion(true,true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exam function for now

            ChargeQuestion(false,true);
        }

        //UI Manager

        private enum UIMode
        {
            disabled,enabled
        }

        //Calification Color

        private void GradeInfo(char grade, Color color)
        {
            label2.Text = grade.ToString();
            label2.ForeColor = color;
        }

        //Calculate result

        private void ExamResult()
        {
            //Show exam details

            //Type cast use

            string pointStr = ((double)100 / exam.Questions.Count).ToString();

            pointStr = (pointStr.Contains(".")) ? pointStr.Substring(0, pointStr.IndexOf(".")+2) : pointStr;

            textBox8.Text = exam.TeacherName;
            textBox6.Text = exam.ExamType;
            textBox7.Text = exam.CreationDate;
            textBox5.Text = String.Format("Qnt: {0} ( {1} points each one )",exam.Questions.Count, pointStr);

            //Clear old results

            dataGridView1.Rows.Clear();

            //Check correct questions/exercises

            int success = 0;
            int failed = 0;
            int count = 0;
            int row = 0;

            foreach(CQuestion question in exam.Questions)
            {
                if (question.Selected == question.Correct)
                    success++;

                else
                    failed++;

                count++;

                //Questions/Exercises list

                var values = new object[4];

                values[0] = row+1;
                values[1] = (question.Selected == -1) ? "Skipped" : question.Options[question.Selected];
                values[2] = question.Options[question.Correct];
                values[3] = (question.Selected == question.Correct) ? "Passed" : "Failed";

                dataGridView1.Rows.Add(values);

                //Row colors

                row++;
            }

            textBox9.Text = String.Format("{0}/{1}",failed,count);
            textBox10.Text = String.Format("{0}/{1}", success, count);

            //Show grade letter and points

            double points = 0.0;
            string points2 = "";

            for (double i=((double)100 / count);success > 0; success--)
                points += i;

            points2 = points.ToString();

            points2 = (points2.Contains(".")) ? points2.Substring(0, points2.IndexOf(".") + 2) : points2;

            label1.Text = String.Format("{0}/100 Points.", points2);

            if (points > 90)
                GradeInfo('A', Color.LightSeaGreen);

            else if (points <= 64)
                GradeInfo('F', Color.Red);

            else if (points > 64 && points <= 70)
                GradeInfo('D', Color.Yellow);

            else if(points > 70 && points <= 79)
                GradeInfo('C', Color.OrangeRed);

            else if (points > 79 && points <= 89)
                GradeInfo('B', Color.Blue);

            //Change to Result's tab

            tabChanger(1);
        }

        private void UIManager(UIMode mode)
        {
            //Set flag

            bool state = (mode == UIMode.enabled) ? true : false;

            //Disable Options

            radiBut1.Enabled = state;
            radiBut2.Enabled = state;
            radiBut3.Enabled = state;
            radiBut4.Enabled = state;

            //Disable Btns

            btnExamAnswer.Enabled = state;
            btnExamSkip.Enabled = state;

            //Prepare Result Area

            btnResult.Enabled = !state;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process Exam

            ExamResult();
        }

        //Result viewer, this occurs when the user clicks the question/exercise

        private void ResultView(CQuestion question)
        {
            ResultViewer view = new ResultViewer();
            view.question = question;
            view.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //We're only interested on the first column event :) (The button)

            if (e.ColumnIndex != 0 || e.RowIndex > currentQuestion)
                return;

            //Prepare question/exercise info to send

            CQuestion temp = new CQuestion();

            temp.Information = exam.Questions[e.RowIndex].Information;
            temp.Selected = exam.Questions[e.RowIndex].Selected;
            temp.Correct = exam.Questions[e.RowIndex].Correct;
            temp.Options = exam.Questions[e.RowIndex].Options;

            //Call form

            ResultView(temp);
        }

        //Tab Manager

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!tabChange)
                e.Cancel = true;
        }

        private void tabChanger(int tab)
        {
            tabChange = true;
            tabMain.SelectedIndex = tab;
            tabChange = false;
        }

        //Result color details

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //General color change

            e.CellStyle.BackColor = (e.RowIndex % 2 == 0) ? SystemColors.Control : SystemColors.ControlDark;

            //State Color

            if (e.ColumnIndex == 3)
            {
                if ((string)e.Value == "Passed")
                    e.CellStyle.BackColor = Color.LightGreen;

                else if ((string)e.Value == "Failed")
                    e.CellStyle.BackColor = Color.Red;
            }
        }
    }
}