using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.Auth;
using DWC_Desktop.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Http
{
    public static class Client
    {
        public async static Task<R> Get<R>(string endpoint, bool auth = false)
        {
            using (HttpClient client = new HttpClient()) 
            {
                if (auth)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
                }

                HttpResponseMessage response = await client.GetAsync(Config.API_URL + endpoint);

                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    R responseObject = JsonConvert.DeserializeObject<R>(jsonResponse);

                    return responseObject;
                }

                handleError(jsonResponse);

                throw new Exception();
            }
        }

        public async static Task<R> Post<R, P>(string endpoint, P body, bool auth = false)
        {
            string request = JsonConvert.SerializeObject(body);

            using (HttpClient client = new HttpClient()) 
            { 
                if (auth)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
                }

                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(Config.API_URL + endpoint, content);

                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    R responseObject = JsonConvert.DeserializeObject<R>(jsonResponse);

                    return responseObject;
                }

                handleError(jsonResponse);

                throw new Exception();
            }
        }

        public async static Task<R> Delete<R>(string endpoint, bool auth = false)
        {
            using (HttpClient client = new HttpClient())
            {
                if (auth)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Token}");
                }

                HttpResponseMessage response = await client.DeleteAsync(Config.API_URL + endpoint);

                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    R responseObject = JsonConvert.DeserializeObject<R>(jsonResponse);

                    return responseObject;
                }

                handleError(jsonResponse);

                throw new Exception();
            }
        }

        private static void handleError(string jsonResponse)
        {
            HttpError error = JsonConvert.DeserializeObject<HttpError>(jsonResponse);

            if (error.statusCode == 401)
            {
                MessageBox.Show("Сессия истекла!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Users.DeleteUser(Config.Token);

                Application.Exit();

                return;
            }

            throw error;
        }
    }
}
