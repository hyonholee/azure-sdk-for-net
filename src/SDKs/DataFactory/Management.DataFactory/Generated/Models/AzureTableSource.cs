// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A copy activity Azure Table source.
    /// </summary>
    public partial class AzureTableSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the AzureTableSource class.
        /// </summary>
        public AzureTableSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureTableSource class.
        /// </summary>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="azureTableSourceQuery">Azure Table source query. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="azureTableSourceIgnoreTableNotFound">Azure Table
        /// source ignore table not found. Type: boolean (or Expression with
        /// resultType boolean).</param>
        public AzureTableSource(object sourceRetryCount = default(object), object sourceRetryWait = default(object), object azureTableSourceQuery = default(object), object azureTableSourceIgnoreTableNotFound = default(object))
            : base(sourceRetryCount, sourceRetryWait)
        {
            AzureTableSourceQuery = azureTableSourceQuery;
            AzureTableSourceIgnoreTableNotFound = azureTableSourceIgnoreTableNotFound;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure Table source query. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "azureTableSourceQuery")]
        public object AzureTableSourceQuery { get; set; }

        /// <summary>
        /// Gets or sets azure Table source ignore table not found. Type:
        /// boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "azureTableSourceIgnoreTableNotFound")]
        public object AzureTableSourceIgnoreTableNotFound { get; set; }

    }
}
