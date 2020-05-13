/* 
 * MELI Markeplace SDK
 *
 * This is a the codebase to generate a SDK for Open Platform Marketplace
 *
 * The version of the OpenAPI document: 0.0.13
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Variations
    /// </summary>
    [DataContract]
    public partial class Variations :  IEquatable<Variations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Variations" /> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="attributeCombinations">attributeCombinations.</param>
        /// <param name="availableQuantity">availableQuantity.</param>
        /// <param name="soldQuantity">soldQuantity.</param>
        /// <param name="pictureIds">pictureIds.</param>
        public Variations(int price = default(int), List<VariationsAttributeCombinations> attributeCombinations = default(List<VariationsAttributeCombinations>), int availableQuantity = default(int), int soldQuantity = default(int), List<string> pictureIds = default(List<string>))
        {
            this.Price = price;
            this.AttributeCombinations = attributeCombinations;
            this.AvailableQuantity = availableQuantity;
            this.SoldQuantity = soldQuantity;
            this.PictureIds = pictureIds;
        }
        
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public int Price { get; set; }

        /// <summary>
        /// Gets or Sets AttributeCombinations
        /// </summary>
        [DataMember(Name="attribute_combinations", EmitDefaultValue=false)]
        public List<VariationsAttributeCombinations> AttributeCombinations { get; set; }

        /// <summary>
        /// Gets or Sets AvailableQuantity
        /// </summary>
        [DataMember(Name="available_quantity", EmitDefaultValue=false)]
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// Gets or Sets SoldQuantity
        /// </summary>
        [DataMember(Name="sold_quantity", EmitDefaultValue=false)]
        public int SoldQuantity { get; set; }

        /// <summary>
        /// Gets or Sets PictureIds
        /// </summary>
        [DataMember(Name="picture_ids", EmitDefaultValue=false)]
        public List<string> PictureIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Variations {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  AttributeCombinations: ").Append(AttributeCombinations).Append("\n");
            sb.Append("  AvailableQuantity: ").Append(AvailableQuantity).Append("\n");
            sb.Append("  SoldQuantity: ").Append(SoldQuantity).Append("\n");
            sb.Append("  PictureIds: ").Append(PictureIds).Append("\n");
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
            return this.Equals(input as Variations);
        }

        /// <summary>
        /// Returns true if Variations instances are equal
        /// </summary>
        /// <param name="input">Instance of Variations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Variations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.AttributeCombinations == input.AttributeCombinations ||
                    this.AttributeCombinations != null &&
                    input.AttributeCombinations != null &&
                    this.AttributeCombinations.SequenceEqual(input.AttributeCombinations)
                ) && 
                (
                    this.AvailableQuantity == input.AvailableQuantity ||
                    this.AvailableQuantity.Equals(input.AvailableQuantity)
                ) && 
                (
                    this.SoldQuantity == input.SoldQuantity ||
                    this.SoldQuantity.Equals(input.SoldQuantity)
                ) && 
                (
                    this.PictureIds == input.PictureIds ||
                    this.PictureIds != null &&
                    input.PictureIds != null &&
                    this.PictureIds.SequenceEqual(input.PictureIds)
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
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.AttributeCombinations != null)
                    hashCode = hashCode * 59 + this.AttributeCombinations.GetHashCode();
                hashCode = hashCode * 59 + this.AvailableQuantity.GetHashCode();
                hashCode = hashCode * 59 + this.SoldQuantity.GetHashCode();
                if (this.PictureIds != null)
                    hashCode = hashCode * 59 + this.PictureIds.GetHashCode();
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
