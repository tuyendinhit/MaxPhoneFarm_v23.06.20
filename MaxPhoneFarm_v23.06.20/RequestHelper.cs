using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


public class RequestHelper
{
    public static async Task<string> GetURI(Uri u)
    {
        string response = string.Empty;
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage httpResponseMessage = await client.GetAsync(u);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                response = await httpResponseMessage.Content.ReadAsStringAsync();
            }
        }
        return response;
    }
    public static async Task<string> PostURI(Uri u, HttpContent c)
    {
        string response = string.Empty;
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage httpResponseMessage = await client.PostAsync(u, c);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                response = await httpResponseMessage.Content.ReadAsStringAsync();
            }
        }
        return response;
    }
}

