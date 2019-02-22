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
  public class PaginationResultsRandomDataCollection {
    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name="results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results")]
    public List<RandomDataCollection> Results { get; set; }

    /// <summary>
    /// Gets or Sets Next
    /// </summary>
    [DataMember(Name="next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next")]
    public PaginateRandomDataCollection Next { get; set; }

    /// <summary>
    /// Gets or Sets Previous
    /// </summary>
    [DataMember(Name="previous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous")]
    public PaginateRandomDataCollection Previous { get; set; }

    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public long? TotalCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaginationResultsRandomDataCollection {\n");
      sb.Append("  Results: ").Append(Results).Append("\n");
      sb.Append("  Next: ").Append(Next).Append("\n");
      sb.Append("  Previous: ").Append(Previous).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
