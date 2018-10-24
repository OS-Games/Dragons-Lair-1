using System.Collections.Generic;

namespace TournamentLib
{
    public class Round
    {
        private List<Match> matches = new List<Match>();
        private Match match = new Match();
        
        public void AddMatch(Match m)
        {
            matches.Add(m);
        }

        public Match GetMatch(string teamName1, string teamName2)
        {
            Match getMatch = matches[0];
            for (int i = 0; i < matches.Count; i++)
            {
                if(teamName1 == match.FirstOpponent.ToString() && teamName2 == match.SecondOpponent.ToString())
                {
                    getMatch = matches[i];
                }
            }
            return getMatch;
        }

        public bool IsMatchesFinished()
        {
            
            return false;
        }

        public List<Team> GetWinningTeams()
        {
            // TODO: Implement this method
            List<Team> winningTeams = new List<Team>();
            for (int i = 0; i < matches.Count; i++)
            {
                winningTeams.Add(match.Winner);
            }
            return winningTeams;
        }

        public List<Team> GetLosingTeams()
        {
            // TODO: Implement this method
            List<Team> losingTeams = new List<Team>();
            for (int i = 0; i < matches.Count; i++)
            {
                if(match.Winner == match.FirstOpponent)
                {
                    losingTeams.Add(match.SecondOpponent);
                }
                else if(match.Winner == match.SecondOpponent)
                {
                    losingTeams.Add(match.FirstOpponent);
                }
            }
            return losingTeams;
        }
    }
}
