// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> package carrier info. </summary>
    public partial class PackageCarrierInfo
    {
        /// <summary> Initializes a new instance of <see cref="PackageCarrierInfo"/>. </summary>
        public PackageCarrierInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PackageCarrierInfo"/>. </summary>
        /// <param name="carrierName"> Name of the carrier. </param>
        /// <param name="trackingId"> Tracking Id of shipment. </param>
        internal PackageCarrierInfo(string carrierName, string trackingId)
        {
            CarrierName = carrierName;
            TrackingId = trackingId;
        }

        /// <summary> Name of the carrier. </summary>
        public string CarrierName { get; set; }
        /// <summary> Tracking Id of shipment. </summary>
        public string TrackingId { get; set; }
    }
}
