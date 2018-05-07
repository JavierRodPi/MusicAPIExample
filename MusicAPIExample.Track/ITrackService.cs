using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicAPIExample.Track
{
    public interface ITrackService
    {
        Task<IEnumerable<Track>> GetTrackByGenreWithAuthorNameAsync(string genre);
    }
}
