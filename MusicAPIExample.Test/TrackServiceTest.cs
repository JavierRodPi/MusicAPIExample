using MusicAPIExample.Track;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicAPIExample.Test
{
    [TestFixture]
    public class TrackServiceTest
    {
        private TrackService _trackService;

        [OneTimeSetUp]
        public void SetUpFixture()
        {
            _trackService = new TrackService(TrackRepositoryMock.GetMock().Object, ComposerServiceMock.GetMock().Object);
        }

        [Test]
        public async Task TrackService_GetTrackByGenreWithAuthorNameAsync_TrackList_CorrectOrder()
        {
            var expected = new List<Track.Track> {
                 new Track.Track
                {
                    Id = 2,
                    Title = "Elation Eve",
                    ComposerId = 2,
                    Genre = "rock",
                    ComposerName = "Mr Tim Garland"
                },
                new Track.Track
                {
                    Id = 3,
                    Title = "Home In The Sun",
                    ComposerId = 3,
                    Genre = "rock",
                    ComposerName = "Mr David Tobin"
                },
                new Track.Track
                {
                    Id = 1,
                    Title = "Shine Bright",
                    ComposerId = 1,
                    Genre = "rock",
                    ComposerName = "Mr Terry Devine King"
                }
            };

            var result = await _trackService.GetTrackByGenreWithAuthorNameAsync("rock");

            Assert.AreEqual(expected, result);
        }

        [Test]
        public async Task TrackService_GetTrackByGenreWithAuthorNameAsync_TrackList_IncorrectOrder()
        {
            var expected = new List<Track.Track> {
                 new Track.Track
                {
                    Id = 1,
                    Title = "Shine Bright",
                    ComposerId = 1,
                    Genre = "rock",
                    ComposerName = "Mr Terry Devine King"
                },
                 new Track.Track
                {
                    Id = 2,
                    Title = "Elation Eve",
                    ComposerId = 2,
                    Genre = "rock",
                    ComposerName = "Mr Tim Garland"
                },
                new Track.Track
                {
                    Id = 3,
                    Title = "Home In The Sun",
                    ComposerId = 3,
                    Genre = "rock",
                    ComposerName = "Mr David Tobin"
                },

            };

            var result = await _trackService.GetTrackByGenreWithAuthorNameAsync("rock");

            Assert.AreNotEqual(expected, result);
        }
    }
}
