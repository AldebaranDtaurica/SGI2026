using System;
using System.Net;
using System.Net.Mail;


namespace CapaServicios
{
    public static class CSR_EnviarMail
    {
        private static readonly string from = "azsolucionesgnd@Gmail.com";
        private static readonly string smtp = "smtp.gmail.com";
        private static readonly int smtpPortTls = 587;
        //private static readonly int smtpPortSsl = 465;
        private static readonly string smtpPass = "dajilkcnnpbaasyr";
        public static void SendMail(string to, string asunto, string body)
        {
            string displayName = "Recuperacion de Cuenta";
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName)
                };
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient(smtp, smtpPortTls)
                {
                    Credentials = new NetworkCredential(from, smtpPass),
                    EnableSsl = true
                };
                client.Send(mail);
            }
            catch
            {
                throw new Exception("ERROR AL ENVIAR EL MENSAJE. \n \n " +
                    "Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.");
            }
        }
        public static void SendMail(string cc, string asunto, string msj, string body)
        {
            string displayName = asunto;
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName)
                };
                mail.To.Add(from);
                mail.CC.Add(cc);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient(smtp, smtpPortTls)
                {
                    Credentials = new NetworkCredential(from, smtpPass),
                    EnableSsl = true
                };
                client.Send(mail);
            }
            catch
            {
                throw new Exception("ERROR AL ENVIAR EL MENSAJE. \n \n " +
                    "Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.");
            }
        }
    }
}