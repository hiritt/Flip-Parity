namespace Cube_Flip
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            playbutton = new Button();
            username = new TextBox();
            password = new TextBox();
            LogInButton = new Button();
            CreateAcc = new Label();
            panel1 = new Panel();
            label1 = new Label();
            AlrdAcc = new Label();
            SignUp = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // playbutton
            // 
            playbutton.BackColor = Color.FromArgb(11, 14, 40);
            playbutton.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            playbutton.FlatAppearance.BorderSize = 4;
            playbutton.FlatStyle = FlatStyle.Flat;
            playbutton.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playbutton.ForeColor = Color.WhiteSmoke;
            playbutton.Location = new Point(804, 902);
            playbutton.Name = "playbutton";
            playbutton.Size = new Size(320, 70);
            playbutton.TabIndex = 2;
            playbutton.Text = "Play as guest";
            playbutton.UseVisualStyleBackColor = true;
            playbutton.Visible = false;
            playbutton.Click += playbutton_Click;
            playbutton.MouseEnter += me;
            playbutton.MouseLeave += ml;
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(46, 216, 250);
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 29.5F);
            username.Location = new Point(760, 460);
            username.MaxLength = 12;
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(400, 53);
            username.TabIndex = 3;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(46, 216, 250);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 29.5F);
            password.Location = new Point(760, 540);
            password.MaxLength = 23;
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "password";
            password.Size = new Size(400, 53);
            password.TabIndex = 4;
            password.TextAlign = HorizontalAlignment.Center;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.Transparent;
            LogInButton.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            LogInButton.FlatAppearance.BorderSize = 4;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.WhiteSmoke;
            LogInButton.Location = new Point(810, 640);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(300, 70);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            LogInButton.MouseEnter += lme;
            LogInButton.MouseLeave += lml;
            // 
            // CreateAcc
            // 
            CreateAcc.AutoSize = true;
            CreateAcc.BackColor = Color.Transparent;
            CreateAcc.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            CreateAcc.ForeColor = Color.White;
            CreateAcc.Location = new Point(853, 769);
            CreateAcc.Name = "CreateAcc";
            CreateAcc.Size = new Size(213, 28);
            CreateAcc.TabIndex = 6;
            CreateAcc.Text = "No account? Sign up!";
            CreateAcc.Click += CreateAcc_Click;
            CreateAcc.MouseEnter += cme;
            CreateAcc.MouseLeave += cml;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AlrdAcc);
            panel1.Controls.Add(SignUp);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 1080);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(811, 362);
            label1.Name = "label1";
            label1.Size = new Size(298, 32);
            label1.TabIndex = 11;
            label1.Text = "Username already exists!";
            label1.Visible = false;
            // 
            // AlrdAcc
            // 
            AlrdAcc.AutoSize = true;
            AlrdAcc.BackColor = Color.Transparent;
            AlrdAcc.Font = new Font("Segoe UI", 14.5F, FontStyle.Bold);
            AlrdAcc.ForeColor = Color.White;
            AlrdAcc.Location = new Point(788, 769);
            AlrdAcc.Name = "AlrdAcc";
            AlrdAcc.Size = new Size(344, 28);
            AlrdAcc.TabIndex = 10;
            AlrdAcc.Text = "Already having an account? Log in!";
            AlrdAcc.Click += AlrdAcc_Click;
            AlrdAcc.MouseEnter += aame;
            AlrdAcc.MouseLeave += aaml;
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.Transparent;
            SignUp.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            SignUp.FlatAppearance.BorderSize = 4;
            SignUp.FlatStyle = FlatStyle.Flat;
            SignUp.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp.ForeColor = Color.WhiteSmoke;
            SignUp.Location = new Point(810, 640);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(300, 70);
            SignUp.TabIndex = 9;
            SignUp.Text = "Sign up!";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += SignUp_Click;
            SignUp.MouseEnter += sume;
            SignUp.MouseLeave += suml;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(46, 216, 250);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 29.5F);
            textBox1.Location = new Point(760, 540);
            textBox1.MaxLength = 23;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "password";
            textBox1.Size = new Size(400, 53);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(46, 216, 250);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 29.5F);
            textBox2.Location = new Point(760, 460);
            textBox2.MaxLength = 12;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "username";
            textBox2.Size = new Size(400, 53);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(789, 362);
            label2.Name = "label2";
            label2.Size = new Size(341, 32);
            label2.TabIndex = 12;
            label2.Text = "Account created succesfully!";
            label2.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(CreateAcc);
            Controls.Add(LogInButton);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(playbutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button playbutton;
        private TextBox username;
        private TextBox password;
        private Button LogInButton;
        private Label CreateAcc;
        private Panel panel1;
        private Label AlrdAcc;
        private Button SignUp;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}