// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Contains configuration options specific to the exhaustive KNN algorithm used during querying, which will perform brute-force search across the entire vector index. </summary>
    public partial class ExhaustiveKnnAlgorithmConfiguration : VectorSearchAlgorithmConfiguration
    {
        /// <summary> Initializes a new instance of ExhaustiveKnnAlgorithmConfiguration. </summary>
        /// <param name="name"> The name to associate with this particular configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ExhaustiveKnnAlgorithmConfiguration(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Kind = VectorSearchAlgorithmKind.ExhaustiveKnn;
        }

        /// <summary> Initializes a new instance of ExhaustiveKnnAlgorithmConfiguration. </summary>
        /// <param name="name"> The name to associate with this particular configuration. </param>
        /// <param name="kind"> The name of the kind of algorithm being configured for use with vector search. </param>
        /// <param name="parameters"> Contains the parameters specific to exhaustive KNN algorithm. </param>
        internal ExhaustiveKnnAlgorithmConfiguration(string name, VectorSearchAlgorithmKind kind, ExhaustiveKnnParameters parameters) : base(name, kind)
        {
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Contains the parameters specific to exhaustive KNN algorithm. </summary>
        public ExhaustiveKnnParameters Parameters { get; set; }
    }
}
