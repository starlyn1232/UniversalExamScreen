namespace UniversalExamScreen
{
    partial class CreatorMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatorMode));
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.gbExamPass = new System.Windows.Forms.GroupBox();
            this.txtExamPass = new System.Windows.Forms.TextBox();
            this.gbQuestionQnt = new System.Windows.Forms.GroupBox();
            this.txtQuestionQnt = new System.Windows.Forms.TextBox();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbExtraOptions = new System.Windows.Forms.GroupBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.gbTimer = new System.Windows.Forms.GroupBox();
            this.checkUserTimer = new System.Windows.Forms.CheckBox();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.btnSaveExam = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.gbCorrectAnswer = new System.Windows.Forms.GroupBox();
            this.cbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtOpt4 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtOpt3 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtOpt2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtOpt1 = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.rbInfo = new System.Windows.Forms.RichTextBox();
            this.gbExamType = new System.Windows.Forms.GroupBox();
            this.txtExamType = new System.Windows.Forms.TextBox();
            this.gbTeacher = new System.Windows.Forms.GroupBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.btnExamErase = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.gbExamPass.SuspendLayout();
            this.gbQuestionQnt.SuspendLayout();
            this.gbOperations.SuspendLayout();
            this.gbExtraOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.gbTimer.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbCorrectAnswer.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbExamType.SuspendLayout();
            this.gbTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.gbExamPass);
            this.gbMain.Controls.Add(this.gbQuestionQnt);
            this.gbMain.Controls.Add(this.gbOperations);
            this.gbMain.Controls.Add(this.gbOptions);
            this.gbMain.Controls.Add(this.gbInfo);
            this.gbMain.Controls.Add(this.gbExamType);
            this.gbMain.Controls.Add(this.gbTeacher);
            this.gbMain.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(758, 477);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Creator Mode: ";
            // 
            // gbExamPass
            // 
            this.gbExamPass.Controls.Add(this.txtExamPass);
            this.gbExamPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbExamPass.Location = new System.Drawing.Point(153, 152);
            this.gbExamPass.Name = "gbExamPass";
            this.gbExamPass.Size = new System.Drawing.Size(152, 59);
            this.gbExamPass.TabIndex = 4;
            this.gbExamPass.TabStop = false;
            this.gbExamPass.Text = "Exam Password: ";
            // 
            // txtExamPass
            // 
            this.txtExamPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtExamPass.Location = new System.Drawing.Point(6, 22);
            this.txtExamPass.Name = "txtExamPass";
            this.txtExamPass.Size = new System.Drawing.Size(140, 25);
            this.txtExamPass.TabIndex = 2;
            this.txtExamPass.TextChanged += new System.EventHandler(this.dataCheck_TextChanged);
            // 
            // gbQuestionQnt
            // 
            this.gbQuestionQnt.Controls.Add(this.txtQuestionQnt);
            this.gbQuestionQnt.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbQuestionQnt.Location = new System.Drawing.Point(6, 152);
            this.gbQuestionQnt.Name = "gbQuestionQnt";
            this.gbQuestionQnt.Size = new System.Drawing.Size(141, 59);
            this.gbQuestionQnt.TabIndex = 3;
            this.gbQuestionQnt.TabStop = false;
            this.gbQuestionQnt.Text = "Question quantity: ";
            // 
            // txtQuestionQnt
            // 
            this.txtQuestionQnt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQuestionQnt.Location = new System.Drawing.Point(6, 22);
            this.txtQuestionQnt.Name = "txtQuestionQnt";
            this.txtQuestionQnt.ReadOnly = true;
            this.txtQuestionQnt.Size = new System.Drawing.Size(127, 25);
            this.txtQuestionQnt.TabIndex = 0;
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.btnExamErase);
            this.gbOperations.Controls.Add(this.btnBack);
            this.gbOperations.Controls.Add(this.gbExtraOptions);
            this.gbOperations.Controls.Add(this.btnSaveExam);
            this.gbOperations.Controls.Add(this.btnClearFields);
            this.gbOperations.Controls.Add(this.btnAddQuestion);
            this.gbOperations.Location = new System.Drawing.Point(6, 338);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(746, 133);
            this.gbOperations.TabIndex = 5;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations: ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBack.Location = new System.Drawing.Point(302, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 57);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbExtraOptions
            // 
            this.gbExtraOptions.Controls.Add(this.picMain);
            this.gbExtraOptions.Controls.Add(this.gbTimer);
            this.gbExtraOptions.Location = new System.Drawing.Point(402, 16);
            this.gbExtraOptions.Name = "gbExtraOptions";
            this.gbExtraOptions.Size = new System.Drawing.Size(338, 111);
            this.gbExtraOptions.TabIndex = 3;
            this.gbExtraOptions.TabStop = false;
            this.gbExtraOptions.Text = "Extra Options: ";
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(234, 19);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(96, 86);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 2;
            this.picMain.TabStop = false;
            // 
            // gbTimer
            // 
            this.gbTimer.Controls.Add(this.checkUserTimer);
            this.gbTimer.Controls.Add(this.txtTimer);
            this.gbTimer.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbTimer.Location = new System.Drawing.Point(6, 31);
            this.gbTimer.Name = "gbTimer";
            this.gbTimer.Size = new System.Drawing.Size(222, 62);
            this.gbTimer.TabIndex = 1;
            this.gbTimer.TabStop = false;
            this.gbTimer.Text = "Timer: ";
            // 
            // checkUserTimer
            // 
            this.checkUserTimer.AutoSize = true;
            this.checkUserTimer.Location = new System.Drawing.Point(101, 25);
            this.checkUserTimer.Name = "checkUserTimer";
            this.checkUserTimer.Size = new System.Drawing.Size(93, 22);
            this.checkUserTimer.TabIndex = 1;
            this.checkUserTimer.Text = "User Timer";
            this.checkUserTimer.UseVisualStyleBackColor = true;
            this.checkUserTimer.CheckedChanged += new System.EventHandler(this.checkUserTimer_CheckedChanged);
            // 
            // txtTimer
            // 
            this.txtTimer.Enabled = false;
            this.txtTimer.Location = new System.Drawing.Point(6, 24);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(79, 25);
            this.txtTimer.TabIndex = 0;
            this.txtTimer.EnabledChanged += new System.EventHandler(this.txtTimer_EnabledChanged);
            // 
            // btnSaveExam
            // 
            this.btnSaveExam.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveExam.Enabled = false;
            this.btnSaveExam.Location = new System.Drawing.Point(206, 26);
            this.btnSaveExam.Name = "btnSaveExam";
            this.btnSaveExam.Size = new System.Drawing.Size(94, 57);
            this.btnSaveExam.TabIndex = 2;
            this.btnSaveExam.Text = "Save Exam";
            this.btnSaveExam.UseVisualStyleBackColor = false;
            this.btnSaveExam.Click += new System.EventHandler(this.btnSaveExam_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.Linen;
            this.btnClearFields.Location = new System.Drawing.Point(106, 26);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(94, 57);
            this.btnClearFields.TabIndex = 1;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddQuestion.Enabled = false;
            this.btnAddQuestion.Location = new System.Drawing.Point(6, 26);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(94, 57);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Add question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.gbCorrectAnswer);
            this.gbOptions.Controls.Add(this.groupBox10);
            this.gbOptions.Controls.Add(this.groupBox9);
            this.gbOptions.Controls.Add(this.groupBox8);
            this.gbOptions.Controls.Add(this.groupBox7);
            this.gbOptions.Location = new System.Drawing.Point(6, 217);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(746, 115);
            this.gbOptions.TabIndex = 4;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options: ";
            // 
            // gbCorrectAnswer
            // 
            this.gbCorrectAnswer.Controls.Add(this.cbCorrectAnswer);
            this.gbCorrectAnswer.Location = new System.Drawing.Point(638, 16);
            this.gbCorrectAnswer.Name = "gbCorrectAnswer";
            this.gbCorrectAnswer.Size = new System.Drawing.Size(102, 93);
            this.gbCorrectAnswer.TabIndex = 5;
            this.gbCorrectAnswer.TabStop = false;
            this.gbCorrectAnswer.Text = "Correct: ";
            // 
            // cbCorrectAnswer
            // 
            this.cbCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorrectAnswer.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCorrectAnswer.FormattingEnabled = true;
            this.cbCorrectAnswer.Location = new System.Drawing.Point(6, 47);
            this.cbCorrectAnswer.Name = "cbCorrectAnswer";
            this.cbCorrectAnswer.Size = new System.Drawing.Size(90, 24);
            this.cbCorrectAnswer.TabIndex = 7;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtOpt4);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox10.Location = new System.Drawing.Point(480, 26);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(152, 74);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Option #4: ";
            // 
            // txtOpt4
            // 
            this.txtOpt4.Enabled = false;
            this.txtOpt4.Location = new System.Drawing.Point(10, 36);
            this.txtOpt4.Name = "txtOpt4";
            this.txtOpt4.Size = new System.Drawing.Size(136, 25);
            this.txtOpt4.TabIndex = 6;
            this.txtOpt4.TextChanged += new System.EventHandler(this.dataCheck2_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtOpt3);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox9.Location = new System.Drawing.Point(322, 26);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(152, 74);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Option #3: ";
            // 
            // txtOpt3
            // 
            this.txtOpt3.Enabled = false;
            this.txtOpt3.Location = new System.Drawing.Point(10, 36);
            this.txtOpt3.Name = "txtOpt3";
            this.txtOpt3.Size = new System.Drawing.Size(136, 25);
            this.txtOpt3.TabIndex = 5;
            this.txtOpt3.TextChanged += new System.EventHandler(this.dataCheck2_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtOpt2);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox8.Location = new System.Drawing.Point(164, 26);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(152, 74);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Option #2: ";
            // 
            // txtOpt2
            // 
            this.txtOpt2.Enabled = false;
            this.txtOpt2.Location = new System.Drawing.Point(10, 36);
            this.txtOpt2.Name = "txtOpt2";
            this.txtOpt2.Size = new System.Drawing.Size(136, 25);
            this.txtOpt2.TabIndex = 4;
            this.txtOpt2.TextChanged += new System.EventHandler(this.dataCheck2_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtOpt1);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(6, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(152, 74);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Option #1: ";
            // 
            // txtOpt1
            // 
            this.txtOpt1.Enabled = false;
            this.txtOpt1.Location = new System.Drawing.Point(10, 36);
            this.txtOpt1.Name = "txtOpt1";
            this.txtOpt1.Size = new System.Drawing.Size(136, 25);
            this.txtOpt1.TabIndex = 3;
            this.txtOpt1.TextChanged += new System.EventHandler(this.dataCheck2_TextChanged);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.rbInfo);
            this.gbInfo.Location = new System.Drawing.Point(311, 22);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(441, 189);
            this.gbInfo.TabIndex = 3;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information: ";
            // 
            // rbInfo
            // 
            this.rbInfo.Location = new System.Drawing.Point(6, 22);
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.Size = new System.Drawing.Size(429, 151);
            this.rbInfo.TabIndex = 0;
            this.rbInfo.Text = "";
            this.rbInfo.TextChanged += new System.EventHandler(this.dataCheck2_TextChanged);
            // 
            // gbExamType
            // 
            this.gbExamType.Controls.Add(this.txtExamType);
            this.gbExamType.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbExamType.Location = new System.Drawing.Point(6, 87);
            this.gbExamType.Name = "gbExamType";
            this.gbExamType.Size = new System.Drawing.Size(299, 59);
            this.gbExamType.TabIndex = 1;
            this.gbExamType.TabStop = false;
            this.gbExamType.Text = "Exam\'s Type: ";
            // 
            // txtExamType
            // 
            this.txtExamType.Location = new System.Drawing.Point(6, 22);
            this.txtExamType.Name = "txtExamType";
            this.txtExamType.Size = new System.Drawing.Size(287, 25);
            this.txtExamType.TabIndex = 1;
            this.txtExamType.TextChanged += new System.EventHandler(this.dataCheck_TextChanged);
            // 
            // gbTeacher
            // 
            this.gbTeacher.Controls.Add(this.txtTeacher);
            this.gbTeacher.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbTeacher.Location = new System.Drawing.Point(6, 22);
            this.gbTeacher.Name = "gbTeacher";
            this.gbTeacher.Size = new System.Drawing.Size(299, 59);
            this.gbTeacher.TabIndex = 0;
            this.gbTeacher.TabStop = false;
            this.gbTeacher.Text = "Teacher\'s Name: ";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(6, 22);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(287, 25);
            this.txtTeacher.TabIndex = 0;
            this.txtTeacher.TextChanged += new System.EventHandler(this.dataCheck_TextChanged);
            // 
            // btnExamErase
            // 
            this.btnExamErase.BackColor = System.Drawing.Color.IndianRed;
            this.btnExamErase.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExamErase.Location = new System.Drawing.Point(6, 89);
            this.btnExamErase.Name = "btnExamErase";
            this.btnExamErase.Size = new System.Drawing.Size(94, 38);
            this.btnExamErase.TabIndex = 5;
            this.btnExamErase.Text = "Erase Exam";
            this.btnExamErase.UseVisualStyleBackColor = false;
            this.btnExamErase.Click += new System.EventHandler(this.btnExamErase_Click);
            // 
            // CreatorMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 501);
            this.Controls.Add(this.gbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatorMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal Exam Screen - Exam Creator Mode";
            this.Load += new System.EventHandler(this.CreatorMode_Load);
            this.gbMain.ResumeLayout(false);
            this.gbExamPass.ResumeLayout(false);
            this.gbExamPass.PerformLayout();
            this.gbQuestionQnt.ResumeLayout(false);
            this.gbQuestionQnt.PerformLayout();
            this.gbOperations.ResumeLayout(false);
            this.gbExtraOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.gbTimer.ResumeLayout(false);
            this.gbTimer.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbCorrectAnswer.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbExamType.ResumeLayout(false);
            this.gbExamType.PerformLayout();
            this.gbTeacher.ResumeLayout(false);
            this.gbTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbMain;
        private GroupBox gbTeacher;
        private TextBox txtTeacher;
        private GroupBox gbOperations;
        private Button btnAddQuestion;
        private GroupBox gbOptions;
        private GroupBox gbCorrectAnswer;
        private ComboBox cbCorrectAnswer;
        private GroupBox groupBox10;
        private TextBox txtOpt4;
        private GroupBox groupBox9;
        private TextBox txtOpt3;
        private GroupBox groupBox8;
        private TextBox txtOpt2;
        private GroupBox groupBox7;
        private TextBox txtOpt1;
        private GroupBox gbInfo;
        private RichTextBox rbInfo;
        private GroupBox gbExamType;
        private TextBox txtExamType;
        private Button btnClearFields;
        private GroupBox gbExamPass;
        private TextBox txtExamPass;
        private GroupBox gbQuestionQnt;
        private TextBox txtQuestionQnt;
        private Button btnSaveExam;
        private GroupBox gbExtraOptions;
        private GroupBox gbTimer;
        private CheckBox checkUserTimer;
        private TextBox txtTimer;
        private PictureBox picMain;
        private Button btnBack;
        private Button btnExamErase;
    }
}