using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.Data.Model
{
    public class LogInInformation
    {
        public LogInInformation(User user, string ip)
        {
            User = user;
            Address = IPAddress.Parse(ip);
        }
        public User User { get; }

        public IPAddress Address { get; }
    }
}
