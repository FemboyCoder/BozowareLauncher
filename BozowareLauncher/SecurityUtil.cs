using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace BozowareLauncher
{
    public class SecurityUtil
    {
        public static string hashPassword(string unhashedPassword)
        {
            return unhashedPassword;
        }

        public static string getHWID(string clientUsername)
        {
            clientUsername = clientUsername.ToLower();
            var query = new ObjectQuery("select * from Win32_Processor");
            var mc = new ManagementObjectSearcher(query);
            var props = mc.Get().Cast<ManagementObject>()
                .SelectMany(m => m.Properties.Cast<PropertyData>())
                .ToDictionary(p => p.Name, p => p.Value);

            string toEncrypt = Environment.UserName + 
                               clientUsername + 
                               props["Description"] +
                               Environment.MachineName;
            
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt));

                return getStringFromBytes(true, hash);
            }
        }

        public static string hashPassword(string username, string password)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                string newData = getStringFromBytes(false, hash) + "sa" + username.ToLower() + "lt";
                hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(newData));
                return getStringFromBytes(false, hash);
            }
        }

        private static string getStringFromBytes(bool capitals, byte[] hash)
        {
            var sb = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                // can be "x2" if you want lowercase
                sb.Append(b.ToString(capitals ? "X2" : "x2"));
            }

            return sb.ToString();
        }
    }
}