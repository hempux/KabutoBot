/*
 * NinjaRMM Webhook (API 2.0)
 *
 * Ninja RMM Public Webhook PSA documentation.
 *
 * The version of the OpenAPI document: 2.0.5-draft
 * Contact: api@ninjarmm.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using net.hempux.ninjawebhook.Converters;

namespace net.hempux.ninjawebhook.Models
{ 
    /// <summary>
    /// Expanded entity references
    /// </summary>
    [DataContract]
    public class NodeReferences : IEquatable<NodeReferences>
    {
        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public Organization Organization { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or Sets RolePolicy
        /// </summary>
        [DataMember(Name="rolePolicy", EmitDefaultValue=false)]
        public Policy RolePolicy { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public Policy Policy { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public NodeRole Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeReferences {\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  RolePolicy: ").Append(RolePolicy).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((NodeReferences)obj);
        }

        /// <summary>
        /// Returns true if NodeReferences instances are equal
        /// </summary>
        /// <param name="other">Instance of NodeReferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeReferences other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Organization == other.Organization ||
                    Organization != null &&
                    Organization.Equals(other.Organization)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    RolePolicy == other.RolePolicy ||
                    RolePolicy != null &&
                    RolePolicy.Equals(other.RolePolicy)
                ) && 
                (
                    Policy == other.Policy ||
                    Policy != null &&
                    Policy.Equals(other.Policy)
                ) && 
                (
                    Role == other.Role ||
                    Role != null &&
                    Role.Equals(other.Role)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Organization != null)
                    hashCode = hashCode * 59 + Organization.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (RolePolicy != null)
                    hashCode = hashCode * 59 + RolePolicy.GetHashCode();
                    if (Policy != null)
                    hashCode = hashCode * 59 + Policy.GetHashCode();
                    if (Role != null)
                    hashCode = hashCode * 59 + Role.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NodeReferences left, NodeReferences right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NodeReferences left, NodeReferences right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
