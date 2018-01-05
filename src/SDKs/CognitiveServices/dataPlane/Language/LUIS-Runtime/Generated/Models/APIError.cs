// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error information returned by the API
    /// </summary>
    public partial class APIError
    {
        /// <summary>
        /// Initializes a new instance of the APIError class.
        /// </summary>
        public APIError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the APIError class.
        /// </summary>
        /// <param name="statusCode">HTTP Status code</param>
        /// <param name="message">Cause of the error.</param>
        public APIError(string statusCode = default(string), string message = default(string))
        {
            StatusCode = statusCode;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets HTTP Status code
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets cause of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}