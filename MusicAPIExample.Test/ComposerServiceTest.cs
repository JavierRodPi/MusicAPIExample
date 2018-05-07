using MusicAPIExample.Composer;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicAPIExample.Test
{
    [TestFixture]
    public class ComposerServiceTest
    {
        private ComposerService _composerService;

        [OneTimeSetUp]
        public void SetUpFixture()
        {
            _composerService = new ComposerService(ComposerRepositoryMock.GetMock().Object);
        }

        [Test]
        public async Task ComposerService_GetComposersAsync_ComposerList()
        {
            var expected = new List<Composer.Composer>
            {
                new Composer.Composer{
                    Id = 1,
                    Title = "Mr",
                    FirstName = "Terry",
                    LastName = "Devine King",
                    Award = "Grammy 2006"
                },
                new Composer.Composer{
                    Id = 2,
                    Title = "Mr",
                    FirstName = "Tim",
                    LastName = "Garland",
                    Award = "MTV Best New Artist 2001"
                },
                new Composer.Composer{
                    Id = 3,
                    Title = "Mr",
                    FirstName = "David",
                    LastName = "Tobin",
                    Award = "Teen Choice Awards Best song 2010"
                }
            };

            var result = await _composerService.GetComposersAsync();

            Assert.AreEqual(expected, result);
        }
    }
}
