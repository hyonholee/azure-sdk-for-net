// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> VirtualHub route. </summary>
    public partial class VirtualHubRoute
    {
        /// <summary> Initializes a new instance of VirtualHubRoute. </summary>
        public VirtualHubRoute()
        {
        }

        /// <summary> Initializes a new instance of VirtualHubRoute. </summary>
        /// <param name="addressPrefixes"> List of all addressPrefixes. </param>
        /// <param name="nextHopIpAddress"> NextHop ip address. </param>
        internal VirtualHubRoute(IList<string> addressPrefixes, string nextHopIpAddress)
        {
            AddressPrefixes = addressPrefixes;
            NextHopIpAddress = nextHopIpAddress;
        }

        /// <summary> List of all addressPrefixes. </summary>
        public IList<string> AddressPrefixes { get; set; }
        /// <summary> NextHop ip address. </summary>
        public string NextHopIpAddress { get; set; }
    }
}
