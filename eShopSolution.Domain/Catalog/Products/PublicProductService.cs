using eShopSolution.Domain.Catalog.Dtos;
using eShopSolution.Domain.Catalog.Products;
using eShopSolution.Domain.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Domain.Catalog.Product
{
    public class PublicProductService : IPublicProductService
    {
        public PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
