using Huit.FaceitAPI.Interfaces;
using Huit.FaceitAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class Matches : ApiBase, IMatches
    {
        public Matches(Authorization authorization) : base (authorization)
        {

        }
        public MatchDetails GetMatch(string match_id) => this.Get<MatchDetails>("https://open.faceit.com/data/v4/matches/" + match_id);

        public MatchStats GetMatchStatistics(string match_id) => this.Get<MatchStats>("https://open.faceit.com/data/v4/matches/" + match_id + "/stats");
    }
}
