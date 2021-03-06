// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a token claim.
    /// </summary>
    public partial class ContentKeyPolicyTokenClaim
    {
        /// <summary>
        /// Initializes a new instance of the ContentKeyPolicyTokenClaim class.
        /// </summary>
        public ContentKeyPolicyTokenClaim()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentKeyPolicyTokenClaim class.
        /// </summary>
        /// <param name="claimType">Token claim type.</param>
        /// <param name="claimValue">Token claim value.</param>
        public ContentKeyPolicyTokenClaim(string claimType = default(string), string claimValue = default(string))
        {
            ClaimType = claimType;
            ClaimValue = claimValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets token claim type.
        /// </summary>
        [JsonProperty(PropertyName = "claimType")]
        public string ClaimType { get; set; }

        /// <summary>
        /// Gets or sets token claim value.
        /// </summary>
        [JsonProperty(PropertyName = "claimValue")]
        public string ClaimValue { get; set; }

    }
}
