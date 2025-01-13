using System;
using System.Collections.Generic;

namespace QuizApp
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public List<int> QuizScores { get; set; }

        public User(string username, string password, DateTime birthdate)
        {
            Username = username;
            Password = password;
            Birthdate = birthdate;
            QuizScores = new List<int>();
        }

        public void SaveQuizResult(int score)
        {
            QuizScores.Add(score);
        }

        public void ShowResults()
        {
            Console.WriteLine($"Quiz results for {Username}:");
            foreach (var score in QuizScores)
            {
                Console.WriteLine($"Score: {score}");
            }
        }
    }
}