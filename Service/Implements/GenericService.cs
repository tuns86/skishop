using Core.Entities;
using Core.IRepositories;
using Core.ISpetification;
using Service.Interfaces;

namespace Service.Implements
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _repo;

        public GenericService(IGenericRepository<T> repo)
        {
            _repo = repo;
        }

        public void Add(T entity)
        {
            _repo.Add(entity);
        }

        public bool Exists(int id)
        {
            return _repo.Exists(id);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<T?> GetEntityWithSpec(ISpecification<T> spec)
        {
            return await _repo.GetEntityWithSpec(spec);
        }

        public async Task<TResult?> GetEntityWithSpec<TResult>(ISpecification<T, TResult> spec)
        {
            return await _repo.GetEntityWithSpec(spec);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _repo.ListAllAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await _repo.ListAsync(spec);
        }

        public async Task<IReadOnlyList<TResult>> ListAsync<TResult>(ISpecification<T, TResult> spec)
        {
            return await _repo.ListAsync(spec);
        }

        public void Remove(T entity)
        {
            _repo.Remove(entity);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _repo.SaveAllAsync();
        }

        public void Update(T entity)
        {
            _repo.Update(entity);
        }
    }
}
