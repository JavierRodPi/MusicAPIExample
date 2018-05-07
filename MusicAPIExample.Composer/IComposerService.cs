using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicAPIExample.Composer
{
    public interface IComposerService
    {
        Task<IEnumerable<Composer>> GetComposersAsync();
    }
}
