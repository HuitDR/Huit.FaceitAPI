using Huit.FaceitAPI.Interfaces;
using Huit.FaceitAPI.Models;
using Huit.FaceitAPI.Models.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class APIFaceit
    {
        protected Authorization authorization;
        private HttpResponseMessage httpResponseMessage;
        private string ResponseContent;
        private JsonDeserializer jsonDeserializer = new JsonDeserializer();
        IHttpClient httpClient = new Client();
        public APIFaceit(Authorization _authorization)
        {
            authorization = _authorization;
        }

        // matches
        // /matches/{match_id}/stats
        public MatchStats GetMatchStatistic(string MatchID)
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/matches/"+MatchID+"/stats", authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<MatchStats>(ResponseContent);
            }
            return null;
        }

        // Players

        // /players
        /// <summary>
        /// Описание метода получения данных игрока по нику
        /// </summary>
        /// <param name="NickName">Ник игрока, которого нужно узнать данные</param>
        /// <returns>данные о игроке</returns>
        public PlayerDetails GetPlayerDetails(string NickName)
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/players?nickname=" + NickName, authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<PlayerDetails>(ResponseContent);
            }
            return null;    
        }

        // /players/{player_id}
        /// <summary>
        /// Описание метода получения данных игрока по ID
        /// </summary>
        /// <param name="PlayerID">ID игрока, которого нужно узнать данные(пример: e2c8ca02-ea71-4597-839e-371641bae82c)</param>
        /// <returns>данные о игроке</returns>
        public PlayerDetails GetPlayerDetailsByID(string PlayerID)
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/players/" + PlayerID, authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<PlayerDetails>(ResponseContent);
            }
            return null;
        }

        // /players/{player_id}/history
        public MatchHistory GetMatchHistory(string PlayerID, string GameID = "csgo", int offset = 0, int limit = 20, Int64 from = 0, Int64 to = 0)
        {
            if (to == 0) { to = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds(); }
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/players/" + PlayerID + "/history?game=" + GameID + "&from=" + from + "&to=" + to + "&offset=" + offset + "&limit=" + limit, authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<MatchHistory>(ResponseContent);
            }
            return null;
        }

        // /players/{player_id}/stats/{game_id}
        public GameStat GetGameStat(string PlayerID, string GameID = "csgo")
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/players/"+PlayerID+"/stats/"+GameID, authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<GameStat>(ResponseContent);
            }
            return null;
        }
    }
}
