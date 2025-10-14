using System.Runtime.CompilerServices;

namespace Cube_Flip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            playbutton = new Button();
            Htp = new Button();
            settings = new Button();
            exit = new Button();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(11, 14, 40);
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 60);
            label1.Name = "label1";
            label1.Size = new Size(510, 128);
            label1.TabIndex = 0;
            label1.Text = "CUBE FLIP";
            // 
            // playbutton
            // 
            playbutton.BackColor = Color.FromArgb(11, 14, 40);
            playbutton.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            playbutton.FlatAppearance.BorderSize = 4;
            playbutton.FlatStyle = FlatStyle.Flat;
            playbutton.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playbutton.ForeColor = Color.WhiteSmoke;
            playbutton.Location = new Point(100, 250);
            playbutton.Name = "playbutton";
            playbutton.Size = new Size(320, 70);
            playbutton.TabIndex = 1;
            playbutton.Text = "Play";
            playbutton.UseVisualStyleBackColor = true;
            playbutton.Click += playbutton_Click;
            playbutton.MouseEnter += playbutton_MouseEnter;
            playbutton.MouseLeave += playbutton_MouseLeave;
            // 
            // Htp
            // 
            Htp.BackColor = Color.FromArgb(11, 14, 40);
            Htp.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            Htp.FlatAppearance.BorderSize = 4;
            Htp.FlatStyle = FlatStyle.Flat;
            Htp.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Htp.ForeColor = Color.WhiteSmoke;
            Htp.Location = new Point(100, 350);
            Htp.Name = "Htp";
            Htp.Size = new Size(320, 70);
            Htp.TabIndex = 2;
            Htp.Text = "How to play";
            Htp.UseVisualStyleBackColor = true;
            Htp.Click += Htp_Click;
            Htp.MouseEnter += Htp_MouseEnter;
            Htp.MouseLeave += Htp_MouseLeave;
            // 
            // settings
            // 
            settings.BackColor = Color.FromArgb(11, 14, 40);
            settings.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            settings.FlatAppearance.BorderSize = 4;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settings.ForeColor = Color.WhiteSmoke;
            settings.Location = new Point(100, 450);
            settings.Name = "settings";
            settings.Size = new Size(320, 70);
            settings.TabIndex = 3;
            settings.Text = "Coming soon!";
            settings.UseVisualStyleBackColor = true;
            settings.MouseEnter += settings_MouseEnter;
            settings.MouseLeave += settings_MouseLeave;
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(11, 14, 40);
            exit.FlatAppearance.BorderColor = Color.FromArgb(182, 78, 255);
            exit.FlatAppearance.BorderSize = 4;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.WhiteSmoke;
            exit.Location = new Point(100, 550);
            exit.Name = "exit";
            exit.Size = new Size(320, 70);
            exit.TabIndex = 4;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            exit.MouseEnter += exit_MouseEnter;
            exit.MouseLeave += exit_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(620, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(playbutton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Htp);
            panel1.Controls.Add(label1);
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
            panel3.Controls.Add(label2);
            panel3.Location = new Point(1286, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(598, 611);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 20);
            label2.Name = "label2";
            label2.Size = new Size(345, 45);
            label2.TabIndex = 0;
            label2.Text = "Your top hard solves:";
            // 
            // panel2
            // 
            panel2.Controls.Add(ledtitle);
            panel2.Location = new Point(1286, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 447);
            panel2.TabIndex = 6;
            // 
            // ledtitle
            // 
            ledtitle.AutoSize = true;
            ledtitle.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ledtitle.ForeColor = Color.White;
            ledtitle.Location = new Point(15, 20);
            ledtitle.Name = "ledtitle";
            ledtitle.Size = new Size(343, 45);
            ledtitle.TabIndex = 0;
            ledtitle.Text = "Your top easy solves:";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 14, 40);
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
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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

        private Label label1;
        private Button playbutton;
        private Button Htp;
        private Button settings;
        private Button exit;
        private PictureBox pictureBox1;
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
