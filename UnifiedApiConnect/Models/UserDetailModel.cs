using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace OfficeGraphHOL.Models
{
    public class UserDetailModel
    {
        public UserModel User { get; set; }
        public UserModel Manager { get; set; }
        public List<UserModel> DirectReports { get; set; }
        public List<FileModel> Files { get; set; }

        public async static Task<UserDetailModel> GetUserDetail(string path, string token)
        {
            UserDetailModel data = new UserDetailModel();

            //get the user
            var json = await GetJson(String.Format("https://graph.microsoft.com/beta/{0}", path), token);
            data.User = JsonConvert.DeserializeObject<UserModel>(json);

            //get the manager...might not exist
            json = await GetJson(String.Format("https://graph.microsoft.com/beta/{0}/manager", path), token);
            if (json == null)
                data.Manager = new UserModel();
            else
                data.Manager = JsonConvert.DeserializeObject<UserModel>(json);

            System.IO.File.AppendAllText(@"c:\temp\manager.json", JsonConvert.SerializeObject(data.Manager));

            //get the direct reports
            json = await GetJson(String.Format("https://graph.microsoft.com/beta/{0}/directReports", path), token);
            data.DirectReports = JObject.Parse(json).SelectToken("value").ToObject<List<UserModel>>();

            //get the files
            json = await GetJson(String.Format("https://graph.microsoft.com/beta/{0}/files", path), token);
            if (json == null)
                data.Files = new List<FileModel>();
            else
                data.Files = JObject.Parse(json).SelectToken("value").ToObject<List<FileModel>>();


            var jsonWorkingWith = String.Format("https://graph.microsoft.com/beta/{0}/WorkingWith", path);
            json = await GetJson(jsonWorkingWith, token);
            var users = JObject.Parse(json).ToObject<OfficeGraphHOL.Models.Workingwith.Rootobject>();
            var workingWithemails = new List<string>();

            foreach (var u in users.value)
            {
                var workingWithUsers = await GetJson(string.Format("https://graph.microsoft.com/beta/microsoft.com/" + u.odataid), token);
                workingWithemails.Add( JObject.Parse(workingWithUsers).ToObject<OfficeGraphHOL.Models.Users.Rootobject>().mail); 
            }
            System.IO.File.AppendAllText(@"c:\temp\workingwithemails.json", JsonConvert.SerializeObject(workingWithemails));

            var jsonQuery = String.Format("https://graph.microsoft.com/beta/me/messages?$select=Sender,From,CcRecipients,BccRecipients,ToRecipients,Importance,Subject,BodyPreview,HasAttachments&$filter=IsDraft+eq+false ", path);
            var emails = new List<Value>();

            for (int i = 0; i < 100; i++)
            {
                json = await GetJson(jsonQuery, token);

                var messageData = JObject.Parse(json).ToObject<Rootobject>();

                if (messageData.value.Count() < 10)
                    i = 1000;

                emails.AddRange(messageData.value);
            }

            System.IO.File.AppendAllText(@"c:\temp\messages.json", JsonConvert.SerializeObject( emails));

            //var messages = JObject.Parse(json).ToObject<Rootobject>();


            return data;
        }

        private async static Task<string> GetJson(string endpoint, string accessToken)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            using (HttpResponseMessage response = await client.GetAsync(new Uri(endpoint)))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                    return null;
            }
        }
    }
}