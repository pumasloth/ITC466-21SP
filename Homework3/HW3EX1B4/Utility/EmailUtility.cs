namespace HW3EX1B4.Utility
{
    using HW3EX1B4.Properties;
    using System.Net.Mail;
    using System;

    /// <summary>
    /// The email utility.
    /// </summary>
    public static class EmailUtility
    {
        /// <summary>
        ///  Send the email.
        /// </summary>
        /// <param name="toEmailAddress">The email address to send to.</param>
        /// <param name="obj">The email object to include in the body.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the toEmailAddress is null or empty or obj is null.
        /// </exception>
        public static void SendEmail(string toEmailAddress, object obj)
        {
            if (string.IsNullOrEmpty(toEmailAddress))
            {
                throw new ArgumentNullException(nameof(toEmailAddress));
            }

            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            using (var message = new MailMessage(Settings.Default.EmailFromAddress, toEmailAddress))
            using (var client = new SmtpClient(Settings.Default.EmailServer))
            {
                message.Subject = string.Format(Settings.Default.EmailSubject, DateTime.Now);
                message.Body = string.Format(Settings.Default.EmailBody, Environment.NewLine, obj);

                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Logger.Error("Problem sending notification email", ex);
                }
            }
        }
    }
}