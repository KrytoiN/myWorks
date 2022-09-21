using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataProtectionLab1
{
    public class FileUsers
    {
        private string Name;

        public FileUsers()
        {
            Name = "users.txt";
            if (!File.Exists(Name))
                AddUser(User.CreateEmpty("ADMIN"));
        }

        public FileUsers(string FileName)
        {
            Name = FileName;
            if (!File.Exists(Name))
                AddUser(User.CreateEmpty("ADMIN"));
        }

        private void AddUser(User user)
        {
            using (var sw = File.AppendText(Name))
            {
                sw.Write("Username:" + user.Name + "  ");
                sw.Write("Password:" + user.Password + "  ");
                sw.Write("Blocked:" + user.IsBlocked + "  ");
                sw.Write("Restriction:" + user.HasPasswordRestriction + "  ");
                sw.WriteLine();
            }
        }

        public void FromMapToFile(Dictionary<string, User> users)
        {
            var tempFile = Path.GetTempFileName();
            using (var sw = File.AppendText(tempFile))
            {
                foreach (string key in users.Keys)
                {
                    sw.Write("Username:" + users[key].Name + "  ");
                    sw.Write("Password:" + users[key].Password + "  ");
                    sw.Write("Blocked:" + users[key].IsBlocked + "  ");
                    sw.Write("Restriction:" + users[key].HasPasswordRestriction + "  ");
                    sw.WriteLine();
                }
            }
            File.Delete(Name);
            File.Move(tempFile, Name);
        }

        private Dictionary<string, User> FromListToMap(List<string[]> info)
        {
            Dictionary<string, User> result = new Dictionary<string, User>();
            for (int i = 0; i < info.Count; ++i)
                result.Add(info[i][0], new User(info[i][0], info[i][1], Convert.ToBoolean(info[i][2]), Convert.ToBoolean(info[i][3])));
            return result;
        }

        public Dictionary<string, User> UsersFromFile()
        {
            string[] separatingStrings = { "Username:", "  ", "Password:", "Blocked:", "Restriction:" };

            Dictionary<string, User> UserRepositories = new Dictionary<string, User>();
            List<string[]> infoFromFile = new List<string[]>();
            using (var sr = File.OpenText(Name))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    infoFromFile.Add(line.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries));
            }
            return FromListToMap(infoFromFile);
        }

    }
}
