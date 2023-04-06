using eShopSolution.Domain.Catalog.Dtos;
using eShopSolution.Domain.Catalog.Products.Dtos;
using eShopSolution.Domain.Catalog.Products.Dtos.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Domain.Catalog.Products
{
    public interface IPublicProductService
    {
        public PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest productPagingRequest);
    }
}
