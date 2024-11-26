﻿

// ReSharper disable UnusedMember.Global

namespace Yandex.Checkout.V3;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

[JsonConverter(typeof(StringEnumConverter), typeof(SnakeCaseNamingStrategy))]
public enum VatDataType
{
    Calculated,
    Untaxed
}
