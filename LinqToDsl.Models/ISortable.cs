﻿using System.Text.Json.Serialization;

namespace LinqToDsl.Models
{
    public interface ISortable
    {
        [JsonPropertyName("id")]
        string Id { get; set; }

        [JsonPropertyName("sortOrder")]
        int SortOrder { get; set; }
    }
}
