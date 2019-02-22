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
  public class UnlockResponse {
    /// <summary>
    /// Gets or Sets Lockable
    /// </summary>
    [DataMember(Name="lockable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockable")]
    public Lockable Lockable { get; set; }

    /// <summary>
    /// Gets or Sets LockRecord
    /// </summary>
    [DataMember(Name="lockRecord", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockRecord")]
    public LockRecord LockRecord { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnlockResponse {\n");
      sb.Append("  Lockable: ").Append(Lockable).Append("\n");
      sb.Append("  LockRecord: ").Append(LockRecord).Append("\n");
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
