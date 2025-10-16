namespace EventDriven.Project.UI
{
    partial class AdminStudentInformation_View
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbAdminViewFullname = new Label();
            lbAdminViewAge = new Label();
            lbAdminViewGender = new Label();
            lbAdminViewAddress = new Label();
            lbAdminViewContactNo = new Label();
            lbAdminViewGuardian = new Label();
            lbAdminViewGuardianContact = new Label();
            lbAdminViewLevel = new Label();
            lbAdminViewType = new Label();
            btnAdminViewCancel = new Button();
            btnAdminViewPrint = new Button();
            label19 = new Label();
            lbAdminViewBirthdate = new Label();
            pictureBox1 = new PictureBox();
            label21 = new Label();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(75, 154);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(75, 197);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(75, 287);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(75, 330);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(75, 551);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "Student Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(75, 509);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Year Level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(75, 466);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 6;
            label7.Text = "Contact Number:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(75, 421);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 7;
            label8.Text = "Guardian's Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(75, 376);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 8;
            label9.Text = "Contact Number:";
            // 
            // lbAdminViewFullname
            // 
            lbAdminViewFullname.AutoSize = true;
            lbAdminViewFullname.Location = new Point(220, 154);
            lbAdminViewFullname.Name = "lbAdminViewFullname";
            lbAdminViewFullname.Size = new Size(93, 15);
            lbAdminViewFullname.TabIndex = 9;
            lbAdminViewFullname.Text = "<<Full Name>>";
            lbAdminViewFullname.Click += lbAdminViewFullname_Click;
            // 
            // lbAdminViewAge
            // 
            lbAdminViewAge.AutoSize = true;
            lbAdminViewAge.Location = new Point(220, 199);
            lbAdminViewAge.Name = "lbAdminViewAge";
            lbAdminViewAge.Size = new Size(60, 15);
            lbAdminViewAge.TabIndex = 10;
            lbAdminViewAge.Text = "<<Age>>";
            // 
            // lbAdminViewGender
            // 
            lbAdminViewGender.AutoSize = true;
            lbAdminViewGender.Location = new Point(220, 287);
            lbAdminViewGender.Name = "lbAdminViewGender";
            lbAdminViewGender.Size = new Size(77, 15);
            lbAdminViewGender.TabIndex = 11;
            lbAdminViewGender.Text = "<<Gender>>";
            // 
            // lbAdminViewAddress
            // 
            lbAdminViewAddress.AutoSize = true;
            lbAdminViewAddress.Location = new Point(220, 330);
            lbAdminViewAddress.Name = "lbAdminViewAddress";
            lbAdminViewAddress.Size = new Size(81, 15);
            lbAdminViewAddress.TabIndex = 12;
            lbAdminViewAddress.Text = "<<Address>>";
            lbAdminViewAddress.Click += lbAdminViewAddress_Click;
            // 
            // lbAdminViewContactNo
            // 
            lbAdminViewContactNo.AutoSize = true;
            lbAdminViewContactNo.Location = new Point(220, 376);
            lbAdminViewContactNo.Name = "lbAdminViewContactNo";
            lbAdminViewContactNo.Size = new Size(131, 15);
            lbAdminViewContactNo.TabIndex = 13;
            lbAdminViewContactNo.Text = "<<Contact  Number>>";
            // 
            // lbAdminViewGuardian
            // 
            lbAdminViewGuardian.AutoSize = true;
            lbAdminViewGuardian.Location = new Point(218, 421);
            lbAdminViewGuardian.Name = "lbAdminViewGuardian";
            lbAdminViewGuardian.Size = new Size(130, 15);
            lbAdminViewGuardian.TabIndex = 14;
            lbAdminViewGuardian.Text = "<<Guardian's Name>>";
            // 
            // lbAdminViewGuardianContact
            // 
            lbAdminViewGuardianContact.AutoSize = true;
            lbAdminViewGuardianContact.Location = new Point(218, 466);
            lbAdminViewGuardianContact.Name = "lbAdminViewGuardianContact";
            lbAdminViewGuardianContact.Size = new Size(128, 15);
            lbAdminViewGuardianContact.TabIndex = 15;
            lbAdminViewGuardianContact.Text = "<<Contact Number>>";
            // 
            // lbAdminViewLevel
            // 
            lbAdminViewLevel.AutoSize = true;
            lbAdminViewLevel.Location = new Point(220, 509);
            lbAdminViewLevel.Name = "lbAdminViewLevel";
            lbAdminViewLevel.Size = new Size(91, 15);
            lbAdminViewLevel.TabIndex = 16;
            lbAdminViewLevel.Text = "<<Year Level>>";
            // 
            // lbAdminViewType
            // 
            lbAdminViewType.AutoSize = true;
            lbAdminViewType.Location = new Point(220, 551);
            lbAdminViewType.Name = "lbAdminViewType";
            lbAdminViewType.Size = new Size(108, 15);
            lbAdminViewType.TabIndex = 17;
            lbAdminViewType.Text = "<<Student Type>>";
            // 
            // btnAdminViewCancel
            // 
            btnAdminViewCancel.Location = new Point(262, 607);
            btnAdminViewCancel.Name = "btnAdminViewCancel";
            btnAdminViewCancel.Size = new Size(75, 23);
            btnAdminViewCancel.TabIndex = 18;
            btnAdminViewCancel.Text = "Cancel";
            btnAdminViewCancel.UseVisualStyleBackColor = true;
            btnAdminViewCancel.Click += btnAdminViewCancel_Click;
            // 
            // btnAdminViewPrint
            // 
            btnAdminViewPrint.Location = new Point(157, 607);
            btnAdminViewPrint.Name = "btnAdminViewPrint";
            btnAdminViewPrint.Size = new Size(75, 23);
            btnAdminViewPrint.TabIndex = 19;
            btnAdminViewPrint.Text = "Print";
            btnAdminViewPrint.UseVisualStyleBackColor = true;
            btnAdminViewPrint.Click += btnAdminViewPrint_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label19.Location = new Point(75, 241);
            label19.Name = "label19";
            label19.Size = new Size(63, 15);
            label19.TabIndex = 20;
            label19.Text = "Birthdate:";
            // 
            // lbAdminViewBirthdate
            // 
            lbAdminViewBirthdate.AutoSize = true;
            lbAdminViewBirthdate.Location = new Point(220, 241);
            lbAdminViewBirthdate.Name = "lbAdminViewBirthdate";
            lbAdminViewBirthdate.Size = new Size(87, 15);
            lbAdminViewBirthdate.TabIndex = 21;
            lbAdminViewBirthdate.Text = "<<Birthdate>>";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Add_a_heading__7__removebg_preview;
            pictureBox1.Location = new Point(51, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.DarkSlateGray;
            label21.Location = new Point(168, 68);
            label21.Name = "label21";
            label21.Size = new Size(238, 24);
            label21.TabIndex = 23;
            label21.Text = "Orion Tech-High School";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // AdminStudentInformation_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(484, 662);
            Controls.Add(label21);
            Controls.Add(pictureBox1);
            Controls.Add(lbAdminViewBirthdate);
            Controls.Add(label19);
            Controls.Add(btnAdminViewPrint);
            Controls.Add(btnAdminViewCancel);
            Controls.Add(lbAdminViewType);
            Controls.Add(lbAdminViewLevel);
            Controls.Add(lbAdminViewGuardianContact);
            Controls.Add(lbAdminViewGuardian);
            Controls.Add(lbAdminViewContactNo);
            Controls.Add(lbAdminViewAddress);
            Controls.Add(lbAdminViewGender);
            Controls.Add(lbAdminViewAge);
            Controls.Add(lbAdminViewFullname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminStudentInformation_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View - Student Information";
            Load += AdminStudentInformation_View_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbAdminViewFullname;
        private Label lbAdminViewAge;
        private Label lbAdminViewGender;
        private Label lbAdminViewAddress;
        private Label lbAdminViewContactNo;
        private Label lbAdminViewGuardian;
        private Label lbAdminViewGuardianContact;
        private Label lbAdminViewLevel;
        private Label lbAdminViewType;
        private Button btnAdminViewCancel;
        private Button btnAdminViewPrint;
        private Label label19;
        private Label lbAdminViewBirthdate;
        private PictureBox pictureBox1;
        private Label label21;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}