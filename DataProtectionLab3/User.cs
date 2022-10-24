using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProtectionLab1
{
    public class User
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public bool IsBlocked { get; set; }

        public bool HasPasswordRestriction { get; set; }

        public User()
        {
        }

        public User(string name, byte[] password, bool isBlocked, bool hasPasswordRestriction)
        {
            Name = name;
            Password = Encoding.UTF8.GetString(password);
            IsBlocked = isBlocked;
            HasPasswordRestriction = hasPasswordRestriction;
        }

        public User(string name, string password, bool isBlocked, bool hasPasswordRestriction)
        {
            Name = name;
            Password = PasswordManager.Encrypt(name, password);
            IsBlocked = isBlocked;
            HasPasswordRestriction = hasPasswordRestriction;
        }

        public static User CreateEmpty(string name)
        {
            return new User(name, " ", false, true);
        }

    }
}
