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
  public class UnlockRequest {
    /// <summary>
    /// Gets or Sets LockableId
    /// </summary>
    [DataMember(Name="lockableId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockableId")]
    public string LockableId { get; set; }

    /// <summary>
    /// Gets or Sets LockId
    /// </summary>
    [DataMember(Name="lockId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockId")]
    public string LockId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnlockRequest {\n");
      sb.Append("  LockableId: ").Append(LockableId).Append("\n");
      sb.Append("  LockId: ").Append(LockId).Append("\n");
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
