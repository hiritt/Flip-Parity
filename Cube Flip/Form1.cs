using System.CodeDom.Compiler;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace Cube_Flip
{
    public partial class CubeFlip : Form
    {
        StreamReader cin = new StreamReader("Scores.dtx");
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        int ezlv = 0, hdlv = 0;
        int[] nl, hl;
        /// <summary>
        /// MODIFICA MARIMEA LABEL 1 LA 1920X1080
        /// </summary>
        /// 

        Label[] l, h;
        void leaderboard(bool difct)
        {
            bool ok = false;
            if (difct == true)
            {
                l = new Label[ezlv + 1];
                for (int i = 0; i <= ezlv && i <= 6; i++)
                {
                    l[i] = new Label();
                    panel2.Controls.Add(l[i]);
                    l[i].Location = new Point(20, 92 + i * 50);
                    l[i].Size = new Size(400, 100);
                    l[i].ForeColor = Color.White;
                    l[i].Font = new Font("Microsoft Sans Serif", 20);
                    l[i].BackColor = Color.FromArgb(11, 14, 40);
                    l[i].BringToFront();
                    ok = false;
                    if (nl[i] >= 60)
                        ok = true;
                    if (ok == false)
                        l[i].Text = (i + 1) + ".  " + nl[i] + " seconds";
                    else
                        l[i].Text = (i + 1) + ".  " + nl[i] / 60 + " minutes and " + nl[i] % 60 + " seconds";
                }
            }
            else
            {
                h = new Label[hdlv + 1];
                for (int i = 0; i <= hdlv && i <= 6; i++)
                {
                    h[i] = new Label();
                    panel3.Controls.Add(h[i]);
                    h[i].Location = new Point(20, 92 + i * 50);
                    h[i].Size = new Size(400, 100);
                    h[i].ForeColor = Color.White;
                    h[i].Font = new Font("Microsoft Sans Serif", 20);
                    h[i].BackColor = Color.FromArgb(11, 14, 40);
                    h[i].BringToFront();
                    ok = false;
                    if (hl[i] >= 60)
                        ok = true;
                    if (ok == false)
                        h[i].Text = (i + 1) + ".  " + hl[i] + " seconds";
                    else
                        h[i].Text = (i + 1) + ".  " + hl[i] / 60 + " minutes and " + hl[i] % 60 + " seconds";
                }
            }
        }
        public CubeFlip()
        {
            InitializeComponent();
            ezlv = int.Parse(cin.ReadLine());
            hdlv = int.Parse(cin.ReadLine());
            nl = new int[1000];
            hl = new int[1000];
            l = new Label[ezlv];
            h = new Label[hdlv];
            for (int i = 0; i < ezlv && i < 7; i++)
            {
                bool ok = false;
                nl[i] = int.Parse(cin.ReadLine());
                if (nl[i] >= 60)
                    ok = true;
                l[i] = new Label();
                panel2.Controls.Add(l[i]);
                l[i].Location = new Point(20, 92 + i * 50);
                l[i].Size = new Size(400, 100);
                if (ok == false)
                    l[i].Text = (i + 1) + ".  " + nl[i] + " seconds";
                else
                    l[i].Text = (i + 1) + ".  " + nl[i] / 60 + " minutes and " + nl[i] % 60 + " seconds";
                l[i].ForeColor = Color.White;
                l[i].Font = new Font("Microsoft Sans Serif", 20);
                l[i].BackColor = Color.FromArgb(11, 14, 40);
                l[i].BringToFront();

            }
            for (int i = 0; i < hdlv; i++)
            {
                hl[i] = int.Parse(cin.ReadLine());
                bool ok = false;
                if (hl[i] >= 60)
                    ok = true;
                h[i] = new Label();
                panel3.Controls.Add(h[i]);
                h[i].Location = new Point(20, 92 + i * 50);
                h[i].Size = new Size(400, 100);
                if (ok == false)
                    h[i].Text = (i + 1) + ".  " + hl[i] + " seconds";
                else
                    h[i].Text = (i + 1) + ".  " + hl[i] / 60 + " minutes and " + hl[i] % 60 + " seconds";
                h[i].ForeColor = Color.White;
                h[i].Font = new Font("Microsoft Sans Serif", 20);
                h[i].BackColor = Color.FromArgb(11, 14, 40);
                h[i].BringToFront();
            }
            cin.Close();
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Button[,] a;
        int[,] v;
        int x = 4;
        int total = 0;


        void generate(int x)
        {
            a = new Button[x, x];
            watch.Start();
            int n = 701;
            for (int i = 0; i < x; i++, n += 524 / x)
                for (int j = 0, m = 150; j < x; j++, m += 524 / x)
                {
                    a[i, j] = new Button();
                    Controls.Add(a[i, j]);
                    a[i, j].Location = new Point(n, m);
                    a[i, j].Name = "button" + i + "," + j;
                    a[i, j].Size = new Size(480 / x, 480 / x);
                    a[i, j].TabIndex = 17;
                    a[i, j].Text = "";
                    a[i, j].UseVisualStyleBackColor = true;
                    a[i, j].Click += button;
                    a[i, j].BackColor = Color.FromArgb(11, 14, 40);
                    a[i, j].BringToFront();
                }
        }
        private void button(object sender, EventArgs e)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (sender.Equals(a[i, j]))
                    {
                        if (v[i, j] == 0)
                        {
                            a[i, j].BackColor = Color.FromArgb(128, 78, 255);
                            v[i, j] = 1;
                            if (i - 1 >= 0)
                            {
                                a[i - 1, j].BackColor = v[i - 1, j] == 0 ? Color.FromArgb(182, 78, 255) : Color.FromArgb(11, 14, 40);
                                v[i - 1, j] = v[i - 1, j] == 0 ? 1 : 0;
                                total += v[i - 1, j] == 0 ? 1 : -1;
                            }
                            if (i + 1 < x)
                            {
                                a[i + 1, j].BackColor = v[i + 1, j] == 0 ? Color.FromArgb(182, 78, 255) : Color.FromArgb(11, 14, 40);
                                v[i + 1, j] = v[i + 1, j] == 0 ? 1 : 0;
                                total += v[i + 1, j] == 0 ? 1 : -1;
                            }
                            if (j - 1 >= 0)
                            {
                                a[i, j - 1].BackColor = v[i, j - 1] == 0 ? Color.FromArgb(182, 78, 255) : Color.FromArgb(11, 14, 40);
                                v[i, j - 1] = v[i, j - 1] == 0 ? 1 : 0;
                                total += v[i, j - 1] == 0 ? 1 : -1;
                            }
                            if (j + 1 < x)
                            {
                                a[i, j + 1].BackColor = v[i, j + 1] == 0 ? Color.FromArgb(182, 78, 255) : Color.FromArgb(11, 14, 40);
                                v[i, j + 1] = v[i, j + 1] == 0 ? 1 : 0;
                                total += v[i, j + 1] == 0 ? 1 : -1;
                            }
                            total--;
                        }
                        else
                        {
                            a[i, j].BackColor = Color.FromArgb(11, 14, 40);
                            v[i, j] = 0;
                            if (i - 1 >= 0)
                            {
                                a[i - 1, j].BackColor = v[i - 1, j] == 0 ? Color.FromArgb(182, 78, 255) : Color.FromArgb(11, 14, 40);
                                v[i - 1, j] = v[i - 1, j] == 0 ? 1 : 0;
                                total += v[i - 1, j] == 0 ? 1 : -1;
                            }
                            if (i + 1 < x)
                            {
                                a[i + 1, j].BackColor = v[i + 1, j] == 0 ? Color.FromArgb(182, 78, 255) : Color.FromArgb(11, 14, 40);
                                v[i + 1, j] = v[i + 1, j] == 0 ? 1 : 0;
                                total += v[i + 1, j] == 0 ? 1 : -1;
                            }
                            if (j - 1 >= 0)
                            {
                                a[i, j - 1].BackColor = v[i, j - 1] == 0 ? Color.FromArgb(182, 78, 255) : Color.FromArgb(11, 14, 40);
                                v[i, j - 1] = v[i, j - 1] == 0 ? 1 : 0;
                                total += v[i, j - 1] == 0 ? 1 : -1;
                            }
                            if (j + 1 < x)
                            {
                                a[i, j + 1].BackColor = v[i, j + 1] == 0 ? Color.FromArgb(182, 78, 255) : Color.FromArgb(11, 14, 40);
                                v[i, j + 1] = v[i, j + 1] == 0 ? 1 : 0;
                                total += v[i, j + 1] == 0 ? 1 : -1;
                            }
                            total++;
                        }
                    }
                }
            }
            if (total == -x * x)
            {
                watch.Stop();
                if (x == 4)
                {
                    nl[ezlv] = (int)watch.Elapsed.TotalSeconds;
                    Array.Sort(nl, 0, ezlv + 1);
                }

                else
                {
                    hl[hdlv] = (int)watch.Elapsed.TotalSeconds;
                    Array.Sort(hl, 0, hdlv + 1);
                }
                leaderboard(x == 4);
                watch.Reset();
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < x; j++)
                    {
                        a[i, j].Click -= button;
                    }
                for (int i = 0; i <= (x - 1) * 2; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (i - j < x && j < x)
                        {
                            a[i - j, j].BackColor = Color.DeepSkyBlue;
                            wait(200 / x);
                        }

                    }
                }
                for (int i = 0; i <= (x - 1) * 2; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (i - j < x && j < x)
                        {
                            Controls.Remove(a[i - j, j]);
                            wait(200 / x);
                        }

                    }
                }

                pictureBox6.Size = new Size(1920, 1080);
                pictureBox6.Location = new Point(0, 0);
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                if (x == 4)
                    ezlv++;
                else
                    hdlv++;
            }
        }
        private void nmk(object sender, EventArgs e)
        {
        }
        private void playbutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Size = new Size(1920, 1080);
            panel1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox4.Size = new Size(400, 500);
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.BringToFront();
            pictureBox3.BringToFront();

        }
        private void playbutton_MouseEnter(object sender, EventArgs e)
        {
            playbutton.BackColor = Color.DeepSkyBlue;
            playbutton.ForeColor = Color.Black;
        }
        private void playbutton_MouseLeave(object sender, EventArgs e)
        {
            playbutton.BackColor = Color.FromArgb(11, 14, 40);
            playbutton.ForeColor = Color.WhiteSmoke;
        }
        private void Htp_Click(object sender, EventArgs e)
        {
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Size = new Size(1920, 1080);
            pictureBox7.Visible = true;
            pictureBox7.BringToFront();
            panel1.Visible = false;
            button3.Visible = true;
            button3.BringToFront();
        }
        private void Htp_MouseEnter(object sender, EventArgs e)
        {
            Htp.BackColor = Color.FromArgb(182, 78, 255);
            Htp.ForeColor = Color.Black;
        }
        private void Htp_MouseLeave(object sender, EventArgs e)
        {
            Htp.BackColor = Color.FromArgb(11, 14, 40);
            Htp.ForeColor = Color.WhiteSmoke;
        }
        private void settings_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Size = new Size(1920, 1080);
            pictureBox2.Visible = true;
            panel1.Visible = false;
        }
        private void settings_MouseEnter(object sender, EventArgs e)
        {
            settings.BackColor = Color.FromArgb(182, 78, 255);
            settings.ForeColor = Color.Black;
        }
        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.BackColor = Color.FromArgb(11, 14, 40);
            settings.ForeColor = Color.WhiteSmoke;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            StreamWriter cout = new StreamWriter("Scores.dtx");
            Application.Exit();
            cout.WriteLine(ezlv <= 7 ? ezlv : 7);
            cout.WriteLine(hdlv <= 7 ? hdlv : 7);
            for (int i = 0; i < ezlv && i < 7; i++)
                cout.WriteLine(nl[i]);
            for (int i = 0; i < hdlv && i < 7; i++)
                cout.WriteLine(hl[i]);
            cout.Close();
        }
        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(182, 78, 255);
            exit.ForeColor = Color.Black;
        }
        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(11, 14, 40);
            exit.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox5.Visible = true;
            pictureBox5.Size = new Size(1920, 1080);
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.BringToFront();

            x = 4;
            v = new int[x, x];
            generate(x);
            total = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox5.Visible = true;
            pictureBox5.Size = new Size(1920, 1080);
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.BringToFront();

            x = 16;
            v = new int[x, x];
            generate(x);
            total = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter cout = new StreamWriter("Scores.dtx");
            Application.Exit();
            cout.WriteLine(ezlv <= 7 ? ezlv : 7);
            cout.WriteLine(hdlv <= 7 ? hdlv : 7);
            for (int i = 0; i < ezlv && i < 7; i++)
                cout.WriteLine(nl[i]);
            for (int i = 0; i < hdlv && i < 7; i++)
                cout.WriteLine(hl[i]);
            cout.Close();
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(182, 78, 255);
            button2.ForeColor = Color.Black;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(11, 14, 40);
            button2.ForeColor = Color.WhiteSmoke;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            panel1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.Black;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(11, 14, 40);
            button1.ForeColor = Color.WhiteSmoke;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            panel1.Visible = true;
            button3.Visible = false;
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(182, 78, 255);
            button3.ForeColor = Color.Black;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(11, 14, 40);
            button3.ForeColor = Color.WhiteSmoke;
        }
        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Hide();
                panel3.Show();
            }
            else
            {
                panel3.Hide();
                panel2.Show();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}