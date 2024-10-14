namespace LoginPage1
{
    partial class Form1
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
            btnLogin = new Button();
            btnReset = new Button();
            btnExit = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonHighlight;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(75, 216);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(70, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonHighlight;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(192, 216);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(62, 29);
            btnReset.TabIndex = 2;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(317, 216);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button3_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(213, 152);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(125, 23);
            txtPass.TabIndex = 4;
            txtPass.TextChanged += textBox1_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(213, 77);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 23);
            txtUser.TabIndex = 5;
            txtUser.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(181, 23);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 6;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(106, 75);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 7;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(106, 150);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 8;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(451, 257);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnReset;
        private Button btnExit;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
