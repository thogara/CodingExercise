
using CodingExercise;
using CodingExercise.Data;
using CodingExercise.Models;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

while (true) 
{
    string Name = ProcessLogic.CallPromptName();
    
    UserSecurityQuestions uData = DataLogic.GetDate(Name);
    if((uData == null) )
    {
        ProcessLogic.CallStore(Name);
    }
    else
    {
        Console.WriteLine("Do you want to answer a security question?");
        string Answer = Console.ReadLine().ToString();
        if (Answer.Trim().Contains("yes", StringComparison.OrdinalIgnoreCase))
            ProcessLogic.CallAnswers(Name);
        else
            ProcessLogic.CallStore(Name);
    }
}


