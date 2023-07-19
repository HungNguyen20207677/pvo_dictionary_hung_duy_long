using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUST.Core.Models.Param
{
    public class ResetPasswordParam
    {
        public string verificationToken { get; set; }
        public string NewPassword { get; set; }
    }
}
