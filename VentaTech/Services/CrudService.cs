using AutoMapper;
using VentaTechAPI.Repositories.Contracts;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Services
{
    public abstract class CrudService<TEntity, TResponseDTO, TRequestDTO> : ViewService<TEntity, TResponseDTO>, ICrudService<TRequestDTO, TResponseDTO>
        where TEntity : class
        where TResponseDTO : class
        where TRequestDTO : class
    {
        protected readonly ICrudRepository<TEntity> _crudRepository;
        public CrudService(ICrudRepository<TEntity> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
            _crudRepository = crudRepository;
        }

        public virtual async Task<TResponseDTO> CreateAsync(TRequestDTO requestDTO)
        {
            TEntity entityRequest = _mapper.Map<TEntity>(requestDTO);
            TEntity entityInserted = await _crudRepository.CreateAsync(entityRequest);
            TResponseDTO responseDTO = _mapper.Map<TResponseDTO>(entityInserted);
            return responseDTO;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool entityExist = await _crudRepository.ExistsAsync(id);

            if(!entityExist)
            {
                throw new ArgumentException($"El id {id} no se encuentra");
            }

            TEntity entity = await _crudRepository.GetByIdAsync(id);
            await _crudRepository.DeleteAsync(entity);

            return true;
        }

        public virtual async Task<TResponseDTO?> UpdateAsync(int id, TRequestDTO requestDTO)
        {
            TEntity? entity = await _crudRepository.GetByIdAsync(id);

            if(entity == null) return null;

            _mapper.Map(requestDTO, entity);

            entity = await _crudRepository.UpdateAsync(entity);
            
            TResponseDTO responseDTO = _mapper.Map<TResponseDTO>(entity);

            return responseDTO;
        }
    }
}
