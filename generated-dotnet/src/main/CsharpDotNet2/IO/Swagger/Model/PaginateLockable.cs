using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaginateLockable {
    /// <summary>
    /// Gets or Sets OrderBy
    /// </summary>
    [DataMember(Name="orderBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderBy")]
    public SortDefinitionLockable OrderBy { get; set; }

    /// <summary>
    /// Gets or Sets Filter
    /// </summary>
    [DataMember(Name="filter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter")]
    public FilterDefinitionLockable Filter { get; set; }

    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Gets or Sets Skip
    /// </summary>
    [DataMember(Name="skip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skip")]
    public int? Skip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaginateLockable {\n");
      sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Skip: ").Append(Skip).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
