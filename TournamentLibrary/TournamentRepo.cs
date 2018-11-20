using System.Collections.Generic;

namespace TournamentLib
{
    public class TournamentRepo
    {

        List<Tournament> tournaments = new List<Tournament>();

        public Tournament GetTournament(string name)
        {
            
            for (int i = 0; i < tournaments.Count; i++)
            {
                if (name == tournaments[i].Name)
                {
                    return tournaments[i];
                }
            }
            return null;
        }

        public List<Tournament> GetTournaments()
        {
            return tournaments;
        }

        public void AddTournament(Tournament tournament)
        {
            tournaments.Add(tournament);
        }
    }
}