using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HueApi.Models
{
  [DebuggerDisplay("{Type} | {IdV1} | {Id}")]
  public class HueResource
  {
    [JsonPropertyName("id")]
    public Guid Id { get; set; } = default!;

    [JsonPropertyName("id_v1")]
    public string? IdV1 { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("metadata")]
    public Metadata? Metadata { get; set; } = default!;

    [JsonPropertyName("creation_time")]
    public DateTimeOffset? CreationTime { get; set; }

    [JsonExtensionData]
    public Dictionary<string, JsonElement> ExtensionData { get; set; } = new();
  }
}
