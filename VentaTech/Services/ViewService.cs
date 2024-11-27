using AutoMapper;
using VentaTechAPI.Repositories.Contracts;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Services
{
    public class ViewService<TEntity, TResponseDTO> : IViewService<TResponseDTO> 
        where TEntity : class 
        where TResponseDTO : class
    {
        protected readonly IViewRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public ViewService(IViewRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TResponseDTO>> GetAllAsync()
        {
            IEnumerable<TEntity> results = await _repository.GetAllAsync();
            return _mapper.Map<List<TResponseDTO>>(results);
        }

        public async Task<TResponseDTO?> GetByIdAsync(int id)
        {
            TEntity? result = await _repository.GetByIdAsync(id);
            if (result == null) return null;

            return _mapper.Map<TResponseDTO>(result);
        }
    }
}
