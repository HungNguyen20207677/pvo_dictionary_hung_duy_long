using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUST.Core.Models.Param
{
    /// <summary>
    /// Param xử lý cập nhật thông tin người dùng
    /// </summary>
    public class UpdateUserInfoParam
    {
        public string displayName { get; set; }
        public string fullName { get; set; }
        public string birthday { get; set; }
        public string position { get; set; }
        public IFormFile avatar { get; set; }
    }
}
