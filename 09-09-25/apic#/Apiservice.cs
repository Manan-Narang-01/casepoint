using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace apic_
{
    public class Apiservice
    {
        private readonly HttpClient _httpclient;
        public Apiservice(string baseUrl)
        {
            _httpclient = new HttpClient { BaseAddress = new Uri(baseUrl) };
        }

        public async Task<List<T>> GetAllAsync<T>(string endpoint)
        {
            return await _httpclient.GetFromJsonAsync<List<T>>(endpoint);
        }

        public async Task<T> GetAsync<T>(string endpoint, int id)
        {
            return await _httpclient.GetFromJsonAsync<T>($"{endpoint}/{id}");
        }

        public async Task<string> CreateAsync<T>(string endpoint, T item)
        {
            var response = await _httpclient.PostAsJsonAsync(endpoint, item);
            return ((int)response.StatusCode).ToString();

        }


        public async Task<string> UpdateAsync<T>(string endpoint, int id, T item)
        {
            var response = await _httpclient.PutAsJsonAsync($"{endpoint}/{id}", item);
            return ((int)response.StatusCode).ToString();
        }

        public async Task<string> DeleteAsync<T>(string endpoint, int id)
        {
            var response = await _httpclient.DeleteAsync($"{endpoint}/{id}");
            return ((int)response.StatusCode).ToString();
        }


    }
}