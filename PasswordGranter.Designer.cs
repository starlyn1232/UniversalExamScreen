namespace UniversalExamScreen
{
    partial class PasswordGranter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGranter));
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.gbPass = new System.Windows.Forms.GroupBox();
            this.gbFile = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.btnGrant = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.gbPass.SuspendLayout();
            this.gbFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.gbOption);
            this.gbMain.Controls.Add(this.gbPass);
            this.gbMain.Controls.Add(this.gbFile);
            this.gbMain.Controls.Add(this.pictureBox1);
            this.gbMain.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(447, 191);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Password Granter: ";
            // 
            // gbPass
            // 
            this.gbPass.Controls.Add(this.txtPass);
            this.gbPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbPass.Location = new System.Drawing.Point(6, 111);
            this.gbPass.Name = "gbPass";
            this.gbPass.Size = new System.Drawing.Size(313, 62);
            this.gbPass.TabIndex = 2;
            this.gbPass.TabStop = false;
            this.gbPass.Text = "Exam Password: ";
            // 
            // gbFile
            // 
            this.gbFile.Controls.Add(this.txtFile);
            this.gbFile.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbFile.Location = new System.Drawing.Point(6, 23);
            this.gbFile.Name = "gbFile";
            this.gbFile.Size = new System.Drawing.Size(313, 62);
            this.gbFile.TabIndex = 1;
            this.gbFile.TabStop = false;
            this.gbFile.Text = "Exam File: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFile.Location = new System.Drawing.Point(6, 23);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(301, 24);
            this.txtFile.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 23);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(301, 24);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.btnGrant);
            this.gbOption.Location = new System.Drawing.Point(325, 111);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(116, 62);
            this.gbOption.TabIndex = 3;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Option: ";
            // 
            // btnGrant
            // 
            this.btnGrant.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGrant.Enabled = false;
            this.btnGrant.Location = new System.Drawing.Point(8, 19);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(100, 31);
            this.btnGrant.TabIndex = 0;
            this.btnGrant.Text = "Grant";
            this.btnGrant.UseVisualStyleBackColor = false;
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // PasswordGranter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 222);
            this.Controls.Add(this.gbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordGranter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal Exam Screen - Password Granter";
            this.Load += new System.EventHandler(this.PasswordGranter_Load);
            this.gbMain.ResumeLayout(false);
            this.gbPass.ResumeLayout(false);
            this.gbPass.PerformLayout();
            this.gbFile.ResumeLayout(false);
            this.gbFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbMain;
        private GroupBox gbPass;
        private GroupBox gbFile;
        private PictureBox pictureBox1;
        private GroupBox gbOption;
        private Button btnGrant;
        internal TextBox txtPass;
        internal TextBox txtFile;
    }
}