using System;
using System.Collections.Generic;

namespace QuizApp
{
    public class QuizSystem
    {
        private User currentUser;
        private QuizManager quizManager;
        private List<User> users;

        public QuizSystem()
        {
            quizManager = new QuizManager();
            users = new List<User>();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Quiz App!");
            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Register");

            Console.Write("Type: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                LogIn();
            }
            else if (choice == "2")
            {
                Register();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        private void Register()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            if (users.Exists(u => u.Username == username))
            {
                Console.WriteLine("Username already exists.");
                return;
            }

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            Console.WriteLine("Enter birthdate (yyyy-mm-dd):");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            currentUser = new User(username, password, birthdate);
            users.Add(currentUser);

            Console.WriteLine("Registration successful!");
            LogIn();
        }

        private void LogIn()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            currentUser = users.Find(u => u.Username == username && u.Password == password);

            if (currentUser != null)
            {
                Console.WriteLine("Login successful!");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        private void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Start Quiz");
                Console.WriteLine("2. View Results");
                Console.WriteLine("3. Change Settings");
                Console.WriteLine("4. Exit");

                Console.Write("Choose: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    StartQuiz();
                }
                else if (choice == "2")
                {
                    ViewResults();
                }
                else if (choice == "3")
                {
                    ChangeSettings();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        private void StartQuiz()
        {
            Console.WriteLine("Choose a quiz category:");
            Console.WriteLine("1. Geography");
            Console.WriteLine("2. Math");
            Console.WriteLine("3. Mixed");

            Console.Write("Type by letters: ");
            string category = Console.ReadLine();
            quizManager.StartQuiz(category);
        }

        private void ViewResults()
        {
            currentUser.ShowResults();
        }

        private void ChangeSettings()
        {
            Console.WriteLine("1. Change password");
            Console.WriteLine("2. Change birthdate");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Enter new password:");
                currentUser.Password = Console.ReadLine();
                Console.WriteLine("Password changed!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter new birthdate (yyyy-mm-dd):");
                currentUser.Birthdate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Birthdate changed!");
            }
        }
    }
}