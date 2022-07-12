namespace UniversalExamScreen
{
    partial class Exam
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbExam = new System.Windows.Forms.GroupBox();
            this.gbExamInfo = new System.Windows.Forms.GroupBox();
            this.gbExamOperations = new System.Windows.Forms.GroupBox();
            this.btnExamSkip = new System.Windows.Forms.Button();
            this.btnExamAnswer = new System.Windows.Forms.Button();
            this.gbExamOptions = new System.Windows.Forms.GroupBox();
            this.radiBut2 = new System.Windows.Forms.RadioButton();
            this.radiBut3 = new System.Windows.Forms.RadioButton();
            this.radiBut4 = new System.Windows.Forms.RadioButton();
            this.radiBut1 = new System.Windows.Forms.RadioButton();
            this.rbExamInfo = new System.Windows.Forms.RichTextBox();
            this.gbExamDetails = new System.Windows.Forms.GroupBox();
            this.gbExamQInfo = new System.Windows.Forms.GroupBox();
            this.txtExamQ = new System.Windows.Forms.TextBox();
            this.gbExamType = new System.Windows.Forms.GroupBox();
            this.txtExamType = new System.Windows.Forms.TextBox();
            this.gbExamCreation = new System.Windows.Forms.GroupBox();
            this.txtExamCreation = new System.Windows.Forms.TextBox();
            this.gbExamTeacher = new System.Windows.Forms.GroupBox();
            this.txtExamTeacher = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.gbPic = new System.Windows.Forms.GroupBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbExam.SuspendLayout();
            this.gbExamInfo.SuspendLayout();
            this.gbExamOperations.SuspendLayout();
            this.gbExamOptions.SuspendLayout();
            this.gbExamDetails.SuspendLayout();
            this.gbExamQInfo.SuspendLayout();
            this.gbExamType.SuspendLayout();
            this.gbExamCreation.SuspendLayout();
            this.gbExamTeacher.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.gbPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.gbPic);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 553);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Location = new System.Drawing.Point(0, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 76);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResult.Enabled = false;
            this.btnResult.Location = new System.Drawing.Point(0, 0);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(200, 76);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(200, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(738, 553);
            this.tabMain.TabIndex = 1;
            this.tabMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbExam);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exam";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbExam
            // 
            this.gbExam.Controls.Add(this.gbExamInfo);
            this.gbExam.Controls.Add(this.gbExamDetails);
            this.gbExam.Location = new System.Drawing.Point(6, 6);
            this.gbExam.Name = "gbExam";
            this.gbExam.Size = new System.Drawing.Size(716, 511);
            this.gbExam.TabIndex = 0;
            this.gbExam.TabStop = false;
            this.gbExam.Text = "Exam area: ";
            // 
            // gbExamInfo
            // 
            this.gbExamInfo.Controls.Add(this.gbExamOperations);
            this.gbExamInfo.Controls.Add(this.gbExamOptions);
            this.gbExamInfo.Controls.Add(this.rbExamInfo);
            this.gbExamInfo.Location = new System.Drawing.Point(6, 198);
            this.gbExamInfo.Name = "gbExamInfo";
            this.gbExamInfo.Size = new System.Drawing.Size(704, 307);
            this.gbExamInfo.TabIndex = 1;
            this.gbExamInfo.TabStop = false;
            this.gbExamInfo.Text = "Information: ";
            // 
            // gbExamOperations
            // 
            this.gbExamOperations.Controls.Add(this.btnExamSkip);
            this.gbExamOperations.Controls.Add(this.btnExamAnswer);
            this.gbExamOperations.Location = new System.Drawing.Point(512, 176);
            this.gbExamOperations.Name = "gbExamOperations";
            this.gbExamOperations.Size = new System.Drawing.Size(186, 125);
            this.gbExamOperations.TabIndex = 2;
            this.gbExamOperations.TabStop = false;
            this.gbExamOperations.Text = "Operations: ";
            // 
            // btnExamSkip
            // 
            this.btnExamSkip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExamSkip.Location = new System.Drawing.Point(27, 73);
            this.btnExamSkip.Name = "btnExamSkip";
            this.btnExamSkip.Size = new System.Drawing.Size(134, 23);
            this.btnExamSkip.TabIndex = 1;
            this.btnExamSkip.Text = "Skip Answer";
            this.btnExamSkip.UseVisualStyleBackColor = false;
            this.btnExamSkip.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExamAnswer
            // 
            this.btnExamAnswer.BackColor = System.Drawing.Color.Cornsilk;
            this.btnExamAnswer.Location = new System.Drawing.Point(27, 43);
            this.btnExamAnswer.Name = "btnExamAnswer";
            this.btnExamAnswer.Size = new System.Drawing.Size(134, 23);
            this.btnExamAnswer.TabIndex = 0;
            this.btnExamAnswer.Text = "Send Answer";
            this.btnExamAnswer.UseVisualStyleBackColor = false;
            this.btnExamAnswer.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbExamOptions
            // 
            this.gbExamOptions.Controls.Add(this.radiBut2);
            this.gbExamOptions.Controls.Add(this.radiBut3);
            this.gbExamOptions.Controls.Add(this.radiBut4);
            this.gbExamOptions.Controls.Add(this.radiBut1);
            this.gbExamOptions.Location = new System.Drawing.Point(6, 176);
            this.gbExamOptions.Name = "gbExamOptions";
            this.gbExamOptions.Size = new System.Drawing.Size(499, 125);
            this.gbExamOptions.TabIndex = 1;
            this.gbExamOptions.TabStop = false;
            this.gbExamOptions.Text = "Options: ";
            // 
            // radiBut2
            // 
            this.radiBut2.AutoSize = true;
            this.radiBut2.Location = new System.Drawing.Point(18, 47);
            this.radiBut2.Name = "radiBut2";
            this.radiBut2.Size = new System.Drawing.Size(71, 19);
            this.radiBut2.TabIndex = 3;
            this.radiBut2.TabStop = true;
            this.radiBut2.Text = "Option 2";
            this.radiBut2.UseVisualStyleBackColor = true;
            this.radiBut2.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radiBut3
            // 
            this.radiBut3.AutoSize = true;
            this.radiBut3.Location = new System.Drawing.Point(18, 73);
            this.radiBut3.Name = "radiBut3";
            this.radiBut3.Size = new System.Drawing.Size(71, 19);
            this.radiBut3.TabIndex = 2;
            this.radiBut3.TabStop = true;
            this.radiBut3.Text = "Option 3";
            this.radiBut3.UseVisualStyleBackColor = true;
            this.radiBut3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radiBut4
            // 
            this.radiBut4.AutoSize = true;
            this.radiBut4.Location = new System.Drawing.Point(18, 98);
            this.radiBut4.Name = "radiBut4";
            this.radiBut4.Size = new System.Drawing.Size(71, 19);
            this.radiBut4.TabIndex = 1;
            this.radiBut4.TabStop = true;
            this.radiBut4.Text = "Option 4";
            this.radiBut4.UseVisualStyleBackColor = true;
            this.radiBut4.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radiBut1
            // 
            this.radiBut1.AutoSize = true;
            this.radiBut1.Location = new System.Drawing.Point(18, 22);
            this.radiBut1.Name = "radiBut1";
            this.radiBut1.Size = new System.Drawing.Size(71, 19);
            this.radiBut1.TabIndex = 0;
            this.radiBut1.TabStop = true;
            this.radiBut1.Text = "Option 1";
            this.radiBut1.UseVisualStyleBackColor = true;
            this.radiBut1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbExamInfo
            // 
            this.rbExamInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbExamInfo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbExamInfo.Location = new System.Drawing.Point(6, 22);
            this.rbExamInfo.Name = "rbExamInfo";
            this.rbExamInfo.ReadOnly = true;
            this.rbExamInfo.Size = new System.Drawing.Size(692, 148);
            this.rbExamInfo.TabIndex = 0;
            this.rbExamInfo.Text = "Test text.";
            // 
            // gbExamDetails
            // 
            this.gbExamDetails.Controls.Add(this.gbExamQInfo);
            this.gbExamDetails.Controls.Add(this.gbExamType);
            this.gbExamDetails.Controls.Add(this.gbExamCreation);
            this.gbExamDetails.Controls.Add(this.gbExamTeacher);
            this.gbExamDetails.Location = new System.Drawing.Point(6, 22);
            this.gbExamDetails.Name = "gbExamDetails";
            this.gbExamDetails.Size = new System.Drawing.Size(704, 170);
            this.gbExamDetails.TabIndex = 0;
            this.gbExamDetails.TabStop = false;
            this.gbExamDetails.Text = "Details: ";
            // 
            // gbExamQInfo
            // 
            this.gbExamQInfo.Controls.Add(this.txtExamQ);
            this.gbExamQInfo.Location = new System.Drawing.Point(358, 91);
            this.gbExamQInfo.Name = "gbExamQInfo";
            this.gbExamQInfo.Size = new System.Drawing.Size(340, 63);
            this.gbExamQInfo.TabIndex = 3;
            this.gbExamQInfo.TabStop = false;
            this.gbExamQInfo.Text = "Current Question: ";
            // 
            // txtExamQ
            // 
            this.txtExamQ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtExamQ.Location = new System.Drawing.Point(6, 22);
            this.txtExamQ.Name = "txtExamQ";
            this.txtExamQ.ReadOnly = true;
            this.txtExamQ.Size = new System.Drawing.Size(328, 23);
            this.txtExamQ.TabIndex = 1;
            // 
            // gbExamType
            // 
            this.gbExamType.Controls.Add(this.txtExamType);
            this.gbExamType.Location = new System.Drawing.Point(6, 91);
            this.gbExamType.Name = "gbExamType";
            this.gbExamType.Size = new System.Drawing.Size(340, 63);
            this.gbExamType.TabIndex = 1;
            this.gbExamType.TabStop = false;
            this.gbExamType.Text = "Type: ";
            // 
            // txtExamType
            // 
            this.txtExamType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtExamType.Location = new System.Drawing.Point(6, 22);
            this.txtExamType.Name = "txtExamType";
            this.txtExamType.ReadOnly = true;
            this.txtExamType.Size = new System.Drawing.Size(328, 23);
            this.txtExamType.TabIndex = 1;
            // 
            // gbExamCreation
            // 
            this.gbExamCreation.Controls.Add(this.txtExamCreation);
            this.gbExamCreation.Location = new System.Drawing.Point(358, 22);
            this.gbExamCreation.Name = "gbExamCreation";
            this.gbExamCreation.Size = new System.Drawing.Size(340, 63);
            this.gbExamCreation.TabIndex = 2;
            this.gbExamCreation.TabStop = false;
            this.gbExamCreation.Text = "Creation Date: ";
            // 
            // txtExamCreation
            // 
            this.txtExamCreation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtExamCreation.Location = new System.Drawing.Point(6, 25);
            this.txtExamCreation.Name = "txtExamCreation";
            this.txtExamCreation.ReadOnly = true;
            this.txtExamCreation.Size = new System.Drawing.Size(328, 23);
            this.txtExamCreation.TabIndex = 1;
            // 
            // gbExamTeacher
            // 
            this.gbExamTeacher.Controls.Add(this.txtExamTeacher);
            this.gbExamTeacher.Location = new System.Drawing.Point(6, 22);
            this.gbExamTeacher.Name = "gbExamTeacher";
            this.gbExamTeacher.Size = new System.Drawing.Size(340, 63);
            this.gbExamTeacher.TabIndex = 0;
            this.gbExamTeacher.TabStop = false;
            this.gbExamTeacher.Text = "Teacher: ";
            // 
            // txtExamTeacher
            // 
            this.txtExamTeacher.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtExamTeacher.Location = new System.Drawing.Point(6, 25);
            this.txtExamTeacher.Name = "txtExamTeacher";
            this.txtExamTeacher.ReadOnly = true;
            this.txtExamTeacher.Size = new System.Drawing.Size(328, 23);
            this.txtExamTeacher.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Result";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox19);
            this.groupBox10.Controls.Add(this.groupBox18);
            this.groupBox10.Controls.Add(this.groupBox17);
            this.groupBox10.Controls.Add(this.groupBox16);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(716, 511);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Result area: ";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.dataGridView1);
            this.groupBox19.Location = new System.Drawing.Point(212, 198);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(498, 307);
            this.groupBox19.TabIndex = 5;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Details: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Selected,
            this.Correct,
            this.State});
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(486, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Number
            // 
            this.Number.HeaderText = "Num.";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected.";
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            // 
            // Correct
            // 
            this.Correct.HeaderText = "Correct.";
            this.Correct.Name = "Correct";
            this.Correct.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State.";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label2);
            this.groupBox18.Controls.Add(this.label1);
            this.groupBox18.Location = new System.Drawing.Point(6, 332);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(200, 173);
            this.groupBox18.TabIndex = 4;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Calification: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 68F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 120);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "99/100 Points.";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox10);
            this.groupBox17.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox17.Location = new System.Drawing.Point(6, 265);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(200, 61);
            this.groupBox17.TabIndex = 3;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Passed:  ";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(6, 23);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(188, 23);
            this.textBox10.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.textBox9);
            this.groupBox16.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox16.Location = new System.Drawing.Point(6, 198);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(200, 61);
            this.groupBox16.TabIndex = 2;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Failed: ";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(6, 23);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(188, 23);
            this.textBox9.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.groupBox13);
            this.groupBox11.Controls.Add(this.groupBox14);
            this.groupBox11.Controls.Add(this.groupBox15);
            this.groupBox11.Location = new System.Drawing.Point(6, 22);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(704, 170);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Details: ";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox5);
            this.groupBox12.Location = new System.Drawing.Point(358, 91);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(340, 63);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Questions/Exercises quantity:  ";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.Location = new System.Drawing.Point(6, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(328, 23);
            this.textBox5.TabIndex = 1;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBox6);
            this.groupBox13.Location = new System.Drawing.Point(6, 91);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(340, 63);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Type: ";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox6.Location = new System.Drawing.Point(6, 22);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(328, 23);
            this.textBox6.TabIndex = 1;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.textBox7);
            this.groupBox14.Location = new System.Drawing.Point(358, 22);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(340, 63);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Creation Date: ";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox7.Location = new System.Drawing.Point(6, 25);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(328, 23);
            this.textBox7.TabIndex = 1;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox8);
            this.groupBox15.Location = new System.Drawing.Point(6, 22);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(340, 63);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Teacher: ";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox8.Location = new System.Drawing.Point(6, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(328, 23);
            this.textBox8.TabIndex = 0;
            // 
            // gbPic
            // 
            this.gbPic.Controls.Add(this.pbMain);
            this.gbPic.Location = new System.Drawing.Point(10, 176);
            this.gbPic.Name = "gbPic";
            this.gbPic.Size = new System.Drawing.Size(182, 197);
            this.gbPic.TabIndex = 2;
            this.gbPic.TabStop = false;
            this.gbPic.Text = "Welcome: ";
            // 
            // pbMain
            // 
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(6, 22);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(170, 162);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 553);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal Exam Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exam_FormClosing);
            this.Load += new System.EventHandler(this.Exam_Load);
            this.panel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbExam.ResumeLayout(false);
            this.gbExamInfo.ResumeLayout(false);
            this.gbExamOperations.ResumeLayout(false);
            this.gbExamOptions.ResumeLayout(false);
            this.gbExamOptions.PerformLayout();
            this.gbExamDetails.ResumeLayout(false);
            this.gbExamQInfo.ResumeLayout(false);
            this.gbExamQInfo.PerformLayout();
            this.gbExamType.ResumeLayout(false);
            this.gbExamType.PerformLayout();
            this.gbExamCreation.ResumeLayout(false);
            this.gbExamCreation.PerformLayout();
            this.gbExamTeacher.ResumeLayout(false);
            this.gbExamTeacher.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.gbPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnResult;
        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox gbExam;
        private GroupBox gbExamInfo;
        private GroupBox gbExamOperations;
        private Button btnExamAnswer;
        private GroupBox gbExamOptions;
        private RadioButton radiBut4;
        private RadioButton radiBut3;
        private RadioButton radiBut2;
        private RadioButton radiBut1;
        private RichTextBox rbExamInfo;
        private GroupBox gbExamDetails;
        private GroupBox gbExamQInfo;
        private GroupBox gbExamType;
        private GroupBox gbExamCreation;
        private GroupBox gbExamTeacher;
        private TextBox txtExamTeacher;
        private TextBox txtExamQ;
        private TextBox txtExamType;
        private TextBox txtExamCreation;
        private GroupBox groupBox10;
        private GroupBox groupBox18;
        private Label label2;
        private Label label1;
        private GroupBox groupBox17;
        private TextBox textBox10;
        private GroupBox groupBox16;
        private TextBox textBox9;
        private GroupBox groupBox11;
        private GroupBox groupBox12;
        private TextBox textBox5;
        private GroupBox groupBox13;
        private TextBox textBox6;
        private GroupBox groupBox14;
        private TextBox textBox7;
        private GroupBox groupBox15;
        private TextBox textBox8;
        private GroupBox groupBox19;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Selected;
        private DataGridViewTextBoxColumn Correct;
        private DataGridViewTextBoxColumn State;
        private DataGridViewButtonColumn Number;
        private Button btnExamSkip;
        private GroupBox gbPic;
        private PictureBox pbMain;
    }
}