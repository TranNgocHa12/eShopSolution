using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Domain.Catalog.Products
{
    public interface IPublicProductService
    {
        public Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        public Task<List<ProductViewModel>> GetAll();
    }
}
