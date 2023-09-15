using CodingExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise.Data
{
    public class DataLogic
    {
        public static UserSecurityQuestions GetDate(string name)
        {
            try
            {

                UserSecurityQuestions udata = UsersList.Load().Where(u => u.UserName.Contains(name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (udata != null)
                {
                    return udata;
                }
                else
                    return null;
            }
            catch (FileNotFoundException ex)
            {
                return null;
            }
        }
        public static void SaveData(UserSecurityQuestions uData)
        {
            UsersList data = UsersList.Load();
            UserSecurityQuestions existing = data.Where(s => s.UserName.Contains(uData.UserName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            if (existing == null)
            {
                data.Add(uData);
            }
            else
            {
                data.RemoveAll(s => s.UserName == uData.UserName);
                data.Add(uData);
            }
            data.Save();
        }
    }
}
