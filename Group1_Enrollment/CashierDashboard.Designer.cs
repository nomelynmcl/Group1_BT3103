namespace EventDriven.Project.UI
{
    partial class CashierDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashboard));
            textBox1 = new TextBox();
            button5 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(699, 27);
            textBox1.TabIndex = 27;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1045, 93);
            button5.Name = "button5";
            button5.Size = new Size(144, 33);
            button5.TabIndex = 26;
            button5.Text = "Search Student";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1137, 22);
            button1.Name = "button1";
            button1.Size = new Size(102, 43);
            button1.TabIndex = 22;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(340, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(699, 396);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 342);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 19;
            label4.Text = "Reports";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 293);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 17;
            label2.Text = "Payment History";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 243);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 16;
            label1.Text = "Cashier -Payment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_09_08_204603;
            pictureBox1.Location = new Point(104, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.DarkGreen;
            lblAdmin.Location = new Point(83, 163);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(196, 54);
            lblAdmin.TabIndex = 14;
            lblAdmin.Text = "CASHIER";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 637);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblAdmin);
            Name = "Form3";
            Text = "CashierDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button5;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblAdmin;
    }
}