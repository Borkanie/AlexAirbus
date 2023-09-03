namespace Aerotec.Data.Model
{    
    public class User
    {
        internal User()
        {

        }
        internal User(string name)
        {
            Name = name;
        }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}