using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicAPIExample.Composer
{
    public class ComposerService : IComposerService
    {
        private IComposerRepository _composerRepository;

        public ComposerService(IComposerRepository composerRepository)
        {
            _composerRepository = composerRepository;
        }


        public async Task<IEnumerable<Composer>> GetComposersAsync()
        {
            return await _composerRepository.GetComposersAsync();
        }
    }
}
