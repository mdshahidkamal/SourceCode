using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Helpers
{
    public static class EmailClient
    {
        public static void SendMail(string strmessage)
        {
            try
            {
                //Task.Run(() => {
                //    MailMessage mail = new MailMessage("support@moskit.in", "support@moskit.in");
                //    SmtpClient client = new SmtpClient();
                //    client.Port = 587;
                //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //    //client.UseDefaultCredentials = false;
                //    client.Credentials = new System.Net.NetworkCredential("support@moskit.in", "pqvoJOjvA1");
                //    client.Host = "smtp.moskit.in";
                //    mail.Subject = "##Error## | " + Common.ClientName;
                //    mail.Body = strmessage;
                //    client.Send(mail);
                //});

                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
