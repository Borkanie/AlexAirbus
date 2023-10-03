// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Model;
using Newtonsoft.Json;

namespace Aerotec.Data.Factories
{
    static public class UserFactory
    {
        static private List<User> users = null;

        public static List<User> GetUsers()
        {
            if (users == null)
            {
                GenerateUsers();
            }
            return users;
        }

        private static void GenerateUsers()
        {
            // Read the JSON data from a file
            string jsonFilePath = "Resources/Controllers.json"; // Update with your JSON file path
            string json;


            json = File.ReadAllText(jsonFilePath);


            // Deserialize the JSON data into a list of User objects
            users = JsonConvert.DeserializeObject<List<User>>(json);
        }

        public static List<string> GetUserNames()
        {
            if (users == null)
            {
                GenerateUsers();
            }
            List<string> result = new();
            foreach (var user in users)
            {
                result.Add(user.Name);
            }
            return result;
        }
    }
}
