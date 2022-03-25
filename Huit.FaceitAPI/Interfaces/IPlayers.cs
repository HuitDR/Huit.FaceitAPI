using Huit.FaceitAPI.Models;
using Huit.FaceitAPI.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Interfaces
{
    public interface IPlayers
    {
        PlayerDetails GetPlayer(string nickname);

        /// <summary>
        /// Описание метода получения данных игрока по ID
        /// </summary>
        /// <param name="PlayerID">ID игрока, которого нужно узнать данные(пример: e2c8ca02-ea71-4597-839e-371641bae82c)</param>
        /// <returns>данные о игроке</returns>
        PlayerDetails GetPlayerByID(string player_id);

        MatchHistory GetMatchHistory(string PlayerID, string GameID = "csgo", int offset = 0, int limit = 20, Int64 from = 0, Int64 to = 0);

        Hubs GetHubs(string player_id, int offset = 0, int limit = 20);

        GameStat GetGameStats(string player_id, string game_id);

        Tournaments GetTournaments(string player_id, int offset = 0, int limit = 20);
    }
}
