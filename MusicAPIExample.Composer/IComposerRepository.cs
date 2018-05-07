using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicAPIExample.Composer
{
    public interface IComposerRepository
    {
        Task<IEnumerable<Composer>> GetComposersAsync();
    }
}
