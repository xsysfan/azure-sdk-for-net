// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a virtual machine scale set network profile's IP
    /// configuration.
    /// </summary>
    public partial class VirtualMachineScaleSetIPConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetIPConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetIPConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetIPConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetIPConfiguration(string name, VirtualMachineScaleSetIPConfigurationProperties properties = default(VirtualMachineScaleSetIPConfigurationProperties))
        {
            Name = name;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the IP configuration name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VirtualMachineScaleSetIPConfigurationProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
