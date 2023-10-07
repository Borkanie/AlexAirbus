// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

namespace Aerotec.Data.Model
{
    public class User
    {
        public User()
        {
            Id = "";
            Name = "";
        }
        internal User(string name)
        {
            Name = name;
        }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}