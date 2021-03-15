using SuperMarket.Entites;
using SuperMarket.Infrastructure.Application;
using SuperMarket.Services.GoodCategores.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Services.GoodCategores
{
    public class GoodCategoryAppServices : GoodCategoryServices
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly GoodCategoryRepository _goodCategoryRepository;

        public GoodCategoryAppServices(UnitOfWork unitOfWork,GoodCategoryRepository goodCategoryRepository )
        {
            _unitOfWork = unitOfWork;
            _goodCategoryRepository = goodCategoryRepository;
        }
        public async Task Add(AddGoodCategoryDto dto)
        {
            if (await _goodCategoryRepository.IsExistTitle(dto.Title))
            {
                throw new Exception();
            }

            GoodCategory goodCategory = new GoodCategory();
            goodCategory.Title = dto.Title;

            _goodCategoryRepository.Add(goodCategory);
            _unitOfWork.Complete();
            
        }

        public async Task Delete(int id)
        {
            var goodCtagory =await _goodCategoryRepository.FindById(id);

            if (goodCtagory == null)
            {
                throw new Exception();
            }
            _goodCategoryRepository.Delete(goodCtagory);
            _unitOfWork.Complete();
        }

        public async Task<IList<GettAllGoodCategoryDto>> GetAll()
        {
            return await _goodCategoryRepository.GettAll();
        }

        public async Task<GettGoodCategoryByIdDto> GettById(int id)
        {
            if(!await _goodCategoryRepository.IsExistById(id))
            {
                throw new Exception();
            }
            return await _goodCategoryRepository.GettById(id);

        }

        public async Task Update(int id, UpdateGoodCategoryDto dto)
        {
            var goodCtagory = await _goodCategoryRepository.FindById(id);

            if (goodCtagory == null)
            {
                throw new Exception();
            }

            goodCtagory.Title = dto.Title;
            _unitOfWork.Complete();
        }
    }
}
