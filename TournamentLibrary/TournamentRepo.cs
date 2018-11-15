using System.Collections.Generic;

namespace TournamentLib
{
    public class TournamentRepo
    {

        private Tournament winterTournament = new Tournament("Vinter Turnering");
        private Tournament summerTournament = new Tournament("Sommer Turnering");

        public Tournament GetTournament(string name)
        {
            if (name == "Vinter Turnering")
            {
                return winterTournament;
            }
            if (name == "Sommer Turnering")
            {
                return summerTournament;
            }
            
            return null;
        }
    }
}