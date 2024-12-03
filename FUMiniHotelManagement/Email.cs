using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FUMiniHotelManagement
{
    public class Email
    {

        public static void SendEmail(string to, string subject, string body)
        {
            try
            {

                var fromAddress = new MailAddress("ducdmhe181735@fpt.edu.vn");
                var toAddress = new MailAddress(to);
                const string fromPassword = "afux tpky avpr vqpa";
                const string smtpHost = "smtp.gmail.com";
                const int smtpPort = 587;


                var smtp = new SmtpClient
                {
                    Host = smtpHost,
                    Port = smtpPort,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };


                var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                };

                smtp.Send(message);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
