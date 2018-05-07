using Moq;
using MusicAPIExample.Track;
using System.Collections.Generic;

namespace MusicAPIExample.Test
{
    static class TrackRepositoryMock
    {
        public static Mock<ITrackRepository> GetMock()
        {
            var mock = new Mock<ITrackRepository>();

            mock.Setup(c => c.GetTracksByGenreAsync("rock")).ReturnsAsync(new List<Track.Track> {
              new Track.Track
              {
                  Id = 1,
                  Title = "Shine Bright",
                  ComposerId = 1,
                  Genre = "rock"
              },
              new Track.Track
              {
                  Id = 2,
                  Title = "Elation Eve",
                  ComposerId = 2,
                  Genre = "rock"
              },
              new Track.Track
              {
                  Id = 3,
                  Title = "Home In The Sun",
                  ComposerId = 3,
                  Genre = "rock"
              },
            });
            return mock;
        }
    }
}
