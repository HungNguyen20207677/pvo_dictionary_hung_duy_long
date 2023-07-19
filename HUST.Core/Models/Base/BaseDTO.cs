using System;
using System.Linq;
using System.Text.Json.Serialization;

namespace HUST.Core.Models
{
    /// <summary>
    /// Lớp cơ sở cho DTO
    /// </summary>
    public class BaseDTO : BaseModel
    {
        /// <summary>
        /// Thời điểm tạo
        /// </summary>
        [JsonIgnore]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Thời điểm sửa
        /// </summary>
        
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Hàm lấy ra thuộc tính khóa chính
        /// </summary>
        /// <returns>Property khóa chính</returns>
        public System.Reflection.PropertyInfo GetPrimaryKey()
        {
            return this.GetType().GetProperties().FirstOrDefault(x => x.GetCustomAttributes(false).Any(x => x is Dapper.Contrib.Extensions.KeyAttribute));
        }
    }
}
