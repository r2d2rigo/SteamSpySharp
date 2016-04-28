using Newtonsoft.Json;
using System.Collections.Generic;

namespace SteamSpySharp.Models
{
    [JsonObject]
    public class AppDetails
    {
        /// <summary>
        /// Steam Application ID. If it's 999999, then data for this application is hidden on developer's request, sorry.
        /// </summary>
        [JsonProperty("appid")]
        public int AppId { get; internal set; }

        /// <summary>
        /// The game's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; internal set; }

        /// <summary>
        /// Comma separated list of the developers of the game.
        /// </summary>
        [JsonProperty("developer")]
        public string Developers { get; internal set; }

        /// <summary>
        /// Comma separated list of the publishers of the game.
        /// </summary>
        [JsonProperty("publisher")]
        public string Publishers { get; internal set; }

        /// <summary>
        /// Score rank of the game based on user reviews.
        /// </summary>
        [JsonProperty("score_rank")]
        public int ScoreRank { get; internal set; }

        /// <summary>
        /// Owners of this application on Steam. ** Beware of free weekends!**
        /// </summary>
        [JsonProperty("owners")]
        public int Owners { get; internal set; }

        /// <summary>
        /// Variance in owners.The real number of owners lies somewhere on owners +/- owners_variance range.
        /// </summary>
        [JsonProperty("owners_variance")]
        public int OwnersVariance { get; internal set; }

        /// <summary>
        /// People that have played this game since March 2009.
        /// </summary>
        [JsonProperty("players_forever")]
        public int PlayersForever { get; internal set; }

        /// <summary>
        /// Variance for total players.
        /// </summary>
        [JsonProperty("players_forever_variance")]
        public int PlayersForeverVariance { get; internal set; }

        /// <summary>
        /// People that have played this game in the last 2 weeks.
        /// </summary>
        [JsonProperty("players_2weeks")]
        public int PlayersLastTwoWeeks { get; internal set; }

        /// <summary>
        /// Variance for the number of players in the last two weeks. 
        /// </summary>
        [JsonProperty("players_2weeks_variance")]
        public int PlayersLastTwoWeeksVariance { get; internal set; }

        /// <summary>
        /// Average playtime since March 2009. In minutes.
        /// </summary>
        [JsonProperty("average_forever")]
        public int AverageForever { get; internal set; }

        /// <summary>
        /// Average playtime in the last two weeks. In minutes.
        /// </summary>
        [JsonProperty("average_2weeks")]
        public int AverageLastTwoWeeks { get; internal set; }

        /// <summary>
        /// Median playtime since March 2009. In minutes.
        /// </summary>
        [JsonProperty("median_forever")]
        public int MedianForever { get; internal set; }

        /// <summary>
        /// Median playtime in the last two weeks. In minutes.
        /// </summary>
        [JsonProperty("median_2weeks")]
        public int MedianTwoWeeks { get; internal set; }

        /// <summary>
        /// Peak CCU yesterday.
        /// </summary>
        [JsonProperty("ccu")]
        public int ConcurrentUsers { get; internal set; }
    }
}
