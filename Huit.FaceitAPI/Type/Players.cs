using Huit.FaceitAPI.Interfaces;
using Huit.FaceitAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class Players : ApiBase, IPlayers
    {
        protected Authorization authorization;
        private HttpResponseMessage httpResponseMessage;
        private string ResponseContent;
        private JsonDeserializer jsonDeserializer = new JsonDeserializer();
        IHttpClient httpClient = new Client();

        public Players(Authorization _authorization):base (_authorization)
        {
            this.authorization = _authorization;
        }

        // /players
        /// <summary>
        /// Описание метода получения данных игрока по нику
        /// </summary>
        /// <param name="NickName">Ник игрока, которого нужно узнать данные</param>
        /// <returns>данные о игроке</returns>
        public PlayerDetails GetPlayer(string NickName)
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
        public PlayerDetails GetPlayerByID(string PlayerID)
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
        public GameStat GetGameStats(string PlayerID, string GameID = "csgo")
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/players/" + PlayerID + "/stats/" + GameID, authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<GameStat>(ResponseContent);
            }
            return null;
        }


        // /players/{player_id}/hubs
        public Hubs GetHubs(string PlayerID, int offset = 0, int limit = 20)
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/players/"+PlayerID+"/hubs?offset="+offset+"&limit="+limit, authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<Hubs>(ResponseContent);
            }
            return null;
        }


        // /players/{player_id}/tournaments
        public Tournaments GetTournaments(string PlayerID, int offset = 0, int limit = 20)
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/players/" + PlayerID + "/tournaments?offset=" + offset + "&limit=" + limit, authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<Tournaments>(ResponseContent);
            }
            return null;
        }
    }
}
