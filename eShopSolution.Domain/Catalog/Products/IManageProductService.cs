﻿
using eShopSolution.Domain.Catalog.Dtos;
using eShopSolution.Domain.Catalog.Products.Dtos;
using eShopSolution.Domain.Catalog.Products.Dtos.Manage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addeQuantity);
        Task AddViewCount(int productId);
        Task UpdateViewCount(int productId);
        Task<List<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>>GetAllPaging(GetProductPagingRequest request);
    }
}