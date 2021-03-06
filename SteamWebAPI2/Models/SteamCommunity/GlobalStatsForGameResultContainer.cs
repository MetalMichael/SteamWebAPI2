﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;
using SteamWebAPI2.Utilities.JsonConverters;
using System.Collections.Generic;

namespace SteamWebAPI2.Models.SteamCommunity
{
    public class GlobalStat
    {
        public string Name { get; set; }
        public int Total { get; set; }
    }

    public class GlobalStatsForGameResult
    {
        [JsonConverter(typeof(GlobalStatJsonConverter))]
        [JsonProperty("globalstats")]
        public IList<GlobalStat> GlobalStats { get; set; }

        [JsonProperty("result")]
        public int Status { get; set; }
    }

    internal class GlobalStatsForGameResultContainer
    {
        [JsonProperty("response")]
        public GlobalStatsForGameResult Result { get; set; }
    }
}