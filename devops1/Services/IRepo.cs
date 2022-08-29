using System.Collections.Generic;
using System.Threading.Tasks;

namespace devops1.Services
{
    public interface IRepo<K,T>
    {
        public Task<T> Add(T item);
        public Task<T> Update(T item);
        public Task<ICollection<T>> GetAll();
    }
}
