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
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox7 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
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
            pictureBox2.Size = new Size(0, 0);
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
            panel1.Size = new Size(1920, 1080);
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(510, 290);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 500);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(398, 177);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1010, 290);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(0, 0);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(218, 671);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1000, 500);
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
            pictureBox7.Size = new Size(100, 50);
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
            // CubeFlip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 14, 40);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1061);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button playbutton;
        private Button Htp;
        private Button settings;
        private Button exit;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
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
    }
}
