using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise.Models
{
    public class UserSecurityQuestions
    {
        public string UserName { get; set; } 
        public List<QuestionAnswer> Questions { get; set; } = new List<QuestionAnswer>();
    }
}
