using Huit.FaceitAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Interfaces
{
    public interface IMatches
    {
        MatchDetails GetMatch(string match_id);

        MatchStats GetMatchStatistics(string match_id);
    }
}
