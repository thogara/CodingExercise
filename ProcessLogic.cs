using CodingExercise.Data;
using CodingExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise
{
    public class ProcessLogic
    {
        public static void CallAnswers(string name)
        {
            UserSecurityQuestions uData = DataLogic.GetDate(name);
            bool userAnswered = false;
            foreach (QuestionAnswer q in uData.Questions)
            {
                Console.WriteLine(q.Question);
                string Answer = Console.ReadLine().ToString();
                if (Answer.Trim().Contains(q.Answer, StringComparison.OrdinalIgnoreCase))
                {
                    userAnswered = true;
                    break;
                }
            }
            if (userAnswered)
            {
                Console.WriteLine($"Congradulations {uData.UserName}!!");
            }
            else
            {
                Console.WriteLine("user runs out of questions");
            }
        }

        public static void CallStore(string name)
        {
            UserSecurityQuestions uData = new UserSecurityQuestions() { UserName = name };
            while (uData.Questions.Count < 3)
            {
                foreach (string question in StaticData.Questions)
                {
                    if (uData.Questions.Where(q => q.Question.Contains(question)).ToList().Count == 0)
                    {
                        Console.WriteLine(question);
                        string ans = Console.ReadLine().ToString();
                        if (ans.Trim().Length > 0)
                        {
                            uData.Questions.Add(new QuestionAnswer() { Question = question, Answer = ans });
                        }
                        if (uData.Questions.Count == 3)
                        {
                            break;
                        }
                    }
                }
            }
            string Name = CallPromptName();
            if (Name.Trim().Length > 0 && Name.Trim().Contains(name.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                DataLogic.SaveData(uData);
            }
            else
            {
                Console.WriteLine("user declined to store; name not matched!");
            }
        }

        public static string CallPromptName(bool save = false)
        {
            string Name = "";
            while (Name.Trim().Length == 0)
            {
                Console.WriteLine("Hi, what is your name ?");
                Name = Console.ReadLine().ToString();
                if (save)
                {
                    break;
                }
            }
            return Name;
        }
    }
}
