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
                sw.Write("Password:" + "[" + user.Password + "]" + "  ");
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
                    sw.Write("Password:" + "[" + users[key].Password + "]" + "  ");
                    sw.Write("Blocked:" + users[key].IsBlocked + "  ");
                    sw.Write("Restriction:" + users[key].HasPasswordRestriction + "  ");
                    sw.WriteLine();
                }
            }
            File.Delete(Name);
            File.Move(tempFile, Name);
        }

        public Dictionary<string, User> UsersFromFile()
        {
            string[] separatingStrings = { "Username:", "  ", ",", "[", "]", "Password:", "Blocked:", "Restriction:" };
            Dictionary<string, User> UserRepositories = new Dictionary<string, User>();
            string[] v;
            using (var sr = File.OpenText(Name))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    v = line.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                    UserRepositories.Add(v[0], new User(v[0], Encoding.UTF8.GetBytes(v[1]), Convert.ToBoolean(v[2]), Convert.ToBoolean(v[3])));
                }
            }
            return UserRepositories;
        }

    }
}
