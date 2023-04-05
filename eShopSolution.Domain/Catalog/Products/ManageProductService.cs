using eShopSolution.Application.Catalog.Products;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Domain.Catalog.Dtos;
using eShopSolution.Domain.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Domain.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly EShopDbContext _context;
        public ManageProductService(EShopDbContext eShopDbContext) 
        {
            _context = eShopDbContext;
        }
        public Task<int> Create (ProductCreateRequest request)
        {
            var product = new eShopSolution.Data.Entities.Product()
            {
                Price = request.Price,
            };

            _context.Products.Add(product);
            return _context.SaveChangesAsync();
        }
        public Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }
        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
