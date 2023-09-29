// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using System.Net;

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
