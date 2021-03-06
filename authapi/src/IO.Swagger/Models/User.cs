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
    public partial class User : IEquatable<User>
    { 
        /// <summary>
        /// UUID of user
        /// </summary>
        /// <value>UUID of user</value>

        [DataMember(Name="userId")]
        public string UserId { get; set; }

        /// <summary>
        /// UUID of organization the user belongs to
        /// </summary>
        /// <value>UUID of organization the user belongs to</value>

        [DataMember(Name="organizationId")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// First name of user
        /// </summary>
        /// <value>First name of user</value>

        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        /// <value>Last name</value>

        [DataMember(Name="lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Middle name
        /// </summary>
        /// <value>Middle name</value>

        [DataMember(Name="middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// User email Address
        /// </summary>
        /// <value>User email Address</value>

        [DataMember(Name="mail")]
        public string Mail { get; set; }

        /// <summary>
        /// User phone number
        /// </summary>
        /// <value>User phone number</value>

        [DataMember(Name="phone")]
        public string Phone { get; set; }

        /// <summary>
        /// User position
        /// </summary>
        /// <value>User position</value>

        [DataMember(Name="position")]
        public string Position { get; set; }

        /// <summary>
        /// URL of user avatar
        /// </summary>
        /// <value>URL of user avatar</value>

        [DataMember(Name="avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// User Type
        /// </summary>
        /// <value>User Type</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CustomerUserEnum for customerUser
            /// </summary>
            [EnumMember(Value = "customerUser")]
            CustomerUserEnum = 0,
            /// <summary>
            /// Enum CustomerAdminEnum for customerAdmin
            /// </summary>
            [EnumMember(Value = "customerAdmin")]
            CustomerAdminEnum = 1,
            /// <summary>
            /// Enum InternalUserEnum for internalUser
            /// </summary>
            [EnumMember(Value = "internalUser")]
            InternalUserEnum = 2,
            /// <summary>
            /// Enum InternalAdminEnum for internalAdmin
            /// </summary>
            [EnumMember(Value = "internalAdmin")]
            InternalAdminEnum = 3        }

        /// <summary>
        /// User Type
        /// </summary>
        /// <value>User Type</value>

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// User account status
        /// </summary>
        /// <value>User account status</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ActiveEnum for active
            /// </summary>
            [EnumMember(Value = "active")]
            ActiveEnum = 0,
            /// <summary>
            /// Enum LockedEnum for locked
            /// </summary>
            [EnumMember(Value = "locked")]
            LockedEnum = 1,
            /// <summary>
            /// Enum InactiveEnum for inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            InactiveEnum = 2        }

        /// <summary>
        /// User account status
        /// </summary>
        /// <value>User account status</value>

        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Reason to assign current user status
        /// </summary>
        /// <value>Reason to assign current user status</value>

        [DataMember(Name="statusReason")]
        public string StatusReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
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
            return obj.GetType() == GetType() && Equals((User)obj);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
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
                    OrganizationId == other.OrganizationId ||
                    OrganizationId != null &&
                    OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    MiddleName == other.MiddleName ||
                    MiddleName != null &&
                    MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    Mail == other.Mail ||
                    Mail != null &&
                    Mail.Equals(other.Mail)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    Position == other.Position ||
                    Position != null &&
                    Position.Equals(other.Position)
                ) && 
                (
                    Avatar == other.Avatar ||
                    Avatar != null &&
                    Avatar.Equals(other.Avatar)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    StatusReason == other.StatusReason ||
                    StatusReason != null &&
                    StatusReason.Equals(other.StatusReason)
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
                    if (OrganizationId != null)
                    hashCode = hashCode * 59 + OrganizationId.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (MiddleName != null)
                    hashCode = hashCode * 59 + MiddleName.GetHashCode();
                    if (Mail != null)
                    hashCode = hashCode * 59 + Mail.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (Position != null)
                    hashCode = hashCode * 59 + Position.GetHashCode();
                    if (Avatar != null)
                    hashCode = hashCode * 59 + Avatar.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (StatusReason != null)
                    hashCode = hashCode * 59 + StatusReason.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(User left, User right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(User left, User right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
