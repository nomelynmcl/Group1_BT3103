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
            btnAdmin = new Button();
            btnCashier = new Button();
            btnRegistrar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.ActiveCaption;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.Location = new Point(310, 201);
            btnAdmin.Margin = new Padding(3, 2, 3, 2);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(119, 32);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnCashier
            // 
            btnCashier.BackColor = SystemColors.ActiveCaption;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(310, 252);
            btnCashier.Margin = new Padding(3, 2, 3, 2);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(119, 32);
            btnCashier.TabIndex = 1;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ActiveCaption;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(310, 299);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(119, 32);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(258, 128);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 3;
            label1.Text = "Orion Tech-High School";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = EventDriven.Project.UI.Properties.Resources.ui;
            pictureBox1.Location = new Point(0, 252);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = EventDriven.Project.UI.Properties.Resources.ui;
            pictureBox2.Location = new Point(384, -74);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(776, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlLight;
            pictureBox3.Image = EventDriven.Project.UI.Properties.Resources.Screenshot_2025_09_08_204603_removebg_preview;
            pictureBox3.Location = new Point(140, 62);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 110);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // UserRolesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(748, 450);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCashier);
            Controls.Add(btnAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserRolesForm";
            Text = "Form1";
            Load += UserRolesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmin;
        private Button btnCashier;
        private Button btnRegistrar;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
