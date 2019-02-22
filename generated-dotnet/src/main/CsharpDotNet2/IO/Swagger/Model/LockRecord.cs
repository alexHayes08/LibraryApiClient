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
  public class LockRecord {
    /// <summary>
    /// Gets or Sets UnlockedAt
    /// </summary>
    [DataMember(Name="unlockedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unlockedAt")]
    public DateTime? UnlockedAt { get; set; }

    /// <summary>
    /// Gets or Sets LockableId
    /// </summary>
    [DataMember(Name="lockableId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockableId")]
    public string LockableId { get; set; }

    /// <summary>
    /// Gets or Sets OwnerToken
    /// </summary>
    [DataMember(Name="ownerToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerToken")]
    public string OwnerToken { get; set; }

    /// <summary>
    /// Gets or Sets IsShared
    /// </summary>
    [DataMember(Name="isShared", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isShared")]
    public bool? IsShared { get; set; }

    /// <summary>
    /// Gets or Sets LockedAt
    /// </summary>
    [DataMember(Name="lockedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockedAt")]
    public DateTime? LockedAt { get; set; }

    /// <summary>
    /// Gets or Sets MaxLeaseDate
    /// </summary>
    [DataMember(Name="maxLeaseDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxLeaseDate")]
    public DateTime? MaxLeaseDate { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LockRecord {\n");
      sb.Append("  UnlockedAt: ").Append(UnlockedAt).Append("\n");
      sb.Append("  LockableId: ").Append(LockableId).Append("\n");
      sb.Append("  OwnerToken: ").Append(OwnerToken).Append("\n");
      sb.Append("  IsShared: ").Append(IsShared).Append("\n");
      sb.Append("  LockedAt: ").Append(LockedAt).Append("\n");
      sb.Append("  MaxLeaseDate: ").Append(MaxLeaseDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
