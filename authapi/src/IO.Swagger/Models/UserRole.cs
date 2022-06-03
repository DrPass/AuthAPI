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
    public partial class UserRole : IEquatable<UserRole>
    { 
        /// <summary>
        /// UUID of user
        /// </summary>
        /// <value>UUID of user</value>

        [DataMember(Name="userId")]
        public string UserId { get; set; }

        /// <summary>
        /// UUID of role
        /// </summary>
        /// <value>UUID of role</value>

        [DataMember(Name="roleId")]
        public string RoleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRole {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserRole)obj);
        }

        /// <summary>
        /// Returns true if UserRole instances are equal
        /// </summary>
        /// <param name="other">Instance of UserRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRole other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    RoleId == other.RoleId ||
                    RoleId != null &&
                    RoleId.Equals(other.RoleId)
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
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (RoleId != null)
                    hashCode = hashCode * 59 + RoleId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserRole left, UserRole right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserRole left, UserRole right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}