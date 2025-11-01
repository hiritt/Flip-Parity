using System.CodeDom.Compiler;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace Cube_Flip
{
    public partial class CubeFlip : Form
    {
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        int ezlv = 0, hdlv = 0;
        public struct leader
        {
            public string username;
            public int time;
        }
        leader[] eazylevel, hardlevel;
        public struct curent
        {
            public string username;
            public int eazytime, hardtime;
            public int eazyposition, hardposition;
        }
        curent curentuser;
        Label[] l, h;
        void leaderboard(int difct)
        {
            bool ok = false;
            if (difct == 4)
            {
                l = new Label[ezlv];
                for (int i = 0; i < ezlv && i < 10; i++)
                {
                    l[i] = new Label();
                    panel2.Controls.Add(l[i]);
                    l[i].Location = new Point(20, 92 + i * 50);
                    l[i].Size = new Size(400, 100);
                    l[i].ForeColor = Color.White;
                    l[i].Font = new Font("Microsoft Sans Serif", 20);
                    l[i].BackColor = Color.Transparent;
                    l[i].BringToFront();
                    ok = false;
                    if (eazylevel[i].time >= 1000)
                        ok = true;
                    if (ok == false)
                        l[i].Text = (i + 1) + ".  " + eazylevel[i].username + " " + eazylevel[i].time + " ms";
                    else
                        l[i].Text = (i + 1) + ".  " + eazylevel[i].username + " " + (double)eazylevel[i].time / 1000.0 + " s";
                }
            }
            if(difct == 16)
            {
                h = new Label[hdlv];
                for (int i = 0; i < hdlv && i < 10; i++)
                {
                    h[i] = new Label();
                    panel3.Controls.Add(h[i]);
                    h[i].Location = new Point(20, 92 + i * 50);
                    h[i].Size = new Size(400, 100);
                    h[i].ForeColor = Color.White;
                    h[i].Font = new Font("Microsoft Sans Serif", 20);
                    h[i].BackColor = Color.Transparent;
                    h[i].BringToFront();
                    ok = false;
                    if (hardlevel[i].time >= 1000)
                        ok = true;
                    if (ok == false)
                        h[i].Text = (i + 1) + ".  " + hardlevel[i].username + " " + hardlevel[i].time + " ms";
                    else
                        h[i].Text = (i + 1) + ".  " + hardlevel[i].username + " " + (double)hardlevel[i].time / 1000.0 + " s";
                }
            }
        }
        public CubeFlip()
        {
            StreamReader cin = new StreamReader("Scores.dtx");
            StreamReader cin2 = new StreamReader("curentuser.dtx");
            InitializeComponent();
            panel1.Size = new Size(1920, 1080);
            curentuser = new curent();
            curentuser.username = cin2.ReadLine();
            curentuser.eazytime = -1;
            curentuser.hardtime = -1;
            curentuser.eazyposition = -1;
            curentuser.hardposition = -1;
            cin2.Close();
            this.Text = "Flip Parity";
            ezlv = int.Parse(cin.ReadLine());
            hdlv = int.Parse(cin.ReadLine());
            eazylevel = new leader[ezlv + 1];
            hardlevel = new leader[hdlv + 1];
            l = new Label[ezlv];
            h = new Label[hdlv];
            for (int i = 0; i < ezlv; i++)
            {

                eazylevel[i].username = cin.ReadLine();
                eazylevel[i].time = int.Parse(cin.ReadLine());
                if (curentuser.username == eazylevel[i].username)
                {
                    curentuser.eazytime = eazylevel[i].time;
                    curentuser.eazyposition = i + 1;
                }
                if (i < 10)
                {
                    bool ok = false;
                    if (eazylevel[i].time >= 1000)
                        ok = true;
                    l[i] = new Label();
                    panel2.Controls.Add(l[i]);
                    l[i].Location = new Point(20, 92 + i * 50);
                    l[i].Size = new Size(400, 100);
                    if (ok == false)
                        l[i].Text = (i + 1) + ".  " + eazylevel[i].username + " " + eazylevel[i].time + "ms";
                    else
                        l[i].Text = (i + 1) + ".  " + eazylevel[i].username + " " + (double)eazylevel[i].time / 1000.0 + "s";
                    l[i].ForeColor = Color.White;
                    l[i].Font = new Font("Microsoft Sans Serif", 20);
                    l[i].BackColor = Color.Transparent;
                    l[i].BringToFront();
                }
            }
            for (int i = 0; i < hdlv; i++)
            {
                hardlevel[i].username = cin.ReadLine();
                hardlevel[i].time = int.Parse(cin.ReadLine());
                if (curentuser.username == hardlevel[i].username)
                {
                    curentuser.hardtime = hardlevel[i].time;
                    curentuser.hardposition = i + 1;
                }
                if (i < 10)
                {
                    bool ok = false;
                    if (hardlevel[i].time >= 1000)
                        ok = true;
                    h[i] = new Label();
                    panel3.Controls.Add(h[i]);
                    h[i].Location = new Point(20, 92 + i * 50);
                    h[i].Size = new Size(400, 100);
                    if (ok == false)
                        h[i].Text = (i + 1) + ".  " + hardlevel[i].username + " " + hardlevel[i].time + "ms";
                    else
                        h[i].Text = (i + 1) + ".  " + hardlevel[i].username + " " + (double)hardlevel[i].time / 1000.0 + "s";
                    h[i].ForeColor = Color.White;
                    h[i].Font = new Font("Microsoft Sans Serif", 20);
                    h[i].BackColor = Color.Transparent;
                    h[i].BringToFront();
                }
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
        int x=5;
        int total = 0;


        void generate(int x)
        {
            a = new Button[x, x];
           // MessageBox.Show(Convert.ToString(x));
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
            loadingscreen.Visible = false;
            watch.Start();
        }
        private void button(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(x));
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
                    if (curentuser.eazytime == -1)
                    {
                        curentuser.eazytime = (int)watch.Elapsed.TotalMilliseconds;
                        eazylevel[ezlv].username = curentuser.username;
                        eazylevel[ezlv].time = (int)watch.Elapsed.TotalMilliseconds;
                        ezlv++;
                    }
                    if (curentuser.eazytime > (int)watch.Elapsed.TotalMilliseconds)
                    {
                        curentuser.eazytime = (int)watch.Elapsed.TotalMilliseconds;
                        eazylevel[curentuser.eazyposition - 1].time = curentuser.eazytime;
                    }
                    Array.Sort(eazylevel, 0, ezlv, Comparer<leader>.Create((x, y) => x.time.CompareTo(y.time)));
                    for (int i = 0; i < ezlv; i++)
                    {
                        if (eazylevel[i].username == curentuser.username)
                        {
                            curentuser.eazyposition = i + 1;
                            break;
                        }
                    }
                }

                if(x==16)
                {
                    if (curentuser.hardtime == -1)
                    {
                        curentuser.hardtime = (int)watch.Elapsed.TotalMilliseconds;
                        hardlevel[hdlv].username = curentuser.username;
                        hardlevel[hdlv].time = (int)watch.Elapsed.TotalMilliseconds;
                        hdlv++;
                    }
                    if (curentuser.hardtime > (int)watch.Elapsed.TotalMilliseconds)
                    {
                        curentuser.hardtime = (int)watch.Elapsed.TotalMilliseconds;
                        hardlevel[curentuser.hardposition - 1].time = curentuser.hardtime;
                    }
                    Array.Sort(hardlevel, 0, hdlv, Comparer<leader>.Create((x, y) => x.time.CompareTo(y.time)));
                    for (int i = 0; i < hdlv; i++)
                    {
                        if (hardlevel[i].username == curentuser.username)
                        {
                            curentuser.hardposition = i + 1;
                            break;
                        }
                    }
                }
                leaderboard(x);

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
                if (watch.Elapsed.TotalMilliseconds < 1000)
                    label3.Text = (int)watch.Elapsed.TotalMilliseconds + " ms";
                else
                    label3.Text = (float)((int)watch.Elapsed.TotalMilliseconds) / 1000.0 + " s";
                label3.Visible = true;
                watch.Reset();
                pictureBox6.Size = new Size(1920, 1080);
                pictureBox6.Location = new Point(0, 0);
                pictureBox6.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
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
            hardbutton.Size = new Size(400, 500);
            hardbutton.Visible = true;
            easybutton.Visible = true;
            label1.Visible = true;
            label1.BringToFront();
            hardbutton.BringToFront();
            easybutton.BringToFront();

        }
        private void playbutton_MouseEnter(object sender, EventArgs e)
        {
            playbutton.BackColor = Color.FromArgb(182, 78, 255);
            playbutton.ForeColor = Color.Transparent;
        }
        private void playbutton_MouseLeave(object sender, EventArgs e)
        {
            playbutton.BackColor = Color.Transparent;
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
            Htp.BackColor = Color.Transparent;
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
            settings.BackColor = Color.Transparent;
            settings.ForeColor = Color.WhiteSmoke;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            StreamWriter cout = new StreamWriter("Scores.dtx");
            Application.Exit();
            cout.WriteLine(ezlv);
            cout.WriteLine(hdlv);
            for (int i = 0; i < ezlv; i++)
            {
                cout.WriteLine(eazylevel[i].username);
                cout.WriteLine(eazylevel[i].time);
            }
            for (int i = 0; i < hdlv; i++)
            {
                cout.WriteLine(hardlevel[i].username);
                cout.WriteLine(hardlevel[i].time);
            }
            cout.Close();
        }
        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(182, 78, 255);
            exit.ForeColor = Color.Black;
        }
        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = Color.Transparent;
            exit.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadingscreen.BringToFront();
            loadingscreen.Size = new Size(1920, 1080);
            loadingscreen.Visible = true;
            button3.Visible = false;
            easybutton.Visible = false;
            hardbutton.Visible = false;
            pictureBox2.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;

            x = 4;
            v = new int[x, x];
            total = 0;
            generate(x);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadingscreen.BringToFront();
            loadingscreen.Size = new Size(1920, 1080);
            loadingscreen.Visible = true;
            button3.Visible = false;
            easybutton.Visible = false;
            hardbutton.Visible = false;
            pictureBox2.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
            x = 16;
            v = new int[x, x];
            total = 0;
            generate(x);

        }
        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.BringToFront();
            button4.Visible = true;
            button4.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
                if (textBox1.Text[i] < '0' || textBox1.Text[i] > '9')
                    return;
            x = int.Parse(textBox1.Text);
            if (x > 0 && x <= 20)
            {
                loadingscreen.BringToFront();
                loadingscreen.Size = new Size(1920, 1080);
                loadingscreen.Visible = true;
                button3.Visible = false;
                easybutton.Visible = false;
                hardbutton.Visible = false;
                pictureBox2.Visible = false;
                button4.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                v = new int[x, x];
                total = 0;
                generate(x);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter cout = new StreamWriter("Scores.dtx");
            Application.Exit();
            cout.WriteLine(ezlv);
            cout.WriteLine(hdlv);
            for (int i = 0; i < ezlv; i++)
            {
                cout.WriteLine(eazylevel[i].username);
                cout.WriteLine(eazylevel[i].time);
            }
            for (int i = 0; i < hdlv; i++)
            {
                cout.WriteLine(hardlevel[i].username);
                cout.WriteLine(hardlevel[i].time);
            }
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
            label3.Visible = false;
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

        private void settings_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        
    }
}