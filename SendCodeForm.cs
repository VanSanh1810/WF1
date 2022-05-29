using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class SendCodeForm : Form
    {
        
        string randCode;
        public static string to;
        public SendCodeForm()
        {
            InitializeComponent();
            textBox1.Focus();
            //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (textBox1.Text).ToString();
            from = "sanhnguyen734@gmail.com";
            pass = "0947782733sanh";
            messageBody = "Your reset code is: " + randCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reset Code ";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Success !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n\n" + ex.StackTrace, "Exception");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(randCode == (textBox2.Text).ToString())
            {
                to = textBox1.Text;
                ResetPass resetPass = new ResetPass();
                this.Hide();
                resetPass.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code !");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                this.button2_Click(sender, e);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.button2_Click(sender, e);
            }
        }
    }
}
