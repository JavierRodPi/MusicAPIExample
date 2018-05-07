using Moq;
using MusicAPIExample.Composer;
using System.Collections.Generic;

namespace MusicAPIExample.Test
{
    static class ComposerServiceMock
    {
        public static Mock<IComposerService> GetMock()
        {
            var mock = new Mock<IComposerService>();

            mock.Setup(c => c.GetComposersAsync()).ReturnsAsync(new List<Composer.Composer> {
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
            });    
            

            return mock;
        }
    }
}
