// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ValidationStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValidationStatus
    {
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "NotStarted")]
        NotStarted,
        [EnumMember(Value = "Initialized")]
        Initialized,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "CompletedWithIssues")]
        CompletedWithIssues,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Stopped")]
        Stopped
    }
    internal static class ValidationStatusEnumExtension
    {
        internal static string ToSerializedValue(this ValidationStatus? value)
        {
            return value == null ? null : ((ValidationStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ValidationStatus value)
        {
            switch( value )
            {
                case ValidationStatus.Default:
                    return "Default";
                case ValidationStatus.NotStarted:
                    return "NotStarted";
                case ValidationStatus.Initialized:
                    return "Initialized";
                case ValidationStatus.InProgress:
                    return "InProgress";
                case ValidationStatus.Completed:
                    return "Completed";
                case ValidationStatus.CompletedWithIssues:
                    return "CompletedWithIssues";
                case ValidationStatus.Failed:
                    return "Failed";
                case ValidationStatus.Stopped:
                    return "Stopped";
            }
            return null;
        }

        internal static ValidationStatus? ParseValidationStatus(this string value)
        {
            switch( value )
            {
                case "Default":
                    return ValidationStatus.Default;
                case "NotStarted":
                    return ValidationStatus.NotStarted;
                case "Initialized":
                    return ValidationStatus.Initialized;
                case "InProgress":
                    return ValidationStatus.InProgress;
                case "Completed":
                    return ValidationStatus.Completed;
                case "CompletedWithIssues":
                    return ValidationStatus.CompletedWithIssues;
                case "Failed":
                    return ValidationStatus.Failed;
                case "Stopped":
                    return ValidationStatus.Stopped;
            }
            return null;
        }
    }
}