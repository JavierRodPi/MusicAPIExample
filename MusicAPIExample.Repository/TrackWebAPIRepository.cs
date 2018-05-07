using Microsoft.Extensions.Configuration;
using MusicAPIExample.Track;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MusicAPIExample.Repository
{
    public class TrackWebAPIRepository : ITrackRepository
    {
        private readonly HttpClient _client;

        public TrackWebAPIRepository(IConfiguration configuration)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(configuration["MusicService"])
            };
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<IEnumerable<Track.Track>> GetTracksByGenreAsync(string genre)
        {
            var response = await _client.GetAsync("tracks");

            var json = await response.Content.ReadAsStringAsync();
            var tracks = JsonConvert.DeserializeObject<IEnumerable<Track.Track>>(json);
            return tracks.Where(t => t.Genre == genre);
        }
    }
}
