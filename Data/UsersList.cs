using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodingExercise.Models;

namespace CodingExercise.Data
{
    [XmlRoot(ElementName = "Users")]
    public class UsersList : List<UserSecurityQuestions>
    {
        public static UsersList Load(string filename = "DataFile.xml")
        {
            UsersList list = new UsersList();
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(UsersList));
                using (StreamReader reader = new StreamReader(filename))
                {
                    if (reader != null)
                    {
                        list = ser.Deserialize(reader) as UsersList;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
            }
            return list;
        }
        public void Save(string filename = "DataFile.xml")
        {
            XmlSerializer ser = new XmlSerializer(typeof(UsersList));
            using (StreamWriter writer = new StreamWriter(filename))
            {
                ser.Serialize(writer, this);
            }
        }
    }
}
