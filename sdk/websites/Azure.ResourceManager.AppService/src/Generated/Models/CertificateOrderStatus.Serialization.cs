// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class CertificateOrderStatusExtensions
    {
        public static string ToSerialString(this CertificateOrderStatus value) => value switch
        {
            CertificateOrderStatus.Pendingissuance => "Pendingissuance",
            CertificateOrderStatus.Issued => "Issued",
            CertificateOrderStatus.Revoked => "Revoked",
            CertificateOrderStatus.Canceled => "Canceled",
            CertificateOrderStatus.Denied => "Denied",
            CertificateOrderStatus.Pendingrevocation => "Pendingrevocation",
            CertificateOrderStatus.PendingRekey => "PendingRekey",
            CertificateOrderStatus.Unused => "Unused",
            CertificateOrderStatus.Expired => "Expired",
            CertificateOrderStatus.NotSubmitted => "NotSubmitted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CertificateOrderStatus value.")
        };

        public static CertificateOrderStatus ToCertificateOrderStatus(this string value)
        {
            if (string.Equals(value, "Pendingissuance", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.Pendingissuance;
            if (string.Equals(value, "Issued", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.Issued;
            if (string.Equals(value, "Revoked", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.Revoked;
            if (string.Equals(value, "Canceled", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.Canceled;
            if (string.Equals(value, "Denied", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.Denied;
            if (string.Equals(value, "Pendingrevocation", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.Pendingrevocation;
            if (string.Equals(value, "PendingRekey", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.PendingRekey;
            if (string.Equals(value, "Unused", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.Unused;
            if (string.Equals(value, "Expired", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.Expired;
            if (string.Equals(value, "NotSubmitted", StringComparison.InvariantCultureIgnoreCase)) return CertificateOrderStatus.NotSubmitted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CertificateOrderStatus value.");
        }
    }
}
