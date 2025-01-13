using System;
using System.Collections.Generic;

namespace QuizApp
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public List<string> CorrectAnswers { get; set; }

        public Question(string questionText, List<string> options, List<string> correctAnswers)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswers = correctAnswers;
        }
    }
}