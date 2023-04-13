
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Catalog.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.ProductImages;

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
        Task<PagedResult<ProductViewModel>>GetAllPaging(GetManageProductPagingRequest request);
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImages(int productId);
    }
}