// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CosmosDB
{
    [JsonSourceGenerationOptions(WriteIndented = false, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
    [JsonSerializable(typeof(ManagedServiceIdentity))]
    [JsonSerializable(typeof(SystemData))]
    [JsonSerializable(typeof(WritableSubResource))]
    [JsonSerializable(typeof(RetrieveThroughputPropertiesResource))]
    [JsonSerializable(typeof(RetrieveThroughputParameters))]
    internal partial class AzureResourceManagerCosmosDBJsonContext : JsonSerializerContext { }
}
