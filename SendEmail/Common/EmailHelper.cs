using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace SendEmail.Common
{
    public class EmailHelper
    {
        //发件人邮箱
        private static readonly string sendEmail = ConfigurationManager.AppSettings["SendEmail"];
        //发件人密码
        private static readonly string sendEmailPWD = ConfigurationManager.AppSettings["SendEmailPWD"];
        //邮箱服务器
        private static readonly string sendEmailServer = ConfigurationManager.AppSettings["SendEmailServer"];
        //邮箱端口
        private static readonly int sendEmailPort = Convert.ToInt32(ConfigurationManager.AppSettings["SendEmailPort"].ToString());

        #region 发邮件
        /// <summary>
        /// 发邮件
        /// </summary>
        /// <param name="toEmail">收件人</param>
        /// <param name="subject">主题</param>
        /// <param name="body">内容主体</param>
        /// <param name="cc">抄送给谁</param>
        /// <param name="bcc">密送给谁</param>
        /// <param name="isBodyHtml">是否有Body主体</param>
        public static void SendEmail(string toEmail, string subject, string body, string cc, string bcc, bool isBodyHtml = true)
        {
            WebMail.SmtpServer = sendEmailServer; //gmail smtp server
            WebMail.SmtpPort = sendEmailPort; //gmail port to send emails
            WebMail.SmtpUseDefaultCredentials = true;
            WebMail.EnableSsl = true; //sending emails with secure protocol
            WebMail.UserName = sendEmail;//EmailId used to send emails from application(发件人)
            WebMail.Password = sendEmailPWD;//发件人密码（如果开通了授权码就要使用授权密码）
            WebMail.From = sendEmail; //email sender email address.
            WebMail.Send(to: toEmail, subject: subject, body: body, cc: cc, bcc: bcc, isBodyHtml: isBodyHtml);

        }
        #endregion
    }
}