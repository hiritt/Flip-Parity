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
            playbutton.Location = new Point(862, 611);
            playbutton.Name = "playbutton";
            playbutton.Size = new Size(320, 70);
            playbutton.TabIndex = 2;
            playbutton.Text = "Play as guest";
            playbutton.UseVisualStyleBackColor = true;
            playbutton.Click += playbutton_Click;
            playbutton.MouseEnter += (s, e) =>
            {
                playbutton.BackColor = Color.DeepSkyBlue;
                playbutton.ForeColor = Color.Black;
            };
            playbutton.MouseLeave += (s, e) =>
            {
                playbutton.BackColor = Color.FromArgb(11, 14, 40);
                playbutton.ForeColor = Color.WhiteSmoke;
            };
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(playbutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private Button playbutton;
    }
}