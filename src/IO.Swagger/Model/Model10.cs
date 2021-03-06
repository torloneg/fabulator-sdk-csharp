/* 
 * Fabulator API
 *
 * Endpoint Fabulator project
 *
 * OpenAPI spec version: 1.0.0
 * Contact: torloneg@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Model10
    /// </summary>
    [DataContract]
    public partial class Model10 :  IEquatable<Model10>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model10" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Model10() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Model10" /> class.
        /// </summary>
        /// <param name="field">field (required) (default to &quot;tag&quot;).</param>
        /// <param name="dir">dir (required).</param>
        public Model10(string field = "tag", decimal? dir = default(decimal?))
        {
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new InvalidDataException("field is a required property for Model10 and cannot be null");
            }
            else
            {
                this.Field = field;
            }
            // to ensure "dir" is required (not null)
            if (dir == null)
            {
                throw new InvalidDataException("dir is a required property for Model10 and cannot be null");
            }
            else
            {
                this.Dir = dir;
            }
        }
        
        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Gets or Sets Dir
        /// </summary>
        [DataMember(Name="dir", EmitDefaultValue=false)]
        public decimal? Dir { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model10 {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Dir: ").Append(Dir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Model10);
        }

        /// <summary>
        /// Returns true if Model10 instances are equal
        /// </summary>
        /// <param name="input">Instance of Model10 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model10 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Dir == input.Dir ||
                    (this.Dir != null &&
                    this.Dir.Equals(input.Dir))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Dir != null)
                    hashCode = hashCode * 59 + this.Dir.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
