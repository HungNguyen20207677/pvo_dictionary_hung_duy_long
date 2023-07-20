using Dapper.Contrib.Extensions;
using System.Data.SqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUST.Core.Models.Entity
{
    /// <summary>
    /// Bảng user: Bảng thông tin concept_search_history
    /// </summary>
    [System.ComponentModel.DataAnnotations.Schema.Table("concept_search_history")]
    public class concept_search_history : BaseEntity
    {
        /// <summary>
        /// Id khóa chính
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key, ExplicitKey]
        public Guid concept_search_history_id { get; set; }

        /// <summary>
        /// Id nguười dùng
        /// </summary>
        public Guid user_id { get; set; }

        /// <summary>
        /// Id từ điển
        /// </summary>
        public Guid dictionary_id { get; set; }

        /// <summary>
        /// Danh sách search concept history
        /// </summary>
        public SqlString list_concept_search { get; set; } 
    }
}
