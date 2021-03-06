﻿using SteamWebAPI2.Models.CSGO;
using System.Threading.Tasks;

namespace SteamWebAPI2.Interfaces
{
    /// <summary>
    /// Represents a Steam Web API interface endpoint located at ICSGOServers_730
    /// </summary>
    public class CSGOServers : SteamWebInterface
    {
        /// <summary>
        /// Default constructor established the Steam Web API key and initializes for subsequent method calls
        /// </summary>
        /// <param name="steamWebApiKey"></param>
        public CSGOServers(string steamWebApiKey)
            : base(steamWebApiKey, "ICSGOServers_730")
        { }

        /// <summary>
        /// Maps to the Steam Web API interface/method of ICSGOServers_730/GetGameServersStatus/v1
        /// </summary>
        /// <returns></returns>
        public async Task<ServerStatusResult> GetGameServerStatusAsync()
        {
            var gameServerStatus = await CallMethodAsync<ServerStatusResultContainer>("GetGameServersStatus", 1);
            return gameServerStatus.Result;
        }
    }
}