using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlTypes;

namespace HUST.Core.Models.DTO
{
    /// <summary>
    /// Bảng user: Bảng thông tin user
    /// </summary>
    public class Concept_search_history : BaseDTO
    {
        ///// <summary>
        ///// Id khóa chính
        ///// </summary>
        //[Key]
        //public Guid concept_search_history_id { get; set; }

        ///// <summary>
        ///// Id người dùng
        ///// </summary>
        //public Guid user_id { get; set; }

        ///// <summary>
        ///// Id dictionary
        ///// </summary>
        //public Guid dictionary_id { get; set; }

        /// <summary>
        /// list_concept_search
        /// </summary>
        public SqlString list_concept_search { get; set; }
    }
}
