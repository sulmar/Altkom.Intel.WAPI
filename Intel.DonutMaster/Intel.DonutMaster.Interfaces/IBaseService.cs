using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel.DonutMaster.Interfaces
{
    public interface IBaseService<TItem, TKey>
    {
        IList<TItem> Get();

        TItem Get(TKey id);

        void Add(TItem item);

        void Update(TItem item);

        void Delete(TKey id);

        Task<IList<TItem>> GetAsync();

        Task<TItem> GetAsync(TKey id);

        Task AddAsync(TItem item);

        Task UpdateAsync(TItem item);

        Task DeleteAsync(TKey id);

    }
}
