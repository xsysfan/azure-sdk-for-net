// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties for creating a custom image from a virtual machine.
    /// </summary>
    public partial class CustomImagePropertiesFromVm
    {
        /// <summary>
        /// Initializes a new instance of the CustomImagePropertiesFromVm
        /// class.
        /// </summary>
        public CustomImagePropertiesFromVm() { }

        /// <summary>
        /// Initializes a new instance of the CustomImagePropertiesFromVm
        /// class.
        /// </summary>
        public CustomImagePropertiesFromVm(string sourceVmId = default(string), bool? sysPrep = default(bool?), WindowsOsInfo windowsOsInfo = default(WindowsOsInfo), LinuxOsInfo linuxOsInfo = default(LinuxOsInfo))
        {
            SourceVmId = sourceVmId;
            SysPrep = sysPrep;
            WindowsOsInfo = windowsOsInfo;
            LinuxOsInfo = linuxOsInfo;
        }

        /// <summary>
        /// The source vm identifier.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmId")]
        public string SourceVmId { get; set; }

        /// <summary>
        /// Indicates whether sysprep has been run on the VHD.
        /// </summary>
        [JsonProperty(PropertyName = "sysPrep")]
        public bool? SysPrep { get; set; }

        /// <summary>
        /// The Windows OS information of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "windowsOsInfo")]
        public WindowsOsInfo WindowsOsInfo { get; set; }

        /// <summary>
        /// The Linux OS information of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "linuxOsInfo")]
        public LinuxOsInfo LinuxOsInfo { get; set; }

    }
}