using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace CSD207_Project_System
{
    public partial class Register : UserControl
    {

        public static string CODE = null;
        public static string emailPattern = @"^[\w-\.]+@gmail\.com";
        public static Regex rg = new Regex(emailPattern);
        public Register()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var p = this.Parent.Parent as Main;
            if (p != null)
            {
                var loginPanel = p.Controls["loginPanel"];
                loginPanel.Controls.Clear();
                loginPanel.Controls.Add(new Login());
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
            msg.To.Add(MailboxAddress.Parse(email.Text));

            msg.Subject = "Verification Code";
            msg.Body = new TextPart("plain")
            {
                Text = $"Your verification code is {CODE}"
            };

            SmtpClient client = new SmtpClient();

            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("sbducao.3@gmail.com", "yiey xpgd vgwu qzba");
                client.Send(msg);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                client.Disconnect(true);
                client.Dispose();
                email.TextChanged -= email_TextChanged;
                sendBtn.Enabled = false;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            sendBtn.Enabled = rg.IsMatch(email.Text);
        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            regBtn.Enabled = CODE.Equals(code.Text);
        }
    }
}
