namespace UniversalExamScreen
{
    partial class ResultViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultViewer));
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCorrect = new System.Windows.Forms.GroupBox();
            this.txtCoorrect = new System.Windows.Forms.TextBox();
            this.gbSelected = new System.Windows.Forms.GroupBox();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.rbInfo = new System.Windows.Forms.RichTextBox();
            this.gbMain.SuspendLayout();
            this.gbCorrect.SuspendLayout();
            this.gbSelected.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnExit);
            this.gbMain.Controls.Add(this.gbCorrect);
            this.gbMain.Controls.Add(this.gbSelected);
            this.gbMain.Controls.Add(this.gbInfo);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(454, 206);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Details: ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(395, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbCorrect
            // 
            this.gbCorrect.Controls.Add(this.txtCoorrect);
            this.gbCorrect.Location = new System.Drawing.Point(202, 136);
            this.gbCorrect.Name = "gbCorrect";
            this.gbCorrect.Size = new System.Drawing.Size(187, 57);
            this.gbCorrect.TabIndex = 2;
            this.gbCorrect.TabStop = false;
            this.gbCorrect.Text = "Correct: ";
            // 
            // txtCoorrect
            // 
            this.txtCoorrect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCoorrect.Location = new System.Drawing.Point(6, 22);
            this.txtCoorrect.Name = "txtCoorrect";
            this.txtCoorrect.ReadOnly = true;
            this.txtCoorrect.Size = new System.Drawing.Size(175, 23);
            this.txtCoorrect.TabIndex = 1;
            // 
            // gbSelected
            // 
            this.gbSelected.Controls.Add(this.txtSelected);
            this.gbSelected.Location = new System.Drawing.Point(9, 136);
            this.gbSelected.Name = "gbSelected";
            this.gbSelected.Size = new System.Drawing.Size(187, 57);
            this.gbSelected.TabIndex = 1;
            this.gbSelected.TabStop = false;
            this.gbSelected.Text = "Selected: ";
            // 
            // txtSelected
            // 
            this.txtSelected.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSelected.Location = new System.Drawing.Point(6, 22);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.ReadOnly = true;
            this.txtSelected.Size = new System.Drawing.Size(175, 23);
            this.txtSelected.TabIndex = 0;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.rbInfo);
            this.gbInfo.Location = new System.Drawing.Point(6, 22);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(442, 108);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information: ";
            // 
            // rbInfo
            // 
            this.rbInfo.BackColor = System.Drawing.Color.OldLace;
            this.rbInfo.Location = new System.Drawing.Point(3, 22);
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.ReadOnly = true;
            this.rbInfo.Size = new System.Drawing.Size(436, 71);
            this.rbInfo.TabIndex = 0;
            this.rbInfo.Text = "";
            // 
            // ResultViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 230);
            this.Controls.Add(this.gbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal Exam Screen - Result viwer";
            this.Load += new System.EventHandler(this.ResultViewer_Load);
            this.gbMain.ResumeLayout(false);
            this.gbCorrect.ResumeLayout(false);
            this.gbCorrect.PerformLayout();
            this.gbSelected.ResumeLayout(false);
            this.gbSelected.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbMain;
        private GroupBox gbSelected;
        private GroupBox gbInfo;
        private GroupBox gbCorrect;
        private TextBox txtCoorrect;
        private TextBox txtSelected;
        private RichTextBox rbInfo;
        private Button btnExit;
    }
}