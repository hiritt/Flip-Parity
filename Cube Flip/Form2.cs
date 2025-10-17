using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cube_Flip
{
    public partial class Form2 : Form
    {
        public class User
        {
            public string username;
            public string password;
        };
        User[] client;
        int n;
        public Form2()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("data.dtx");
            n = int.Parse(sr.ReadLine());
            client = new User[n + 1];
            for (int i = 0; i < n; i++)
            {
                client[i] = new User();
                client[i].username = sr.ReadLine();
                client[i].password = sr.ReadLine();
            }
            sr.Close();
        }
        void save()
        {
            using (StreamWriter sw = new StreamWriter("data.dtx"))
            {
                sw.WriteLine(n);
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(client[i].username);
                    sw.WriteLine(client[i].password);
                }
                sw.Close();
            }
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
        private void me(object sender, EventArgs e)
        {
            playbutton.BackColor = Color.DeepSkyBlue;
            playbutton.ForeColor = Color.Black;
        }
        private void ml(object sender, EventArgs e)
        {
            playbutton.BackColor = Color.FromArgb(11, 14, 40);
            playbutton.ForeColor = Color.WhiteSmoke;
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            Form form = new CubeFlip();
            playbutton.Visible = false;
            Opacity = 0;
            form.Show();
        }
        private void lme(object sender, EventArgs e)
        {
            LogInButton.BackColor = Color.FromArgb(182, 78, 255);
            LogInButton.ForeColor = Color.Black;
        }
        private void lml(object sender, EventArgs e)
        {
            LogInButton.BackColor = Color.Transparent;
            LogInButton.ForeColor = Color.WhiteSmoke;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string inputString = password.Text;
            byte[] data = System.Text.Encoding.UTF8.GetBytes(inputString);
            byte[] hashBytes = System.Security.Cryptography.SHA256.HashData(data);
            string hash = BitConverter.ToString(hashBytes).Replace("-", "");
            for (int i = 0; i < n; i++)
            {
                if (username.Text == client[i].username && hash == client[i].password)
                {
                    StreamWriter sw = new StreamWriter("currentuser.dtx");
                    sw.WriteLine(username.Text);
                    sw.Close();
                    Form form = new CubeFlip();
                    Opacity = 0;
                    form.Show();
                    return;
                }
            }
        }

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void cme(object sender, EventArgs e)
        {
            CreateAcc.ForeColor = Color.DeepSkyBlue;
        }
        private void cml(object sender, EventArgs e)
        {
            CreateAcc.ForeColor = Color.WhiteSmoke;
        }
        private void SignUp_Click(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < n && found == false; i++)
            {
                if (client[i].username == textBox2.Text)
                {
                    // Username already exists
                    label1.Visible = true;
                    wait(2500);
                    label1.Visible = false;
                    found = true;
                }
            }
            if (found == false)
            {
                string inputString = textBox1.Text;
                byte[] data = System.Text.Encoding.UTF8.GetBytes(inputString);
                byte[] hashBytes = System.Security.Cryptography.SHA256.HashData(data);
                string hash = BitConverter.ToString(hashBytes).Replace("-", "");
                n++;
                Array.Resize(ref client, n);
                client[n - 1] = new User();
                client[n - 1].username = textBox2.Text;
                client[n - 1].password = hash;
                panel1.Visible = false;
                label2.Visible = true;
                wait(2500);
                label2.Visible = false;
                username.Text = textBox2.Text;
                password.Text = textBox1.Text;
                save();
            }
        }
        private void sume(object sender, EventArgs e)
        {
            SignUp.BackColor = Color.FromArgb(182, 78, 255);
            SignUp.ForeColor = Color.Black;
        }
        private void suml(object sender, EventArgs e)
        {
            SignUp.BackColor = Color.Transparent;
            SignUp.ForeColor = Color.WhiteSmoke;
        }
        private void AlrdAcc_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void aame(object sender, EventArgs e)
        {
            AlrdAcc.ForeColor = Color.DeepSkyBlue;
        }
        private void aaml(object sender, EventArgs e)
        {
            AlrdAcc.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
