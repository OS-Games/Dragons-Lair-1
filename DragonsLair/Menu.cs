using System;
using System.Collections.Generic;
using TournamentLib;

namespace DragonsLair
{
    public class Menu
    {
        private Controller control = new Controller();
        
        
        public void Show()
        {
            bool running = true;
            do
            {
                ShowMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        Console.Clear();
                        CreateTournament();
                        break;
                    case "2":
                        Console.Clear();
                        ShowScore();
                        break;
                    case "3":
                        Console.Clear();
                        ScheduleNewRound();
                        break;
                    case "4":
                        Console.Clear();
                        SaveMatch();
                        break;
                    case "5":
                        Console.Clear();
                        AddTeamToTournament();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }



        private void ShowMenu()
        {
            Console.WriteLine("Dragons Lair");
            Console.WriteLine();
            Console.WriteLine("1. Skab ny turnering");
            Console.WriteLine("2. Præsenter turneringsstilling");
            Console.WriteLine("3. Planlæg runde i turnering");
            Console.WriteLine("4. Registrér afviklet kamp");
            Console.WriteLine("5. Tilmeld hold til turnering");
            Console.WriteLine("");
            Console.WriteLine("0. Exit");
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        
        private void ShowScore()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Clear();
            control.ShowScore(tournamentName);
        }

        private void ScheduleNewRound()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Clear();
            control.ScheduleNewRound(tournamentName);
        }

        private void SaveMatch()
        {
            
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Write("Angiv runde: ");
            int roundnr = int.Parse(Console.ReadLine());
            Console.Write("Angiv vinderhold: ");
            string winner = Console.ReadLine();
            Console.Clear();
            control.SaveMatch(tournamentName, roundnr, winner);
        }

        private void AddTeamToTournament()
        {
            Console.Write("Angiv navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Write("Angiv navn på hold: ");
            string teamName = Console.ReadLine();
            Console.Clear();
            control.AddTeamToTournament(teamName, tournamentName);
        }

        private void CreateTournament()
        {
            Console.Write("Navn på turnering: ");
            string tournamentName = Console.ReadLine();
            Console.Clear();
            control.CreateTournament(tournamentName);
        }
    }
}