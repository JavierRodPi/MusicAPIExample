using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicAPIExample.Track
{
    public interface ITrackRepository
    {
        Task<IEnumerable<Track>> GetTracksByGenreAsync(string genre);
    }
}
