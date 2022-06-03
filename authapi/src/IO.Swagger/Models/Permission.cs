/*
 * Permission Management API documentation
 *
 * This is an API for managing application permissions.
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Permission : IEquatable<Permission>
    { 
        /// <summary>
        /// UUID of permission
        /// </summary>
        /// <value>UUID of permission</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// optional UUID of application the permission belongs to
        /// </summary>
        /// <value>optional UUID of application the permission belongs to</value>

        [DataMember(Name="applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Permission entity type
        /// </summary>
        /// <value>Permission entity type</value>

        [DataMember(Name="entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// Permission operation name
        /// </summary>
        /// <value>Permission operation name</value>

        [DataMember(Name="operation")]
        public string Operation { get; set; }

        /// <summary>
        /// UUID of particular entity the permission belongs to, optional, for entity-level permission set
        /// </summary>
        /// <value>UUID of particular entity the permission belongs to, optional, for entity-level permission set</value>

        [DataMember(Name="entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// Permission description
        /// </summary>
        /// <value>Permission description</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Permission)obj);
        }

        /// <summary>
        /// Returns true if Permission instances are equal
        /// </summary>
        /// <param name="other">Instance of Permission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permission other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    ApplicationId == other.ApplicationId ||
                    ApplicationId != null &&
                    ApplicationId.Equals(other.ApplicationId)
                ) && 
                (
                    EntityType == other.EntityType ||
                    EntityType != null &&
                    EntityType.Equals(other.EntityType)
                ) && 
                (
                    Operation == other.Operation ||
                    Operation != null &&
                    Operation.Equals(other.Operation)
                ) && 
                (
                    EntityId == other.EntityId ||
                    EntityId != null &&
                    EntityId.Equals(other.EntityId)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ApplicationId != null)
                    hashCode = hashCode * 59 + ApplicationId.GetHashCode();
                    if (EntityType != null)
                    hashCode = hashCode * 59 + EntityType.GetHashCode();
                    if (Operation != null)
                    hashCode = hashCode * 59 + Operation.GetHashCode();
                    if (EntityId != null)
                    hashCode = hashCode * 59 + EntityId.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Permission left, Permission right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Permission left, Permission right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
