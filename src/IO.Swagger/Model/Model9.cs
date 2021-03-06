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
    /// Model9
    /// </summary>
    [DataContract]
    public partial class Model9 :  IEquatable<Model9>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model9" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Model9() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Model9" /> class.
        /// </summary>
        /// <param name="select">select (required) (default to &quot;{}&quot;).</param>
        /// <param name="order">order.</param>
        /// <param name="query">query (required) (default to &quot;{}&quot;).</param>
        public Model9(string select = "{}", Order order = default(Order), string query = "{}")
        {
            // to ensure "select" is required (not null)
            if (select == null)
            {
                throw new InvalidDataException("select is a required property for Model9 and cannot be null");
            }
            else
            {
                this.Select = select;
            }
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new InvalidDataException("query is a required property for Model9 and cannot be null");
            }
            else
            {
                this.Query = query;
            }
            this.Order = order;
        }
        
        /// <summary>
        /// Gets or Sets Select
        /// </summary>
        [DataMember(Name="select", EmitDefaultValue=false)]
        public string Select { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public Order Order { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model9 {\n");
            sb.Append("  Select: ").Append(Select).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as Model9);
        }

        /// <summary>
        /// Returns true if Model9 instances are equal
        /// </summary>
        /// <param name="input">Instance of Model9 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model9 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Select == input.Select ||
                    (this.Select != null &&
                    this.Select.Equals(input.Select))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
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
                if (this.Select != null)
                    hashCode = hashCode * 59 + this.Select.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
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
