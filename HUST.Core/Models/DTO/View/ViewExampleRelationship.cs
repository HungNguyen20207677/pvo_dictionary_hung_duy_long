using Dapper.Contrib.Extensions;
using System;
using System.Text.Json.Serialization;

namespace HUST.Core.Models.DTO
{
    public class ViewExampleRelationship
    {
        public Guid? ConceptId { get; set; }

        public Guid? ExampleLinkId { get; set; }


        [JsonIgnore] 
        public Guid? DictionaryId { get; set; }

        [JsonIgnore]
        public string Concept { get; set; }

        [JsonIgnore]
        public Guid? ExampleId { get; set; }

        [JsonIgnore]
        public string Detail { get; set; }

        [JsonIgnore]
        public string DetailHtml { get; set; }


        [JsonIgnore]
        public string ExampleLinkName { get; set; }

        [JsonIgnore]
        public DateTime? ConceptCreatedDate { get; set; }

        [JsonIgnore]
        public DateTime? ExampleCreatedDate { get; set; }

        [JsonIgnore]
        public DateTime? RelationCreatedDate { get; set; }
    }
}
