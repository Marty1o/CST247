using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Activity1Part3.Models
{
    [DataContract]
    public class UserModel
    {
        private static Logger logger = LogManager.GetLogger("myAppLoggerRules");

        [Required]
        [DisplayName("User Name")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        [DataMember]

        public string Username { get; set; }

        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        [DataMember]

        public string Password { get; set; }

        public UserModel()
        {
            this.Username = "";
            this.Password = "";
        }

        public UserModel(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

    }
}