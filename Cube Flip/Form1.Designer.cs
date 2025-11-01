using System.Runtime.CompilerServices;

namespace Cube_Flip
{
    partial class CubeFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubeFlip));
            playbutton = new Button();
            Htp = new Button();
            settings = new Button();
            exit = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            ledtitle = new Label();
            easybutton = new PictureBox();
            hardbutton = new PictureBox();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox7 = new PictureBox();
            button3 = new Button();
            label3 = new Label();
            loadingscreen = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)easybutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hardbutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadingscreen).BeginInit();
            SuspendLayout();
            // 
            // playbutton
            // 
            playbutton.BackColor = Color.Transparent;
            playbutton.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            playbutton.FlatAppearance.BorderSize = 4;
            playbutton.FlatStyle = FlatStyle.Flat;
            playbutton.Font = new Font("Segoe UI", 65F, FontStyle.Bold);
            playbutton.ForeColor = Color.White;
            playbutton.Location = new Point(205, 500);
            playbutton.Name = "playbutton";
            playbutton.Size = new Size(550, 165);
            playbutton.TabIndex = 1;
            playbutton.Text = "Play";
            playbutton.UseVisualStyleBackColor = false;
            playbutton.Click += playbutton_Click;
            playbutton.MouseEnter += playbutton_MouseEnter;
            playbutton.MouseLeave += playbutton_MouseLeave;
            // 
            // Htp
            // 
            Htp.BackColor = Color.Transparent;
            Htp.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            Htp.FlatAppearance.BorderSize = 4;
            Htp.FlatStyle = FlatStyle.Flat;
            Htp.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Htp.ForeColor = Color.WhiteSmoke;
            Htp.Location = new Point(106, 950);
            Htp.Name = "Htp";
            Htp.Size = new Size(320, 70);
            Htp.TabIndex = 2;
            Htp.Text = "How to play";
            Htp.UseVisualStyleBackColor = false;
            Htp.Click += Htp_Click;
            Htp.MouseEnter += Htp_MouseEnter;
            Htp.MouseLeave += Htp_MouseLeave;
            // 
            // settings
            // 
            settings.BackColor = Color.Transparent;
            settings.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            settings.FlatAppearance.BorderSize = 4;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settings.ForeColor = Color.WhiteSmoke;
            settings.Location = new Point(320, 850);
            settings.Name = "settings";
            settings.Size = new Size(320, 70);
            settings.TabIndex = 3;
            settings.Text = "Coming soon!";
            settings.UseVisualStyleBackColor = false;
            settings.MouseEnter += settings_MouseEnter;
            settings.MouseLeave += settings_MouseLeave;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            exit.FlatAppearance.BorderSize = 4;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.WhiteSmoke;
            exit.Location = new Point(532, 950);
            exit.Name = "exit";
            exit.Size = new Size(320, 70);
            exit.TabIndex = 4;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            exit.MouseEnter += exit_MouseEnter;
            exit.MouseLeave += exit_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(playbutton);
            panel1.Controls.Add(Htp);
            panel1.Controls.Add(settings);
            panel1.Controls.Add(exit);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 7;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1286, 121);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(598, 100);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 8;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(1286, 233);
            panel3.Name = "panel3";
            panel3.Size = new Size(598, 834);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 20);
            label2.Name = "label2";
            label2.Size = new Size(295, 45);
            label2.TabIndex = 0;
            label2.Text = "Leaderboard hard";
            label2.Click += label2_Click_2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(ledtitle);
            panel2.Location = new Point(1286, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 834);
            panel2.TabIndex = 6;
            // 
            // ledtitle
            // 
            ledtitle.AutoSize = true;
            ledtitle.BackColor = Color.Transparent;
            ledtitle.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ledtitle.ForeColor = Color.White;
            ledtitle.Location = new Point(15, 20);
            ledtitle.Name = "ledtitle";
            ledtitle.Size = new Size(293, 45);
            ledtitle.TabIndex = 0;
            ledtitle.Text = "Leaderboard easy";
            ledtitle.Click += label2_Click;
            // 
            // easybutton
            // 
            easybutton.Image = (Image)resources.GetObject("easybutton.Image");
            easybutton.Location = new Point(510, 290);
            easybutton.Name = "easybutton";
            easybutton.Size = new Size(400, 500);
            easybutton.SizeMode = PictureBoxSizeMode.StretchImage;
            easybutton.TabIndex = 6;
            easybutton.TabStop = false;
            easybutton.Visible = false;
            easybutton.Click += pictureBox3_Click;
            // 
            // hardbutton
            // 
            hardbutton.Image = (Image)resources.GetObject("hardbutton.Image");
            hardbutton.Location = new Point(1010, 290);
            hardbutton.Name = "hardbutton";
            hardbutton.Size = new Size(400, 500);
            hardbutton.SizeMode = PictureBoxSizeMode.StretchImage;
            hardbutton.TabIndex = 8;
            hardbutton.TabStop = false;
            hardbutton.Visible = false;
            hardbutton.Click += pictureBox4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 100);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 14, 40);
            button1.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 4;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(590, 680);
            button1.Name = "button1";
            button1.Size = new Size(320, 70);
            button1.TabIndex = 6;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(11, 14, 40);
            button2.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            button2.FlatAppearance.BorderSize = 4;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(1010, 680);
            button2.Name = "button2";
            button2.Size = new Size(320, 70);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1920, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(11, 14, 40);
            button3.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            button3.FlatAppearance.BorderSize = 4;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(153, 70);
            button3.TabIndex = 7;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(833, 398);
            label3.Name = "label3";
            label3.Size = new Size(254, 71);
            label3.TabIndex = 10;
            label3.Text = "10.9999S";
            label3.Visible = false;
            // 
            // loadingscreen
            // 
            loadingscreen.Image = (Image)resources.GetObject("loadingscreen.Image");
            loadingscreen.Location = new Point(0, 0);
            loadingscreen.Name = "loadingscreen";
            loadingscreen.Size = new Size(100, 50);
            loadingscreen.TabIndex = 11;
            loadingscreen.TabStop = false;
            loadingscreen.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(669, 843);
            label1.Name = "label1";
            label1.Size = new Size(581, 71);
            label1.TabIndex = 12;
            label1.Text = "Create a custom level!";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(182, 0, 205);
            textBox1.Font = new Font("Segoe UI", 40F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(683, 940);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "[1,20]";
            textBox1.Size = new Size(141, 78);
            textBox1.TabIndex = 13;
            textBox1.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            button4.FlatAppearance.BorderSize = 4;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(875, 940);
            button4.Name = "button4";
            button4.Size = new Size(320, 70);
            button4.TabIndex = 14;
            button4.Text = "Generate";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // CubeFlip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 14, 40);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1061);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(loadingscreen);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hardbutton);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox6);
            Controls.Add(easybutton);
            Controls.Add(pictureBox7);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CubeFlip";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)easybutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)hardbutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadingscreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button playbutton;
        private Button Htp;
        private Button settings;
        private Button exit;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox easybutton;
        private PictureBox hardbutton;
        private PictureBox pictureBox6;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label ledtitle;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox7;
        private Button button3;
        private PictureBox pictureBox8;
        private Label label3;
        private PictureBox loadingscreen;
        private Label label1;
        private TextBox textBox1;
        private Button button4;
    }
}
