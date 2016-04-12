using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SendEmail.Models
{
    public class EmployeeModel
    {
        /// <summary>
        /// 发送给谁
        /// </summary>
        [DataType(DataType.EmailAddress), Display(Name = "To")]
        [Required]
        public string ToEmail { get; set; }


        /// <summary>
        /// 邮件正文
        /// </summary>

        [Display(Name = "Body")]
        [DataType(DataType.MultilineText)]
        public string EMailBody { get; set; }


        /// <summary>
        /// 邮件主题
        /// </summary>
        [Display(Name = "Subject")]
        public string EmailSubject { get; set; }

        /// <summary>
        /// 抄送给谁
        /// </summary>
        [DataType(DataType.EmailAddress)]
        [Display(Name = "CC")]
        public string EmailCC { get; set; }


        /// <summary>
        /// 密送给谁
        /// </summary>
        [DataType(DataType.EmailAddress)]
        [Display(Name = "BCC")]
        public string EmailBCC { get; set; }  
    }
}