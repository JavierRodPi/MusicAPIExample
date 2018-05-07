using MusicAPIExample.Composer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPIExample.Track
{
    public class TrackService : ITrackService
    {
        private ITrackRepository _trackRepository;
        private IComposerService _composerService;

        public TrackService(ITrackRepository trackRepository, IComposerService composerService)
        {
            _trackRepository = trackRepository;
            _composerService = composerService;
        }


        public async Task<IEnumerable<Track>> GetTrackByGenreWithAuthorNameAsync(string genre)
        {
            var tracks = await _trackRepository.GetTracksByGenreAsync(genre);

            if (tracks.Any())
            {
                var composers = await _composerService.GetComposersAsync();

                if (composers.Any())
                {
                    tracks = (from track in tracks
                             join composer in composers
                             on track.ComposerId equals composer.Id
                             select new Track
                             {
                                 Id = track.Id,
                                 ComposerId = track.ComposerId,
                                 Genre = track.Genre,
                                 Title = track.Title,
                                 ComposerName = GetComposerFullName(composer)
                             }).OrderBy(t => t.Title);
                }
            }

            return tracks;
        }

        private string GetComposerFullName(Composer.Composer composer)
        {
            if (composer != null)
                return $"{composer.Title} {composer.FirstName} {composer.LastName}";
            return string.Empty;
        }
    }
}
