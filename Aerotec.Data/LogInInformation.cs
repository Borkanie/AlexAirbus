using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.Data
{
    public class LogInInformation
    {
        public LogInInformation(string name, string ip)
        {
            User = new User(name);
            Address = IPAddress.Parse(ip);
        }
        public User User { get; }

        public IPAddress Address { get; }
    }
}
