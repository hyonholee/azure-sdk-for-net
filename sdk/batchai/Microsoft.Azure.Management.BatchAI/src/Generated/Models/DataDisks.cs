// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data disks settings.
    /// </summary>
    public partial class DataDisks
    {
        /// <summary>
        /// Initializes a new instance of the DataDisks class.
        /// </summary>
        public DataDisks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataDisks class.
        /// </summary>
        /// <param name="diskSizeInGB">Disk size in GB.</param>
        /// <param name="diskCount">Number of data disks.</param>
        /// <param name="storageAccountType">Storage account type.</param>
        /// <param name="cachingType">Caching type.</param>
        public DataDisks(int diskSizeInGB, int diskCount, string storageAccountType, CachingType? cachingType = default(CachingType?))
        {
            DiskSizeInGB = diskSizeInGB;
            CachingType = cachingType;
            DiskCount = diskCount;
            StorageAccountType = storageAccountType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets disk size in GB.
        /// </summary>
        /// <remarks>
        /// Disk size in GB for the blank data disks.
        /// </remarks>
        [JsonProperty(PropertyName = "diskSizeInGB")]
        public int DiskSizeInGB { get; set; }

        /// <summary>
        /// Gets or sets caching type.
        /// </summary>
        /// <remarks>
        /// Caching type for the disks. Available values are none (default),
        /// readonly, readwrite. Caching type can be set only for VM sizes
        /// supporting premium storage. Possible values include: 'none',
        /// 'readonly', 'readwrite'
        /// </remarks>
        [JsonProperty(PropertyName = "cachingType")]
        public CachingType? CachingType { get; set; }

        /// <summary>
        /// Gets or sets number of data disks.
        /// </summary>
        /// <remarks>
        /// Number of data disks attached to the File Server. If multiple disks
        /// attached, they will be configured in RAID level 0.
        /// </remarks>
        [JsonProperty(PropertyName = "diskCount")]
        public int DiskCount { get; set; }

        /// <summary>
        /// Gets or sets storage account type.
        /// </summary>
        /// <remarks>
        /// Type of storage account to be used on the disk. Possible values
        /// are: Standard_LRS or Premium_LRS. Premium storage account type can
        /// only be used with VM sizes supporting premium storage. Possible
        /// values include: 'Standard_LRS', 'Premium_LRS'
        /// </remarks>
        [JsonProperty(PropertyName = "storageAccountType")]
        public string StorageAccountType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountType");
            }
        }
    }
}