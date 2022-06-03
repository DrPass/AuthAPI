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
    public partial class Role : IEquatable<Role>
    { 
        /// <summary>
        /// UUID of role
        /// </summary>
        /// <value>UUID of role</value>

        [DataMember(Name="roleId")]
        public string RoleId { get; set; }

        /// <summary>
        /// Role name
        /// </summary>
        /// <value>Role name</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Role description
        /// </summary>
        /// <value>Role description</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Role Type, the customer roles can be created/edited by customer admins, the system ones managed by system admins
        /// </summary>
        /// <value>Role Type, the customer roles can be created/edited by customer admins, the system ones managed by system admins</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CustomerRoleEnum for customerRole
            /// </summary>
            [EnumMember(Value = "customerRole")]
            CustomerRoleEnum = 0,
            /// <summary>
            /// Enum SystemRoleEnum for systemRole
            /// </summary>
            [EnumMember(Value = "systemRole")]
            SystemRoleEnum = 1        }

        /// <summary>
        /// Role Type, the customer roles can be created/edited by customer admins, the system ones managed by system admins
        /// </summary>
        /// <value>Role Type, the customer roles can be created/edited by customer admins, the system ones managed by system admins</value>

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Allows to use entity-level permission set for users within current role
        /// </summary>
        /// <value>Allows to use entity-level permission set for users within current role</value>

        [DataMember(Name="entityLevelAccess")]
        public bool? EntityLevelAccess { get; set; }

        /// <summary>
        /// Role permissions
        /// </summary>
        /// <value>Role permissions</value>

        [DataMember(Name="permissions")]
        public List<Permission> Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Role {\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EntityLevelAccess: ").Append(EntityLevelAccess).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Role)obj);
        }

        /// <summary>
        /// Returns true if Role instances are equal
        /// </summary>
        /// <param name="other">Instance of Role to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Role other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RoleId == other.RoleId ||
                    RoleId != null &&
                    RoleId.Equals(other.RoleId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    EntityLevelAccess == other.EntityLevelAccess ||
                    EntityLevelAccess != null &&
                    EntityLevelAccess.Equals(other.EntityLevelAccess)
                ) && 
                (
                    Permissions == other.Permissions ||
                    Permissions != null &&
                    Permissions.SequenceEqual(other.Permissions)
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
                    if (RoleId != null)
                    hashCode = hashCode * 59 + RoleId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (EntityLevelAccess != null)
                    hashCode = hashCode * 59 + EntityLevelAccess.GetHashCode();
                    if (Permissions != null)
                    hashCode = hashCode * 59 + Permissions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Role left, Role right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Role left, Role right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}