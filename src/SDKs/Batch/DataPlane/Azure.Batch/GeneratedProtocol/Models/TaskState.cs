// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TaskState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskState
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "preparing")]
        Preparing,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "completed")]
        Completed
    }
    internal static class TaskStateEnumExtension
    {
        internal static string ToSerializedValue(this TaskState? value)
        {
            return value == null ? null : ((TaskState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskState value)
        {
            switch( value )
            {
                case TaskState.Active:
                    return "active";
                case TaskState.Preparing:
                    return "preparing";
                case TaskState.Running:
                    return "running";
                case TaskState.Completed:
                    return "completed";
            }
            return null;
        }

        internal static TaskState? ParseTaskState(this string value)
        {
            switch( value )
            {
                case "active":
                    return TaskState.Active;
                case "preparing":
                    return TaskState.Preparing;
                case "running":
                    return TaskState.Running;
                case "completed":
                    return TaskState.Completed;
            }
            return null;
        }
    }
}
