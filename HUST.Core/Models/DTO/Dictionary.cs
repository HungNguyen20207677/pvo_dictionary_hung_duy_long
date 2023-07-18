using Dapper.Contrib.Extensions;
using System;
using System.Text.Json.Serialization;

namespace HUST.Core.Models.DTO
{
    /// <summary>
    /// Bảng dictionary: Bảng chứa thông tin dictionary
    /// </summary>
    public class Dictionary : BaseDTO
    {
        /// <summary>
        /// Id khóa chính
        /// </summary>
        [Key]
        public Guid DictionaryId { get; set; }

        /// <summary>
        /// Id người dùng
        /// </summary>
        [JsonIgnore]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Tên
        /// </summary>
        public string DictionaryName { get; set; }

        /// <summary>
        /// Lần cuối truy cập
        /// </summary>
        [JsonIgnore]
        public DateTime? LastViewAt { get; set; }
    }
}
