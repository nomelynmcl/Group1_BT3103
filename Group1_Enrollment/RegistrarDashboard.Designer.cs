namespace EventDriven.Project.UI
{
    partial class RegistrarDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarDashboard));
            btnRegistrarOverview = new Button();
            btnLogoutRegistrar = new Button();
            lblRegistrarReport = new Label();
            lblRegistrarStudentRegistration = new Label();
            lblRegistrarAssessment = new Label();
            lblRegistrarStudentInfo = new Label();
            lblRegistrar = new Label();
            pcRegistrarLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcRegistrarLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarOverview
            // 
            btnRegistrarOverview.BackColor = Color.LightGray;
            btnRegistrarOverview.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarOverview.ForeColor = Color.SteelBlue;
            btnRegistrarOverview.Location = new Point(557, 430);
            btnRegistrarOverview.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarOverview.Name = "btnRegistrarOverview";
            btnRegistrarOverview.Size = new Size(253, 34);
            btnRegistrarOverview.TabIndex = 24;
            btnRegistrarOverview.Text = "REGISTRAR OVERVIEW";
            btnRegistrarOverview.UseVisualStyleBackColor = false;
            // 
            // btnLogoutRegistrar
            // 
            btnLogoutRegistrar.BackColor = Color.LightGray;
            btnLogoutRegistrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogoutRegistrar.Location = new Point(1026, 27);
            btnLogoutRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnLogoutRegistrar.Name = "btnLogoutRegistrar";
            btnLogoutRegistrar.Size = new Size(79, 27);
            btnLogoutRegistrar.TabIndex = 23;
            btnLogoutRegistrar.Text = "Logout";
            btnLogoutRegistrar.UseVisualStyleBackColor = false;
            btnLogoutRegistrar.Click += btnLogoutRegistrar_Click;
            // 
            // lblRegistrarReport
            // 
            lblRegistrarReport.AutoSize = true;
            lblRegistrarReport.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrarReport.Location = new Point(38, 344);
            lblRegistrarReport.Name = "lblRegistrarReport";
            lblRegistrarReport.Size = new Size(68, 20);
            lblRegistrarReport.TabIndex = 21;
            lblRegistrarReport.Text = "REPORT";
            // 
            // lblRegistrarStudentRegistration
            // 
            lblRegistrarStudentRegistration.AutoSize = true;
            lblRegistrarStudentRegistration.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrarStudentRegistration.Location = new Point(38, 297);
            lblRegistrarStudentRegistration.Name = "lblRegistrarStudentRegistration";
            lblRegistrarStudentRegistration.Size = new Size(196, 60);
            lblRegistrarStudentRegistration.TabIndex = 20;
            lblRegistrarStudentRegistration.Text = "STUDENT REGISTRATION\r\n\r\n\r\n";
            lblRegistrarStudentRegistration.Click += lblRegistrarStudentRegistration_Click;
            // 
            // lblRegistrarAssessment
            // 
            lblRegistrarAssessment.AutoSize = true;
            lblRegistrarAssessment.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrarAssessment.Location = new Point(38, 250);
            lblRegistrarAssessment.Name = "lblRegistrarAssessment";
            lblRegistrarAssessment.Size = new Size(109, 20);
            lblRegistrarAssessment.TabIndex = 19;
            lblRegistrarAssessment.Text = "ASSESSMENT";
            lblRegistrarAssessment.Click += lblRegistrarAssessment_Click;
            // 
            // lblRegistrarStudentInfo
            // 
            lblRegistrarStudentInfo.AutoSize = true;
            lblRegistrarStudentInfo.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrarStudentInfo.Location = new Point(38, 202);
            lblRegistrarStudentInfo.Name = "lblRegistrarStudentInfo";
            lblRegistrarStudentInfo.Size = new Size(194, 20);
            lblRegistrarStudentInfo.TabIndex = 18;
            lblRegistrarStudentInfo.Text = "STUDENT INFORMATION";
            lblRegistrarStudentInfo.Click += lblRegistrarStudentInfo_Click;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrar.ForeColor = Color.SteelBlue;
            lblRegistrar.Location = new Point(34, 130);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(200, 45);
            lblRegistrar.TabIndex = 16;
            lblRegistrar.Text = "REGISTRAR";
            // 
            // pcRegistrarLogo
            // 
            pcRegistrarLogo.Image = (Image)resources.GetObject("pcRegistrarLogo.Image");
            pcRegistrarLogo.Location = new Point(20, 12);
            pcRegistrarLogo.Margin = new Padding(3, 2, 3, 2);
            pcRegistrarLogo.Name = "pcRegistrarLogo";
            pcRegistrarLogo.Size = new Size(224, 142);
            pcRegistrarLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcRegistrarLogo.TabIndex = 17;
            pcRegistrarLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 72);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // RegistrarDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 487);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegistrarOverview);
            Controls.Add(btnLogoutRegistrar);
            Controls.Add(lblRegistrarReport);
            Controls.Add(lblRegistrarStudentRegistration);
            Controls.Add(lblRegistrarAssessment);
            Controls.Add(lblRegistrarStudentInfo);
            Controls.Add(lblRegistrar);
            Controls.Add(pcRegistrarLogo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrarDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistarDashboard";
            ((System.ComponentModel.ISupportInitialize)pcRegistrarLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrarOverview;
        private Button btnLogoutRegistrar;
        private Label lblRegistrarReport;
        private Label lblRegistrarStudentRegistration;
        private Label lblRegistrarAssessment;
        private Label lblRegistrarStudentInfo;
        private Label lblRegistrar;
        private PictureBox pcRegistrarLogo;
        private PictureBox pictureBox1;
    }
}