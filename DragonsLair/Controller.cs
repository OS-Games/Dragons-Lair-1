using System;
using System.Collections.Generic;
using System.Linq;
using TournamentLib;

namespace DragonsLair
{
    public class Controller
    {
        private TournamentRepo tournamentRepository = new TournamentRepo();

        public void ShowScore(string tournamentName)
        {
            /*
             * TODO: Calculate for each team how many times they have won
             * Sort based on number of matches won (descending)
             */
            Tournament tournament = tournamentRepository.GetTournament("Vinter Turnering");
            List<int> points = new int[tournament.GetTeams().Count].ToList<int>();
            List<Team> teams = tournament.GetTeams();
            List<string> sortedList = new List<string>();

            int rounds = tournament.GetNumberOfRounds();
            for (int i = 0; i < rounds; i++)
            {
                List<Team> winners = tournament.GetRound(i).GetWinningTeams();
                foreach (Team winner in winners)
                {
                    for (int j = 0; j < tournament.GetTeams().Count; j++)
                    {
                        if (winner.Name == tournament.GetTeams()[j].Name)
                        {
                            points[j] = points[j] + 1;
                        }
                    }
                }
            }

            while (points.Count > 0)
            {
                int index = points.IndexOf(points.Max());
                sortedList.Add(teams[index].ToString() + ": " + points[index]);
                points.RemoveAt(index);
                teams.RemoveAt(index);
            }

            sortedList.ForEach(Console.WriteLine);
        }

        public void ScheduleNewRound(string tournamentName, bool printNewMatches = true)
        {
            // Do not implement this method
        }

        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
            // Do not implement this method
        }
    }
}
