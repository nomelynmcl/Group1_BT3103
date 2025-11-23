namespace Group1_Enrollment
{
    partial class UserRolesForm:Form     
    {
        public static string SelectedRole = "";

        private System.ComponentModel.IContainer components = null;

       
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRolesForm));
            btnAdmin = new Button();
            btnCashier = new Button();
            btnRegistrar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.CadetBlue;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.AliceBlue;
            btnAdmin.Location = new Point(433, 396);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(409, 65);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.CadetBlue;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.ForeColor = Color.AliceBlue;
            btnCashier.Location = new Point(433, 579);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(409, 65);
            btnCashier.TabIndex = 1;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.CadetBlue;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.AliceBlue;
            btnRegistrar.Location = new Point(433, 487);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(409, 65);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(551, 263);
            label1.Name = "label1";
            label1.Size = new Size(403, 39);
            label1.TabIndex = 3;
            label1.Text = "Orion Tech-High School";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = EventDriven.Project.UI.Properties.Resources.ui;
            pictureBox1.Location = new Point(3, 597);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(829, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = EventDriven.Project.UI.Properties.Resources.ui;
            pictureBox2.Location = new Point(666, -131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(829, 251);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.AliceBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(224, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(413, 327);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCashier);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(312, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1271, 809);
            panel1.TabIndex = 8;
            // 
            // UserRolesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            Name = "UserRolesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Roles";
            Load += UserRolesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdmin;
        private Button btnCashier;
        private Button btnRegistrar;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
    }
}
