﻿using System;
using Binance.Net.Converters;
using Binance.Net.Enums;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Binance.Net.Objects.Models.Spot.Lending
{
    /// <summary>
    /// Interest record
    /// </summary>
    public class BinanceLendingInterestHistory
    {
        /// <summary>
        /// Interest
        /// </summary>
        public decimal Interest { get; set; }
        /// <summary>
        /// Asset name
        /// </summary>
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        [JsonProperty("time")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Lending type
        /// </summary>
        [JsonConverter(typeof(LendingTypeConverter))]
        public LendingType LendingType { get; set; }
        /// <summary>
        /// Name of the product
        /// </summary>
        public string ProductName { get; set; } = string.Empty;
    }
}
