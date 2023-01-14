using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048GameClassLibrary
{
    public class UsersResultsStorage
    {
        private string usersResultsFilePath = "Таблица всех игроков.json";
        public void SaveResultOfTesting(User user)
        {
            var userResults = GetUsersResults();
            userResults.Add(user);
            Save(userResults);
        }
        public List<User> GetUsersResults()
        {
            if (!File.Exists(usersResultsFilePath))
            {
                return new List<User>();
            }
            var fileData = usersResultsFilePath.GetInformation();
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }

        private void Save(List<User> usersResults)
        {
            var JsonData = JsonConvert.SerializeObject(usersResults);
            JsonData.SaveInformation(usersResultsFilePath);
        }

        public void ClearUsersResults()
        {
            File.Delete(usersResultsFilePath);
        }
    }
}
