using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace CSD207_Project_System
{
    public partial class Register : UserControl
    {

        private static string CODE = null;
        private static string emailPattern = @"^[\w-\.]+@gmail\.com";
        private static Regex rg = new Regex(emailPattern);

        private System.Timers.Timer cooldownTimer;
        private int remainingCooldownTime;
        private UserModel users;

        public Register()
        {
            InitializeComponent();

            remainingCooldownTime = 120; 
            cooldownTimer = new System.Timers.Timer(1000);
            cooldownTimer.Elapsed += OnCooldownTick;
            users = new UserModel();

            regUsername.TextChanged += ValidateForm;
            regGmail.TextChanged += ValidateForm;
            regPassword.TextChanged += ValidateForm;
            regPassword2.TextChanged += ValidateForm;
            regCode.TextChanged += ValidateForm;
        }

        private void loginBtn_LinkClicked(object sender, EventArgs e)
        {
            var p = this.Parent.Parent as Main;
            if (p != null)
            {
                var loginPanel = p.Controls["loginPanel"];
                loginPanel.Controls.Clear();
                loginPanel.Controls.Add(new Login());
            }

        }

        private void StartCooldown()
        {
            cooldownTimer.Start();
            sendBtn.Text = $"{remainingCooldownTime}s";
        }

        private void OnCooldownTick(object sender, ElapsedEventArgs e)
        {
            if (remainingCooldownTime > 0)
            {
                remainingCooldownTime--;
                sendBtn.Invoke((MethodInvoker)delegate {
                    sendBtn.Text = $"{remainingCooldownTime}s";
                });
            }
            else
            {
                cooldownTimer.Stop();
                sendBtn.Invoke((MethodInvoker)delegate {
                    sendBtn.Enabled = true;
                    sendBtn.Text = "Send";
                });
                remainingCooldownTime = 120;
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            sendMail();
        }

        private void sendMail()
        {
            var rnd = new Random();
            CODE = rnd.Next(10000, 99999).ToString();
            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress("NO_REPLY", "noreplyducao@gmail.com"));
            msg.To.Add(MailboxAddress.Parse(regGmail.Text));

            msg.Subject = "Verification Code";
            msg.Body = new TextPart("html")
            {
                Text = $"<h1>Your verification code is {CODE}.</h1>"
            };

            SmtpClient client = new SmtpClient();

            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("noreplyducao@gmail.com", "qaoc uufj btpe cfpt");
                client.Send(msg);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                client.Disconnect(true);
                client.Dispose();
                regGmail.TextChanged -= email_TextChanged;
                sendBtn.Enabled = false;
                StartCooldown();
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            sendBtn.Enabled = rg.IsMatch(regGmail.Text);
        }

        private async void ValidateForm(object sender, EventArgs e)
        {
            bool isUsernameValid = !string.IsNullOrEmpty(regUsername.Text);
            bool isEmailValid = rg.IsMatch(regGmail.Text);
            bool isPasswordValid = regPassword.Text == regPassword2.Text;
            bool isPasswordLong = regPassword.Text.Length >= 5;
            passMsg.Text = isPasswordLong && !isPasswordValid ? "Password is not similar." : "";

            bool isCodeValid = regCode.Text.Equals(CODE);
            bool isAvailable = await users.UsernameExists(regUsername.Text);
            userMsg.Text = !isAvailable ? "" : "Username already exists";

            regBtn.Enabled = isUsernameValid && isEmailValid && isPasswordValid && isCodeValid && !isAvailable && isPasswordLong;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                UserName = regUsername.Text,
                Gmail = regGmail.Text,
                Password = regPassword.Text,
                DisplayName = regUsername.Text,
            };

            Task.Run(async () =>
            {
                await users.Insert(u);
                MessageBox.Show($"User {u.UserName} added!");
                Clear();
            });
        }

        private void Clear()
        {
            regUsername.Text = "";
            regPassword.Text = "";
            regPassword2.Text = "";
            regGmail.Text = "";
            regCode.Text = "";
        }
    }
}
