using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalExamScreen
{
    public partial class CreatorMode : Form
    {
        //Our local exam object to prepare and save the information

        internal CExam exam = new CExam("Starlyn1232");

        public CreatorMode()
        {
            InitializeComponent();
        }

        private void CreatorMode_Load(object sender, EventArgs e)
        {
            //Static Size

            MinimumSize = Size;
            MaximumSize = Size;

            //Fill the correct answer comboBox

            cbCorrectAnswer.Items.AddRange(new string[] 
            { 
                "Option 1" ,
                "Option 2" ,
                "Option 3" ,
                "Option 4" ,
            }
            );

            //Default option

            cbCorrectAnswer.SelectedIndex = 0;

            //Initialize counter

            QuestionCounter();
        }

        //Timer field enabler

        private void checkUserTimer_CheckedChanged(object sender, EventArgs e)
        {
            txtTimer.Enabled = checkUserTimer.Checked;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Fields cleaner

        private void ClearFields(bool ask, bool entryInfo, bool flushQuestions)
        {
            //Ask only when we need to
            
            if (ask && Utils.MsgQuestion("Are you sure?", Utils.MsgBtn.YesNo) != DialogResult.Yes)
                return;

            //Options

            txtOpt1.Clear();
            txtOpt2.Clear();
            txtOpt3.Clear();
            txtOpt4.Clear();
            rbInfo.Clear();

            //Entry info

            if (entryInfo)
            {
                txtTeacher.Clear();
                txtExamType.Clear();
                txtExamPass.Clear();
            }

            if (flushQuestions)
            {
                exam = new CExam("Starlyn1232");

                QuestionCounter();
            }

            //Correct Answer

            cbCorrectAnswer.SelectedIndex = 0;

            checkUserTimer.Checked = false;
        }

        private void txtTimer_EnabledChanged(object sender, EventArgs e)
        {
            //Let's clear the field when it's disabled

            if (!txtTimer.Enabled)
                txtTimer.Clear();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields(true,true,false);
        }

        //Current question quantity checker

        private void QuestionCounter()
        {
            txtQuestionQnt.Text = String.Format("{0} questions.", exam.Questions.Count);

            btnExamErase.Enabled = exam.Questions.Count > 0;

            //We enable the "Save Exam" button only when there is at least 1 question

            OptionsEnabler();
        }

        //Question saver

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            //First save the question

            //Entry info

            exam.TeacherName = txtTeacher.Text;
            exam.ExamType = txtExamType.Text;
            exam.ExamAccessKey = txtExamPass.Text;

            //Question/Exercise info

            exam.Questions.Add(new CQuestion
                (

                //Description

                rbInfo.Text,

                //Possible answers

                new string[] 
                {
                    txtOpt1.Text,
                    txtOpt2.Text,
                    txtOpt3.Text,
                    txtOpt4.Text,
                },

                //Correct answer

                cbCorrectAnswer.SelectedIndex

                ));

            //Clear fields

            ClearFields(false,false,false);

            //Now count the current quantity

            QuestionCounter();
        }

        //Option enabler

        private void OptionsEnabler()
        {
            bool state = (txtTeacher.TextLength >= 6 && txtExamType.TextLength >= 1 &&
                txtExamPass.TextLength >= 8);

            txtOpt1.Enabled = state;
            txtOpt2.Enabled = state;
            txtOpt3.Enabled = state;
            txtOpt4.Enabled = state;

            if(state && exam.Questions.Count > 0)
                    btnSaveExam.Enabled = true;
        }

        private void dataCheck_TextChanged(object sender, EventArgs e)
        {
            OptionsEnabler();
        }

        //Operations enabler

        private void OperationsEnabler()
        {
            bool state = (txtOpt1.TextLength > 0 && txtOpt2.TextLength > 0 &&
                txtOpt3.TextLength > 0 && txtOpt4.TextLength > 0 && 
                rbInfo.TextLength >= 6);

            btnAddQuestion.Enabled = state;
        }

        private void dataCheck2_TextChanged(object sender, EventArgs e)
        {
            OperationsEnabler();
        }

        //Save and Encrypt Exam Data

        private bool ExamEncrypt(string examPath, string encryptKey)
        {
            FileStream file = null;

            try
            {
                //Save date

                exam.CreationDate = DateTime.Now.ToString("G");

                BinaryFormatter formatter = new BinaryFormatter();
                file = new FileStream(examPath, FileMode.OpenOrCreate, FileAccess.Write);
                formatter.Serialize(file, exam);
                file.Close();

                //Encrypt

                GCHandle gCHandle = GCHandle.Alloc(encryptKey, GCHandleType.Pinned);
                EncryptManager.EncryptFile(examPath, encryptKey);
                EncryptManager.ZeroMemory(gCHandle.AddrOfPinnedObject(), encryptKey.Length * 2);
                gCHandle.Free();

                return true;
            }

            catch (Exception ex)
            {
                Utils.MsgDebug("Serialization failed: \n\n" + ex.Message);
            }

            finally
            {
                try
                {
                    file.Close();
                }

                catch
                {

                }
            }

            return false;
        }

        //Exam saver

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            //Let's use a file saver

            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Universal Exam Screen files (*UES)|*.UES";
            file.Title = "Universal Exam Screen - Exam Saver.";
            file.FileName = "*.UES";

            if(file.ShowDialog() == DialogResult.OK)
            {
                //Confirm the process

                if (!ExamEncrypt(file.FileName, txtExamPass.Text))
                {
                    Utils.MsgError("Exam file processing failed!\n\nPlease contact the developer.", Utils.MsgBtn.Ok);
                    return;
                }

                //Last pop-up

                ClearFields(false, true, true);

                Utils.MsgInfo("Exam information saved!", Utils.MsgBtn.Ok);
            }
        }

        //Exam restarter

        private void btnExamErase_Click(object sender, EventArgs e)
        {
            if (Utils.MsgQuestion("Are you sure?", Utils.MsgBtn.YesNo) != DialogResult.Yes)
                return;

            ClearFields(false, true,true);
        }
    }
}
