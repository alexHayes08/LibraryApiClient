using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Lockable.
  /// </summary>
  [DataContract]
  public class Lockable {
    /// <summary>
    /// Gets or sets the locks.
    /// </summary>
    /// <value>Gets or sets the locks.</value>
    [DataMember(Name="locks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locks")]
    public List<ModelLock> Locks { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>Gets or sets the name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the created on.
    /// </summary>
    /// <value>Gets or sets the created on.</value>
    [DataMember(Name="createdOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdOn")]
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// Gets or sets the categories.
    /// </summary>
    /// <value>Gets or sets the categories.</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<string> Categories { get; set; }

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>Gets or sets the data.</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Object Data { get; set; }

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
      sb.Append("class Lockable {\n");
      sb.Append("  Locks: ").Append(Locks).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
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
