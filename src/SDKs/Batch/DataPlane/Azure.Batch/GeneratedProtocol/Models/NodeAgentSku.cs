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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A node agent SKU supported by the Batch service.
    /// </summary>
    /// <remarks>
    /// The Batch node agent is a program that runs on each node in the pool,
    /// and provides the command-and-control interface between the node and the
    /// Batch service. There are different implementations of the node agent,
    /// known as SKUs, for different operating systems.
    /// </remarks>
    public partial class NodeAgentSku
    {
        /// <summary>
        /// Initializes a new instance of the NodeAgentSku class.
        /// </summary>
        public NodeAgentSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeAgentSku class.
        /// </summary>
        /// <param name="id">The ID of the node agent SKU.</param>
        /// <param name="verifiedImageReferences">The list of Azure Marketplace
        /// images verified to be compatible with this node agent SKU.</param>
        /// <param name="osType">The type of operating system (e.g. Windows or
        /// Linux) compatible with the node agent SKU.</param>
        public NodeAgentSku(string id = default(string), IList<ImageReference> verifiedImageReferences = default(IList<ImageReference>), OSType? osType = default(OSType?))
        {
            Id = id;
            VerifiedImageReferences = verifiedImageReferences;
            OsType = osType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the node agent SKU.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the list of Azure Marketplace images verified to be
        /// compatible with this node agent SKU.
        /// </summary>
        /// <remarks>
        /// This collection is not exhaustive (the node agent may be compatible
        /// with other images).
        /// </remarks>
        [JsonProperty(PropertyName = "verifiedImageReferences")]
        public IList<ImageReference> VerifiedImageReferences { get; set; }

        /// <summary>
        /// Gets or sets the type of operating system (e.g. Windows or Linux)
        /// compatible with the node agent SKU.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'linux', 'windows'
        /// </remarks>
        [JsonProperty(PropertyName = "osType")]
        public OSType? OsType { get; set; }

    }
}
