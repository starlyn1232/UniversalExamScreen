using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalExamScreen
{
    public partial class TeacherMode : Form
    {
        //Local exam obj

        private CExam exam = null;

        public TeacherMode()
        {
            InitializeComponent();
        }

        private void TeacherMode_Load(object sender, EventArgs e)
        {
            //Static Size

            MinimumSize = Size;
            MaximumSize = Size;
        }

        //UI Manager

        private enum UIMode
        {
            enabled, disabled
        }

        private void UIManager(UIMode mode)
        {
            bool state = (mode == UIMode.enabled) ? true : false;

            btnCreate.Enabled = state;
            btnLoad.Enabled = state;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Here we disable the UI, hide the Menu and open the creator mode
            //Why to disable the UI even if the menu is hiden?
            //Because student (as my brother Oscary) could find the way to
            //Open the Menu and try to create a bug for his benefit :)

            UIManager(UIMode.disabled);
            Hide();
            CreatorMode creator = new CreatorMode();
            creator.ShowDialog();

            //Enable UI and show back the Menu after closing the Creator mode

            UIManager(UIMode.enabled);
            Show();
        }

        //Decrypt and Load Exam

        private bool ExamDecrypt(string examPath, string decryptKey)
        {
            FileStream file = null;

            try
            {
                //Decrypt exam

                EncryptManager.DecryptFile(examPath, decryptKey);

                string tempFile = @"C:\ProgramData\"
                    + examPath.Substring(examPath.LastIndexOf("\\") + 1);

                //Load exam

                exam = new CExam("Starlyn1232");

                //Use temporal file (Decrypted)

                BinaryFormatter formatter = new BinaryFormatter();
                file = new FileStream(tempFile, FileMode.Open, FileAccess.Read);
                exam = (CExam)formatter.Deserialize(file);
                file.Close();

                //Erase decrypt data

                if (File.Exists(tempFile))
                    File.Delete(tempFile);

                return true;
            }

            catch (Exception ex)
            {
                Utils.MsgDebug("Deserialization failed: \n\n" + ex.Message);
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

        //Exam loader

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Here we'll work with the Exam's Form directly, let's code it

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Universal Exam Screen Files (*UES)|*.UES";
            file.FileName = "exam.UES";
            file.Title = "Universal Exam Screen - Exam Finder.";

            if (file.ShowDialog() == DialogResult.OK)
            {
                //Confirm password

                string password = "";

                PasswordGranter pass = new PasswordGranter();
                pass.txtFile.Text = file.FileName;

                UIManager(UIMode.disabled);

                pass.ShowDialog();
                password = pass.txtPass.Text;

                UIManager(UIMode.enabled);

                if (!pass.granted)
                    return;

                if (!ExamDecrypt(file.FileName, password))
                {
                    Utils.MsgError("Exam file can't be loaded!" +
                        "\n\nPlease contact the developer if the problem persists.", Utils.MsgBtn.Ok);
                    return;
                }

                //Charge the exam form

                UIManager(UIMode.disabled);
                Hide();
                Exam examScreen = new Exam();

                //Sync exam information and load it

                examScreen.exam = exam;

                examScreen.ShowDialog();

                //Enable UI and show back the Menu after closing the Creator mode

                UIManager(UIMode.enabled);
                Show();
            }
        }

        //Closing event

        private void TeacherMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Utils.MsgQuestion("Are you sure?", Utils.MsgBtn.YesNo) != DialogResult.Yes)
                e.Cancel = true;
        }

        //Exit button

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
