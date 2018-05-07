using Microsoft.Extensions.Configuration;
using MusicAPIExample.Composer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MusicAPIExample.Repository
{
    public class ComposerWebAPIRepository : IComposerRepository
    {
        private readonly HttpClient _client;

        public ComposerWebAPIRepository(IConfiguration configuration)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(configuration["MusicService"])
            };
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<Composer.Composer>> GetComposersAsync()
        {
            var response = await _client.GetAsync("composers");

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<Composer.Composer>>(json);
        }
    }
}
